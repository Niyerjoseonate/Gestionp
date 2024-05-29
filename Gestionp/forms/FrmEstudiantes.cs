using BLL;
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
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin ventanaPrincipal = new Admin();
            this.Hide();
            ventanaPrincipal.ShowDialog();
           
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            EstudianteService estudianteservi = new EstudianteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = estudianteservi.Consultar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
