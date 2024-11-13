using CapaEntidades;
using CapaNegocios;
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
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
            
            dgvprod.CellValueChanged += new DataGridViewCellEventHandler(dgvprod_CellValueChanged);
            
            txtpago.KeyPress += new KeyPressEventHandler(txtpago_KeyPress);
        }

        private void ibtnlimpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            
            txtfecha1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtmtotal_TextChanged(object sender, EventArgs e)
        {
            
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            
            decimal total = dgvprod.Rows.Cast<DataGridViewRow>()
                          .Sum(row => Convert.ToDecimal(row.Cells["Cantidad"].Value) * Convert.ToDecimal(row.Cells["PrecioU"].Value));
            txtmtotal.Text = total.ToString("0.00");
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                if (decimal.TryParse(txtpago.Text, out decimal pago) &&
                    decimal.TryParse(txtmtotal.Text, out decimal total))
                {
                    decimal cambio = pago - total;

                    if (pago < total)
                    {
                        MessageBox.Show("El pago es insuficiente.");
                    }
                    else
                    {
                        txtcambio.Text = cambio.ToString("0.00");
                    }
                }

                
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
                
                string codigoBarras = txttpproducto.Text;
                PRODUCTO producto = BuscarProductoPorCodigoBarras(codigoBarras);

                if (producto != null)
                {
                    
                    dgvprod.Rows.Add(producto.Prod_Id, producto.Prod_Nombre, 1, producto.Prod_Precio, 1 * producto.Prod_Precio);
                    CalcularTotal(); 
                    
                    txttpproducto.Clear();
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
            
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("Tienda UNA-FIT");
            ticket.AppendLine("Fecha: " + txtfecha1.Text);
            ticket.AppendLine("================================");
            ticket.AppendLine("Cantidad\tNombre\tPrecio U.\tTotal");

            foreach (DataGridViewRow row in dgvprod.Rows)
            {
                ticket.AppendLine($"{row.Cells["Cantidad"].Value}\t{row.Cells["Nombre"].Value}\t{row.Cells["PrecioU"].Value}\t{row.Cells["PrecioTotal"].Value}");
            }

            ticket.AppendLine("================================");
            ticket.AppendLine($"Total: {txtmtotal.Text}");
            ticket.AppendLine($"Pago: {txtpago.Text}");
            ticket.AppendLine($"Cambio: {txtcambio.Text}");
            MessageBox.Show(ticket.ToString(), "Ticket de Compra");
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
                CalcularTotal(); 
            }
        }

        private void dgvprod_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (dgvprod.Columns[e.ColumnIndex].Name == "Cantidad" || dgvprod.Columns[e.ColumnIndex].Name == "PrecioU"))
            {
                
                int cantidad = Convert.ToInt32(dgvprod.Rows[e.RowIndex].Cells["Cantidad"].Value);
                decimal precioU = Convert.ToDecimal(dgvprod.Rows[e.RowIndex].Cells["PrecioU"].Value);
                dgvprod.Rows[e.RowIndex].Cells["PrecioTotal"].Value = cantidad * precioU;
                CalcularTotal(); 
            }
        }

        private void icbagregarproducto_Click(object sender, EventArgs e)
        {
            
            txttpproducto.Clear();
        }

        private void icbquitarproducto_Click(object sender, EventArgs e)
        {
            
            if (dgvprod.Rows.Count > 0)
            {
                dgvprod.Rows.RemoveAt(dgvprod.Rows.Count - 1);
                CalcularTotal(); 
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
    }
}
