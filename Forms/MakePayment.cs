using SportsClubProject.Classes;

namespace SportsClubProject.Forms
{
    public partial class MakePayment : Form
    {
        private Bill? bill;
        public MakePayment()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if (this.bill == null)
            {
                MessageBox.Show("No se pudo generar el comprobante de pago, contacte al administrador");
                return;
            }

            this.Hide();
            bill.TopMost = true;
            bill.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                string SucessMessage = "Se registro con exito el pago del ";

				if (string.IsNullOrWhiteSpace(txtNInsc.Text) || string.IsNullOrWhiteSpace(txtAmount.Text) || (!rbtnCash.Checked && !rbtnCard.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione una forma de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Postulant? postulant = Postulant.SelectFromDocument(Convert.ToInt32(txtNInsc.Text));

				float.TryParse(txtAmount.Text, out float amount);
				string paymentMethod;
				if (rbtnCash.Checked == true)
				{
					paymentMethod = "Efectivo";
					amount *= 0.90f;
				}
				else
				{
					paymentMethod = "Tarjeta";
				}

                //  No es socio
				if (postulant == null)
                {
                    //  Popup non postulant form to insert guest(non postulant) data
                    NonPostulantLog NonPostulantForm = new NonPostulantLog();
                    NonPostulantForm.ShowDialog();

                    if (NonPostulantForm.NonPostulant == null)
                    {
                        MessageBox.Show(
                            "Se necesita registrar el ingreso al club, reintente..."
                        );

                        return;
                    }

                    this.bill = Bill.FromNonPostulant(NonPostulantForm.NonPostulant, paymentMethod, amount);
                    SucessMessage += $"invitado con documento: {this.bill.document}";
                }
                else    // Si es socio
                {
                    //  Build a Bill from postulant data
                    this.bill = Bill.FromPostulant(postulant, paymentMethod, amount);
					SucessMessage += $"socio con documento: {this.bill.document}";
				}

				//  Build payment from Bill
				Payment payment = Payment.FromBill(bill);

				if (!payment.Insert())
				{
					MessageBox.Show($"No se pudo registrar el pago del socio Nro {txtNInsc.Text}\nContactese con el administrador");
                    this.Close();
				}

                if (postulant != null) {
                    Membership? membership = Membership.SelectFromPostulantID(postulant.ID);
                    if(membership == null)
                    {
						MessageBox.Show($"No se pudo registrar el pago del socio Nro {txtNInsc.Text}\nContactese con el administrador");
                        this.Close();
                        return;
					}

                    bool updated = membership.UpdateFromPayment(this.bill.amount);

					if (!updated)
                    {
						MessageBox.Show($"No se pudo registrar el pago del socio Nro {txtNInsc.Text}\nContactese con el administrador");
						this.Close();
						return;
					}
                }

                //  Se pudo registrar el pago correctamente
				MessageBox.Show(SucessMessage);

				btnBill.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registrando el pago: \n{ex.Message}", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
