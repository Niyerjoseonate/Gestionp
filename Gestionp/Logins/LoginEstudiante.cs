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
    public partial class LoginEstudiante : Form
    {
        public LoginEstudiante()
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
    }
}
