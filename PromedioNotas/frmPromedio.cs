using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class frmPromedio : Form
    {
        public frmPromedio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promedio objP = new();
            objP.nombre = txtnombre.Text;
            objP.Nota1 = int.Parse(txtN1.Text);
            objP.Nota2 = int.Parse(txtN2.Text);
            objP.Nota3 = int.Parse(txtN3.Text);
            objP.Nota4 = int.Parse(txtN4.Text);


            lblNotaBaja.Text = objP.notaBaja().ToString("0.00");
            lblPromedio.Text = objP.promedio().ToString("0.00");
            lblCondicion.Text = objP.Condicion();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?",
                "Medidas", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
