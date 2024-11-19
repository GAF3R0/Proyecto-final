using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;
using ClosedXML.Excel;
using QRCoder;
using Proyecto_final.Utilidades;

namespace Proyecto_final
{
    public partial class frmMienbros : Form
    {
        private CN_CLIENTE objcn_cliente = new CN_CLIENTE();
        
        public frmMienbros()
        {
            InitializeComponent();
        }

        private void frmMienbros_Load(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtnombre.Enabled = false;
           

            List<CLIENTE> listmiembre = new CN_CLIENTE().LDM();

            foreach (CLIENTE item in listmiembre)
            {
                dgvmiembro.Rows.Add(new object[] { "",item.oestatus.Est_descricion, item.Cli_Id, item.Cli_Nombre,item.Cli_Telefono,item.Cli_Telefono_Emer,item.Cli_Correo,
                    item.Cli_Domicilio,item.Cli_Colonia,item.Fecha_Creacion,item.Fecha_termina});
            }
        }

        private void ibtnsave_Click(object sender, EventArgs e)
        {

            int idact = int.Parse(txtid.Text);

            objcn_cliente.soyyootravez(idact);
            CargarClientes();
        }

        private void ibtneliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgvusuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvmiembro.Columns[e.ColumnIndex].Name == "dgvbtnsleciona" && e.RowIndex >= 0)
            {
                

                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtid.Text = dgvmiembro.Rows[indice].Cells["Id_Cliente"].Value.ToString();
                    txtnombre.Text = dgvmiembro.Rows[indice].Cells["NombreM"].Value.ToString();
                }
            }
        }




        private void CargarClientes()
        {


            dgvmiembro.Rows.Clear(); // Limpia el DataGridView antes de recargar
            List<CLIENTE> listmiembre = new CN_CLIENTE().LDM();

            foreach (CLIENTE item in listmiembre)
            {
                int rowIndex = dgvmiembro.Rows.Add();
                DataGridViewRow row = dgvmiembro.Rows[rowIndex];
                row.Cells["estatus"].Value = item.oestatus.Est_descricion;
                row.Cells["Id_Cliente"].Value = item.Cli_Id;
                row.Cells["NombreM"].Value = item.Cli_Nombre;
                row.Cells["Telefono"].Value = item.Cli_Telefono;
                row.Cells["Telefono_emer"].Value = item.Cli_Telefono_Emer;
                row.Cells["Correo"].Value = item.Cli_Correo;
                row.Cells["Domicilio"].Value = item.Cli_Domicilio;
                row.Cells["Ciudad"].Value = item.Cli_Colonia;
                row.Cells["FechaCreacion"].Value = item.Fecha_Creacion;
                row.Cells["FechaTermina"].Value = item.Fecha_termina;
            }

        }

        private void dgvmiembro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

     

        private void ibtnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dgvmiembro.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn colum in dgvmiembro.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                    {
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvmiembro.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]{
                            //10 este numero puede cambiar depende de las columnas que se vaya a pasara la excel
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString()

                        });
                    }
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("REPORTE DE MIEMBROS_{0}.xlsx ", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel file | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();

                        var hoja = wb.Worksheets.Add(dt, "informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }

        }

        private void icbgenerarqr_Click(object sender, EventArgs e)
        {

                int idact = int.Parse(txtid.Text);
                objcn_cliente.generaqr(idact);

        }

       
    }
}
