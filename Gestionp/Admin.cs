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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocentes ventanaRdocentes = new FrmDocentes();
            this.Hide();
            ventanaRdocentes.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes ventanaRestudiantes = new FrmEstudiantes();
            this.Hide();
            ventanaRestudiantes.ShowDialog();
            
        }
    }
}
