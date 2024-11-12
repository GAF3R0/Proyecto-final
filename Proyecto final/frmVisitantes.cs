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
using Proyecto_final.Utilidades;

namespace Proyecto_final
{
    public partial class frmregistar_Visitantes : Form
    {
        public frmregistar_Visitantes()
        {
            InitializeComponent();
        }

        private void lbbuscar_Click(object sender, EventArgs e)
        {

        }

        private void frmregistar_Visitantes_Load(object sender, EventArgs e)
        {
            List<CLIENTE> listvisita = new CN_CLIENTE().LDV();

            foreach (CLIENTE item in listvisita)
            {
                dgvvisita.Rows.Add(new object[] { "",item.oestatus.Est_descricion, item.Cli_Id, item.Cli_Nombre,item.Cli_Telefono,item.Cli_Telefono_Emer,item.Cli_Correo,
                    item.Cli_Domicilio,item.Cli_Colonia,item.Fecha_Creacion,item.Fecha_termina});
            }
        }

        private void ibtnexportarexcel_Click(object sender, EventArgs e)
        {
            if (dgvvisita.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn colum in dgvvisita.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                    {
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvvisita.Rows)
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
         

                        });
                    }
                }
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("REPORTE DE VISITANTES{0}.xlsx ", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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


    }
}
