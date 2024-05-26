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
            bill.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
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
                    if(rbtnCash.Checked == true)
                    {
                        bill.formPay = "Efectivo";
                        bill.amount = (float)(bill.amount * 0.90);
                    }
                    else
                    {
                        bill.formPay = "Tarjeta";
                    }
                    //btnComprobante.Enabled = true;
                    query = $"INSERT INTO payment(IdPostulant) VALUES ({txtNInsc.Text})";
                    MySqlCommand insertCommand = new MySqlCommand(query, conn);
                    insertCommand.ExecuteNonQuery();
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
