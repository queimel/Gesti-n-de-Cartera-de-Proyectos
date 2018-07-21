using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCarteraProyectos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Limpiar()
        {
            tb_periodo.Text = "";
            tb_codigo.Text = "";
            dt_fecha.Text = "";
            tb_duracion.Text = "";
            cb_nivel1.Text = "";
            tb_montoTotal1.Text = "";

            cb_nivel2.Text = "";
            tb_montoDesde.Text = "";
            tb_hasta.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_periodo.Focus();
            Limpiar();


        }
    }
}
