using MySql.Data.MySqlClient;
using SportsClubProject.Classes;
using SportsClubProject.Data;
using System;
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

        private void button2_Click(object sender, EventArgs e)
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
            MySqlConnection conn = new MySqlConnection();
            try
            {
                if (string.IsNullOrWhiteSpace(txtNInsc.Text) || string.IsNullOrWhiteSpace(txtAmount.Text) || (!rbtnCash.Checked && !rbtnCard.Checked))
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione una forma de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query;
                conn = Connection.GetInstance().CreateConnection();
                query = "select ID, concat(FirstName, ' ', LastName), InscriptionDate " +
                    $"from postulants where ID = {txtNInsc.Text}"; 
                MySqlCommand command = new MySqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    bill.fullName = reader.GetString(1);
                    bill.date = reader.GetDateTime(2);
                    float.TryParse(txtAmount.Text, out float amount);
                    if (rbtnCash.Checked == true)
                    {
                        bill.formPay = "Efectivo";
                        bill.amount = amount * 0.90f;
                    }
                    else
                    {
                        bill.formPay = "Tarjeta";
                        bill.amount = amount;
                    }
                    reader.Close();

                    query = "INSERT INTO payment(IdPostulant, amount) " +
                        $"VALUES ({txtNInsc.Text}, {bill.amount})";
                    MySqlCommand insertCommand = new MySqlCommand(query, conn);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show($"Se registro con exito el pago del socio Nro {txtNInsc.Text}");

                    btnBill.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número de inscripcion inexistente","AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { conn.Close(); };
            }
        }
    }
}
