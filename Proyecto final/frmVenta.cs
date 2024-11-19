using CapaEntidades;
using CapaNegocios;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }


        private void frmVenta_Load(object sender, EventArgs e)
        {
            /*
             List<CLIENTE> ptcliente = new CN_CLIENTE().Listar();

          foreach(CLIENTE item in ptcliente)
          {
              dgvcliente.Rows.Add(new object[] { "", item.Cli_Id,item.Cli_Nombre, item.Cli_Edad, item.Cli_Telefono, item.Cli_Telefono_Emer,
                  item.Cli_Domicilio, item.Cli_Colonia,
                  item.oestatus.est_id,item.oestatus.Est_descricion,
                  item.Fecha_Creacion, item.Fecha_termina });
          }
             */
            List<DETALLEVENTA> ptnventadeta = new CN_DETALLEVENTA().Listar();

            foreach(DETALLEVENTA item in ptnventadeta)
            {
                dgvventa.Rows.Add(new object[] { item.folio,item.oproducto.Prod_Id,item.oproducto.Prod_Nombre,
                    item.Precio_Produnitario,item.Cantidad,item.Precio_Prodxcant,item.TotalVenta,item.FechaRegistro});
            }

        }

        private void ibtnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dgvventa.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn colum in dgvventa.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                    {
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvventa.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]{
                            //10 este numero puede cambiar depende de las columnas que se vaya a pasara la excel
                            row.Cells[1].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
 

                        });
                    }
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("REPORTE DE Ventas_{0}.xlsx ", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void ibtnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
