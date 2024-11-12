using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.Utilidades;
using CapaEntidades;
using CapaNegocios;

namespace Proyecto_final
{
    public partial class frmUsuario : Form
    {
        private CN_USUARIOS objCD_USUARIO = new CN_USUARIOS();

        private static IconButton a = null;
        private static Form FormularioActivo = null;
        public frmUsuario()
        {
            InitializeComponent();
        }

       

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvusuario.Columns[e.ColumnIndex].Name == "dgvbtnseleciona" && e.RowIndex >= 0)
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtNombre.Text = dgvusuario.Rows[indice].Cells["NombreU"].Value.ToString();
                    txtphone.Text = dgvusuario.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtcorreo.Text = dgvusuario.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvusuario.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (optioncombo oc in cborol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvusuario.Rows[indice].Cells["id_rol"].Value))
                        {
                            cborol.SelectedItem = oc;
                            break;
                        }
                    }

                    foreach (optioncombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvusuario.Rows[indice].Cells["Estado_Valor"].Value))
                        {
                            cboestado.SelectedItem = oc;
                            break;
                        }
                    }
                }
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new optioncombo() { Valor = 1, Texto = "Activo" });
            cboestado.Items.Add(new optioncombo() { Valor = 0, Texto = "No Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<ROL> listarol = new CN_ROL().Listar();

            foreach (ROL item in listarol)
            {
                cborol.Items.Add(new optioncombo() { Valor = item.Id_Rol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;

         
            List<USUARIO> listausuario = new CN_USUARIOS().Listar();

            foreach (USUARIO item in listausuario)
            {
                dgvusuario.Rows.Add(new object[] { "",item.Id_Usuario,item.Nombre_Usuario,item.Telefono,item.Correo,item.Clave,
                item.oROl.Id_Rol,item.oROl.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo",
                });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;
        }

        private void lbNU_Click(object sender, EventArgs e)
        {

        }

        private void lbtitulolistausuario_Click(object sender, EventArgs e)
        {

        }

        private void ibtnsave_Click(object sender, EventArgs e)
        {
            USUARIO objusuario = new USUARIO()
            {
                //Id_Usuario = Convert.ToInt32(txtId.Text),
                Nombre_Usuario = txtNombre.Text,
                Telefono = txtphone.Text,
                Clave = txtclave.Text,
                Correo = txtcorreo.Text,                
                oROl = new ROL() { Id_Rol = Convert.ToInt32(((optioncombo)cborol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((optioncombo)cboestado.SelectedItem).Valor) == 1 ? true : false
            };

            string nombre = txtNombre.Text;
            string phone = txtphone.Text;
            string clave = txtclave.Text;
            string correo = txtcorreo.Text;
            int id_rol = Convert.ToInt32(((optioncombo)cborol.SelectedItem).Valor);
            Boolean estado = Convert.ToInt32(((optioncombo)cboestado.SelectedItem).Valor) == 1 ? true : false;

            if (objCD_USUARIO.sihay(nombre))
            {
                try
                {
                    objCD_USUARIO.editar(nombre, phone, clave, correo, id_rol, estado);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    objCD_USUARIO.registrar(nombre, phone, clave, correo, id_rol, estado);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el usuario: " + ex.Message);
                }
            }
            CargarUsuarios();
            Limpiar();     
            

        }

        


        private void dgvusuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var W = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - W) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, W, h));
                e.Handled = true;

            }
        }

        private void ibtneliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            objCD_USUARIO.elimina(nombre);
            CargarUsuarios();
            Limpiar();
        }

        private void Limpiar()
        {

            txtNombre.Text = " ";
            txtphone.Text = " ";
            txtcorreo.Text =  " ";
            txtclave.Text = " ";
            cborol.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;
        }

        private void CargarUsuarios()
        {
            dgvusuario.Rows.Clear(); // Limpia el DataGridView antes de recargar
            List<USUARIO> listausuario = new CN_USUARIOS().Listar();

            foreach (USUARIO item in listausuario)
            {
                dgvusuario.Rows.Add(new object[]
                {
            "",
            item.Id_Usuario,
            item.Nombre_Usuario,
            item.Telefono,
            item.Correo,
            item.Clave,
            item.oROl.Id_Rol,
            item.oROl.Descripcion,
            item.Estado ? 1 : 0,
            item.Estado ? "Activo" : "No Activo",
                });
            }
        }

       
    }
}


    

