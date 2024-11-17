using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using Document = iTextSharp.text.Document;
using System.IO;
using Rectangle = System.Drawing.Rectangle;
using PageSize = DocumentFormat.OpenXml.Wordprocessing.PageSize;

namespace Proyecto_final
{
    public partial class frmDetalleVenta : Form
    {
        private const float V = 10f;
        private CN_PRUDUCTOS obj_cnpro = new CN_PRUDUCTOS();
       
        float pago;
        float monto;

        public frmDetalleVenta()
        {
            InitializeComponent();

            dgvprod.CellValueChanged += new DataGridViewCellEventHandler(dgvprod_CellValueChanged);

            txtpago.KeyPress += new KeyPressEventHandler(txtpago_KeyPress);
        }

  
        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            txtpago.Text = "0.00";
            txtcambio.Text = "0.00";
            txtmtotal.Text = "0.00";

            pago = float.Parse(txtpago.Text);
            monto = float.Parse(txtmtotal.Text);



            txtfecha1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

    

        private void CalcularCambio()
        {
            decimal total = 0;
            decimal pago = 0;

            txtmtotal.Text = txtmtotal.Text.Replace(",", "");

            if (!string.IsNullOrWhiteSpace(txtmtotal.Text))
            {
                if (decimal.TryParse(txtmtotal.Text, out total))
                {
                    if (decimal.TryParse(txtpago.Text, out pago))
                    {
                        decimal cambio = pago - total;
                        txtcambio.Text = cambio.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un monto válido en el campo de pago.");
                    }
                }
                else
                {
                    MessageBox.Show("El valor del total no es válido.");
                }
            }
            else
            {
                MessageBox.Show("El campo de total está vacío.");
            }
        }



        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                CalcularCambio();

                e.Handled = true;
            }

        }

        private void txtcambio_TextChanged(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtmtotal.Text, out decimal total) &&
                decimal.TryParse(txtpago.Text, out decimal pago))
            {
                decimal cambio = pago - total;
                txtcambio.Text = cambio.ToString("0.00");
            }
        }

        private void txttpproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigoBarras = txtcbproducto.Text;
                PRODUCTO producto = BuscarProductoPorCodigoBarras(codigoBarras);

                if (producto != null)
                {

                    txtNombre.Text = producto.Prod_Nombre;

                    bool productoExistente = false;

                    foreach (DataGridViewRow row in dgvprod.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == producto.Prod_Id.ToString())
                        {

                            int cantidadActual = Convert.ToInt32(row.Cells[3].Value);
                            row.Cells[3].Value = cantidadActual + 1;


                            decimal precioUnitario = Convert.ToDecimal(row.Cells[4].Value);
                            row.Cells[5].Value = (cantidadActual + 1) * precioUnitario;

                            productoExistente = true;
                            break;

                        }
                       

                        txtcbproducto.Clear();
                    }


                    if (!productoExistente)
                    {
                        dgvprod.Rows.Add(" ", producto.Prod_Id, producto.Prod_Nombre, 1, producto.Prod_Precio, producto.Prod_Precio);
                    }

                    CalcularTotal();

                  
                    txtcbproducto.Clear();
                }

                e.Handled = true;
            }



        }

        private PRODUCTO BuscarProductoPorCodigoBarras(string codigoBarras)
        {

            return new CN_PRUDUCTOS().Listar().FirstOrDefault(p => p.Prod_Id.ToString() == codigoBarras);
        }

        private void icbticket_Click(object sender, EventArgs e)
        {


        }

        private void CalcularTotal()
        {
            decimal total = 0;


            foreach (DataGridViewRow row in dgvprod.Rows)
            {
                if (row.Cells[5].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells[5].Value);
                }
            }


            txtmtotal.Text = total.ToString();
        }

        private void txtfecha1_TextChanged(object sender, EventArgs e)
        {

            txtfecha1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dgvprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvprod.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                int cantidad = Convert.ToInt32(dgvprod.Rows[e.RowIndex].Cells["Cantidad"].Value);
                decimal precioU = Convert.ToDecimal(dgvprod.Rows[e.RowIndex].Cells["PrecioU"].Value);
                dgvprod.Rows[e.RowIndex].Cells["PrecioTotal"].Value = cantidad * precioU;

            }
        }

        private void dgvprod_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (dgvprod.Columns[e.ColumnIndex].Name == "Cantidad" || dgvprod.Columns[e.ColumnIndex].Name == "PrecioU"))
            {

                int cantidad = Convert.ToInt32(dgvprod.Rows[e.RowIndex].Cells["Cantidad"].Value);
                decimal precioU = Convert.ToDecimal(dgvprod.Rows[e.RowIndex].Cells["PrecioU"].Value);
                dgvprod.Rows[e.RowIndex].Cells["PrecioTotal"].Value = cantidad * precioU;

            }
        }

     

        private void icbquitarproducto_Click(object sender, EventArgs e)
        {

            if (dgvprod.Rows.Count > 0)
            {
                dgvprod.Rows.RemoveAt(dgvprod.Rows.Count - 1);

            }
        }

        private void txttpproducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbmontot_Click(object sender, EventArgs e)
        {

        }

        private void txttpproducto_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void ibtncobra_Click(object sender, EventArgs e)
        {
            Document pdfDoc = new Document(new iTextSharp.text.Rectangle(612f, 792f), 10f, 10f, 20f, 10f);

            string directorio = @"C:\Users\erick\Desktop\tickets";
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            string uniqueFileName = $"TicketDeCompra_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
            string rutaPDF = Path.Combine(directorio, uniqueFileName);

            using (FileStream stream = new FileStream(rutaPDF, FileMode.Create))
            {
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                pdfDoc.Add(new iTextSharp.text.Paragraph("UNA-FIT", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                pdfDoc.Add(new iTextSharp.text.Paragraph("Fecha: " + txtfecha1.Text));
                pdfDoc.Add(new iTextSharp.text.Paragraph("Folio:" + txtfolio.Text));
                pdfDoc.Add(new iTextSharp.text.Paragraph("================================"));

                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 100;
                float[] widths = new float[] { 1.5f, 4f, 2f, 2f };
                table.SetWidths(widths);

                table.AddCell(new PdfPCell(new iTextSharp.text.Phrase("Cantidad")) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new iTextSharp.text.Phrase("Nombre")) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new iTextSharp.text.Phrase("Precio U.")) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new iTextSharp.text.Phrase("Total")) { HorizontalAlignment = Element.ALIGN_CENTER });

                foreach (DataGridViewRow row in dgvprod.Rows)
                {
                    if (row.Cells["Nombre"].Value != null && row.Cells["Cantidad"].Value != null &&
                        row.Cells["PrecioU"].Value != null && row.Cells["PrecioTotal"].Value != null)
                    {
                        string nombre = row.Cells["Nombre"].Value.ToString();

                        int cantidad;
                        if (!int.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidad))
                        {
                            MessageBox.Show($"La cantidad para el producto '{nombre}' no es válida.", "Error de formato");
                            return;
                        }

                        string precioU = row.Cells["PrecioU"].Value.ToString();
                        string precioTotal = row.Cells["PrecioTotal"].Value.ToString();

                        table.AddCell(new PdfPCell(new iTextSharp.text.Phrase(cantidad.ToString())) { HorizontalAlignment = Element.ALIGN_CENTER });
                        table.AddCell(new PdfPCell(new iTextSharp.text.Phrase(nombre)) { HorizontalAlignment = Element.ALIGN_LEFT });
                        table.AddCell(new PdfPCell(new iTextSharp.text.Phrase(precioU)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                        table.AddCell(new PdfPCell(new iTextSharp.text.Phrase(precioTotal)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                        obj_cnpro.YTS(nombre, cantidad);
                    }
                }

                pdfDoc.Add(table);

                pdfDoc.Add(new iTextSharp.text.Paragraph("================================"));
                pdfDoc.Add(new iTextSharp.text.Paragraph($"Total: {txtmtotal.Text}"));
                pdfDoc.Add(new iTextSharp.text.Paragraph($"Pago: {txtpago.Text}"));
                pdfDoc.Add(new iTextSharp.text.Paragraph($"Cambio: {txtcambio.Text}"));
                pdfDoc.Add(new iTextSharp.text.Paragraph(" "));

                pdfDoc.Close();
            }

            System.Diagnostics.Process.Start(rutaPDF);
        }



    }
}
