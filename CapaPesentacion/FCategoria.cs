using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPesentacion
{
    public partial class FCategoria : Form
    {
        private bool is_nuevo;
        private bool is_editable;
        public FCategoria()
        {
            InitializeComponent();
            this.mensaje_tt.SetToolTip(this.nombre_txt,"Ingrese el nombre de la categoria");
        }

        private void MensajeOk(string mensaje)
        {
            //este seria igual al JOptionPanel.ShowMessageDialog();
            MessageBox.Show(mensaje,"Systema de Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            //este seria igual al JOptionPanel.ShowMessageDialog();
            MessageBox.Show(mensaje, "Systema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Linpiar()
        {
            this.nombre_txt.Text = string.Empty;
            this.descripcion_txt.Text = string.Empty;
            this.codigo_txt.Text = string.Empty;
        }

        //Habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.nombre_txt.ReadOnly = !valor;
            this.descripcion_txt.ReadOnly = !valor;
            this.codigo_txt.ReadOnly = !valor;
        }

        //Habilitar los botones
        private void Botones()
        {
            if (this.is_nuevo || this.is_editable)
            {
                this.Habilitar(true);
                this.nuevo_btn.Enabled = false;
                this.guardar_btn.Enabled = true;
                this.editar_btn.Enabled = false;
                this.cancelar_btn.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.nuevo_btn.Enabled = true;
                this.guardar_btn.Enabled = false;
                this.editar_btn.Enabled = true;
                this.cancelar_btn.Enabled = false;
            }
        }

        //Ocultar columnas
        private void OcultarColumnas()
        {
            this.listado_data.Columns[0].Visible = false;
            this.listado_data.Columns[1].Visible = false;
        }


        //Mostrar
        private void Mostrar()
        {
            this.listado_data.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            total_lbl.Text = "Total de Registros: " + Convert.ToString(listado_data.Rows.Count);
        }

        //Buscar por nombre
        private void BuscarNombre()
        {
            this.listado_data.DataSource = NCategoria.BuscarNombre(this.buscar_txt.Text);
            this.OcultarColumnas();
            total_lbl.Text = "Total de Registros: " + Convert.ToString(listado_data.Rows.Count);
        }

        private void FCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void buscar_txt_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
    }
}
