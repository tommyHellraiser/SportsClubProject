using SportsClubProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportsClubProject.Forms
{
    public partial class NonPostulantLog : Form
    {
        internal NonPostulant? NonPostulant;
        public NonPostulantLog ()
        {
            InitializeComponent();
        }

		#region Handlers
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
					MessageBox.Show("Debe completar los datos requeridos",
					"AVISO DEL SISTEMA", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				else
				{
					NonPostulant NewNonPostulant = new NonPostulant(
						txtName.Text,
						txtLastName.Text,
						cboType.Text,
						Convert.ToInt32(txtDni.Text)
					);
					//  Insert non postulant into database
					bool inserted = NewNonPostulant.Insert();
					if (!inserted)
					{
						MessageBox.Show(
							"No se pudo guardar el registro de no socio, contacte al administrador"
						);
					}

					this.NonPostulant = NewNonPostulant;
					this.Close();
				}
			}
            catch (Exception ex)
			{
				MessageBox.Show($"Error ingresando registro de no socio:\n{ex.Message}");
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

		#endregion
	}
}
