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
            this.mensaje_tt.SetToolTip(this.nombre_txt, "Ingrese el nombre de la categoria");
        }

        private void MensajeOk(string mensaje)
        {
            //este seria igual al JOptionPanel.ShowMessageDialog();
            MessageBox.Show(mensaje, "Systema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                string salida = "";
                if (this.nombre_txt.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    errorIcono.SetError(nombre_txt, "Ingrese un Nombre");
                }
                else
                {
                    if (this.is_nuevo)
                    {
                        //el metodo trim() elimina espacios ingresados de mas
                        salida = NCategoria.Insertar(this.nombre_txt.Text.Trim(), descripcion_txt.Text.Trim());
                    }
                    else
                    {
                        salida = NCategoria.Editar(Convert.ToInt32(this.codigo_txt.Text), nombre_txt.Text.Trim(), descripcion_txt.Text.Trim());
                    }
                    if (salida.Equals("OK"))
                    {
                        if (this.is_nuevo)
                        {
                            this.MensajeOk("Se inserto de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizo de forma conrrecta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(salida);
                    }
                    this.is_nuevo = false;
                    this.is_editable = false;
                    this.Botones();
                    this.Linpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void buscar_txt_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void nuevo_btn_Click(object sender, EventArgs e)
        {
            this.is_nuevo = true;
            this.is_editable = false;
            this.Botones();
            this.Linpiar();
            this.Habilitar(true);
            this.nombre_txt.Focus();
        }

        private void listado_data_DoubleClik(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listado_data_DoubleClick(object sender, EventArgs e)
        {
            this.codigo_txt.Text = Convert.ToString(this.listado_data.CurrentRow.Cells["idcategoria"].Value);
            this.nombre_txt.Text = Convert.ToString(this.listado_data.CurrentRow.Cells["nombre"].Value);
            this.descripcion_txt.Text = Convert.ToString(this.listado_data.CurrentRow.Cells["descripcion"].Value);
            
            //tabcontrol es las pestañas que aparecen en el listado, es decir , las solapas, 
            //en este caso elijo la solapa mantenimiento, y le asigno el indice de solapa
            //en este caso la solapa 1
            this.tabControl1.SelectedIndex = 1;
        }

        private void editar_btn_Click(object sender, EventArgs e)
        {
            if (!this.codigo_txt.Text.Equals(""))
            {
                this.is_editable = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe de selecionar primero el registro a Modificar");
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.is_nuevo = false;
            this.is_editable = false;
            this.Botones();
            this.Linpiar();
            this.Habilitar(false);
        }

        private void eliminar_ckb_CheckedChanged(object sender, EventArgs e)
        {            
            this.listado_data.Columns[0].Visible = eliminar_ckb.Checked;         
        }

        private void listado_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==listado_data.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell eliminar_chk = (DataGridViewCheckBoxCell)listado_data.Rows[e.RowIndex].Cells["Eliminar"];
                eliminar_chk.Value = !Convert.ToBoolean(eliminar_chk.Value);
            }
        }


        //misantropo
        //al tener el grid, es decir la tabla un checkbock, se cuentan las columnas de esta manera
        //checkbox = row.Cells[0]
        //idcategoria = row.Cells[1]
        //nombre = row.Cells[2]
        //categoria = row.Cells[3]
        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente decea eliminar los registros", "Sistema de Ventas",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string salida = "";
                   
                    foreach(DataGridViewRow row in listado_data.Rows){
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            //obtengo la clave primaria
                            codigo = Convert.ToString(row.Cells[1].Value);
                            salida = NCategoria.Eliminar(Convert.ToInt32(codigo));
                         //   MessageBox.Show(Convert.ToString(row.Cells[2].Value), "algo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            if (salida.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino correctamente el registro");
                                eliminar_ckb.Checked= false;
                            }
                            else
                            {
                                this.MensajeError(salida);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        

    }

}
