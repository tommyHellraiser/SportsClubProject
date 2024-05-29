using MySql.Data.MySqlClient;
using SportsClubProject.Classes;
using SportsClubProject.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubProject.Forms
{
    public partial class MakePayment : Form
    {
        Bill bill = new Bill();
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
            this.Hide();
            bill.TopMost = true;
            bill.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNInsc.Text) || string.IsNullOrWhiteSpace(txtAmount.Text) || (!rbtnCash.Checked && !rbtnCard.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione una forma de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Postulant? postulant = Postulant.SelectFromDocument(Convert.ToInt32(txtNInsc.Text));
                if (postulant != null)
                {
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

                    //  Build a Bill from postulant data
                    Bill bill = Bill.FromPostulant(postulant, paymentMethod, amount);
                    this.bill = bill;

                    //  Build payment from Bill
                    Payment payment = Payment.FromBill(bill);

                    if(payment.Insert())
                    {
						MessageBox.Show($"Se registro con exito el pago del socio Nro {txtNInsc.Text}");
					}
                    else
                    {
						MessageBox.Show($"No se pudo registrar el pago del socio Nro {txtNInsc.Text}\nContactese con el administrador");
					}
					
					btnBill.Enabled = true;
				}
                else
                {
					MessageBox.Show("Número de inscripcion inexistente", "AVISO DEL SISTEMA",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
