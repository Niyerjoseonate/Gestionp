using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionp
{
    public partial class loginprincipal : Form
    {
        public loginprincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Profesor_Click(object sender, EventArgs e)
        {
            loginProfesor ventanaProfesor = new loginProfesor();
            this.Hide();
            ventanaProfesor.ShowDialog();
            //this.Show();
        }

        private void btn_Estudiante_Click(object sender, EventArgs e)
        {
            LoginEstudiante ventanaEstudiante = new LoginEstudiante();
            this.Hide();
            ventanaEstudiante.ShowDialog();
            //this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            LoginAdmin ventanaAdmin = new LoginAdmin();
            this.Hide();
            ventanaAdmin.ShowDialog();
        }
    }
}
