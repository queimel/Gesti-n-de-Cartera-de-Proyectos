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
            tb_periodo.Text = DateTime.Today.ToString("yyyy");

            l_mensajes.Text = "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if("".Equals(tb_periodo.Text))
            {
                l_mensajes.Text = "Debe ingresar un periodo";
                tb_periodo.Focus();
            }
            else
            {
                int codigo;
                if (int.TryParse(tb_codigo.Text, out codigo))
                {
                    if(codigo > 0)
                    {
                        if ("".Equals(dt_fecha.Text))
                        {
                            l_mensajes.Text = "Debe elegir una fecha";
                            dt_fecha.Focus();
                        }
                        else
                        {
                            int duracion;
                            if (int.TryParse(tb_duracion.Text, out duracion))
                            {
                                if(duracion > 0)
                                {
                                    if (cb_nivel1.SelectedIndex > -1)
                                    {
                                        int montoTotal;
                                        if (int.TryParse(tb_montoTotal1.Text, out montoTotal))
                                        {
                                            if(montoTotal > 1)
                                            {
                                                // instanciar objeto proyecto para agregarlo a lista
                                                // llamar a metodo para agregar n° de proyectos en carpeta
                                                l_mensajes.Text = " Validado!";
                                            }
                                            else
                                            {
                                                l_mensajes.Text = "El monto total debe ser mayor a 1";
                                                tb_montoTotal1.Focus();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        l_mensajes.Text = " Debe seleccionar un nivel";
                                        cb_nivel1.Focus();
                                    }
                                }
                                else
                                {
                                    l_mensajes.Text = "La duración debe ser mayor a 0";
                                    tb_duracion.Focus();
                                }
                            }
                            else
                            {
                                l_mensajes.Text = "Debe ingresar los meses de duración";
                                tb_duracion.Focus();
                            }
                        }
                    }
                }
                else
                {
                    l_mensajes.Text = "Debe ingresar un número de código";
                    tb_codigo.Focus();
                }
            }
        }

        private void cb_nivel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_mensajes.Text = "";
        }

        private void cb_nivel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            l_mensajes.Text = "";
        }
    }
}
