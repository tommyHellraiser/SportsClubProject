using SportsClubProject.Classes;

namespace SportsClubProject.Forms
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
				if (txtName.Text == "" || txtLastName.Text == "" ||
				txtDni.Text == "" || cboType.Text == "")
				{
					MessageBox.Show("Debe completar datos requeridos",
					"AVISO DEL SISTEMA", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				else
				{
					string response;
					Postulant newPostulant = new Postulant();
					newPostulant.FirstName = txtName.Text;
					newPostulant.LastName = txtLastName.Text;
					newPostulant.DocumentType = cboType.Text;
					newPostulant.Document = Convert.ToInt32(txtDni.Text);

					NewPostulants postulants = new NewPostulants();
					response = postulants.NewPostulant(newPostulant);
					bool isNumber = int.TryParse(response, out int code);
					if (isNumber)
					{
						//  For code -1, postulant already exists. Retry with another Document
						if (code == -1)
						{
							MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}

						//	Get postulant's ID from database to create new membership
						Postulant? postulant = Postulant.SelectFromDocument(newPostulant.Document);
						if (postulant == null)
						{
							MessageBox.Show(
								"Error finalizando la inscripcion, contacte al administrador"
							);
							this.Close();
							return;
						}

						//  Create a membership and save it in database
						Membership membership = Membership.FromPostulant(postulant);
						membership.InsertNew();

						MessageBox.Show("se almaceno con exito con el codigo Nro"
							+ response, "AVISO DEL SISTEMA",
						MessageBoxButtons.OK, MessageBoxIcon.Question);

						this.Close();
					}
				}
			}
            catch(Exception ex)
            {
				MessageBox.Show(
					$"Error al registrar un nuevo socio: \n{ex.Message}",
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
				this.Close();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtDni.Text = "";
            cboType.Text = "";
            txtName.Focus();
        }
    }
}
