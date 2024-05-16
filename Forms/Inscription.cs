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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtLastName.Text == "" ||
                txtDni.Text == "" || cboType.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string response;
                Postulant newPostulant = new Postulant();
                newPostulant.Name = txtName.Text;
                newPostulant.LastName = txtLastName.Text;
                newPostulant.Doc = Convert.ToInt32(txtDni.Text);
                newPostulant.TDoc = cboType.Text;

                NewPostulants postulants = new NewPostulants();
                response = postulants.NewPostulant(newPostulant);
                bool isNumber = int.TryParse(response, out int code);
                if (isNumber)
                {
                    if (code == 1)
                    {
                        MessageBox.Show("POSTULANTE YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro"
                            + response, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
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
