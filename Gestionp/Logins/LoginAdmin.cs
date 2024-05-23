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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            loginprincipal ventanaPrincipal = new loginprincipal();
            this.Hide();
            ventanaPrincipal.ShowDialog();
            this.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Admin ventanaAdmin = new Admin();
            this.Hide();
            ventanaAdmin.ShowDialog();
        }
    }
}
