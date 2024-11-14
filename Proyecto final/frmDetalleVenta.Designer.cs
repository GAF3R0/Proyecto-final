
namespace Proyecto_final
{
    partial class frmDetalleVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtmtotal = new System.Windows.Forms.TextBox();
            this.lbcambio = new System.Windows.Forms.Label();
            this.lbmontopago = new System.Windows.Forms.Label();
            this.lbmontot = new System.Windows.Forms.Label();
            this.txtcbproducto = new System.Windows.Forms.TextBox();
            this.txtfecha1 = new System.Windows.Forms.TextBox();
            this.lbtpproducto = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbinfventa = new System.Windows.Forms.Label();
            this.icbquitarproducto = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ibtncobra = new FontAwesome.Sharp.IconButton();
            this.btnselecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprod
            // 
            this.dgvprod.AllowUserToAddRows = false;
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnselecionar,
            this.CodigoB,
            this.Nombre,
            this.Cantidad,
            this.PrecioU,
            this.PrecioTotal});
            this.dgvprod.Location = new System.Drawing.Point(89, 161);
            this.dgvprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.RowHeadersWidth = 51;
            this.dgvprod.Size = new System.Drawing.Size(704, 341);
            this.dgvprod.TabIndex = 174;
            this.dgvprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprod_CellContentClick);
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(411, 532);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(79, 22);
            this.txtpago.TabIndex = 173;
            // 
            // txtcambio
            // 
            this.txtcambio.Enabled = false;
            this.txtcambio.Location = new System.Drawing.Point(673, 533);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(81, 22);
            this.txtcambio.TabIndex = 172;
            this.txtcambio.TextChanged += new System.EventHandler(this.txtcambio_TextChanged);
            // 
            // txtmtotal
            // 
            this.txtmtotal.Enabled = false;
            this.txtmtotal.Location = new System.Drawing.Point(152, 533);
            this.txtmtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtmtotal.Name = "txtmtotal";
            this.txtmtotal.Size = new System.Drawing.Size(85, 22);
            this.txtmtotal.TabIndex = 171;
            // 
            // lbcambio
            // 
            this.lbcambio.AutoSize = true;
            this.lbcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcambio.ForeColor = System.Drawing.Color.White;
            this.lbcambio.Location = new System.Drawing.Point(498, 530);
            this.lbcambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcambio.Name = "lbcambio";
            this.lbcambio.Size = new System.Drawing.Size(167, 25);
            this.lbcambio.TabIndex = 169;
            this.lbcambio.Text = "Monto de Cambio";
            // 
            // lbmontopago
            // 
            this.lbmontopago.AutoSize = true;
            this.lbmontopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontopago.ForeColor = System.Drawing.Color.White;
            this.lbmontopago.Location = new System.Drawing.Point(258, 529);
            this.lbmontopago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmontopago.Name = "lbmontopago";
            this.lbmontopago.Size = new System.Drawing.Size(145, 25);
            this.lbmontopago.TabIndex = 168;
            this.lbmontopago.Text = "Monto de Pago";
            // 
            // lbmontot
            // 
            this.lbmontot.AutoSize = true;
            this.lbmontot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontot.ForeColor = System.Drawing.Color.White;
            this.lbmontot.Location = new System.Drawing.Point(28, 529);
            this.lbmontot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmontot.Name = "lbmontot";
            this.lbmontot.Size = new System.Drawing.Size(116, 25);
            this.lbmontot.TabIndex = 167;
            this.lbmontot.Text = "Monto Total";
            this.lbmontot.Click += new System.EventHandler(this.lbmontot_Click);
            // 
            // txtcbproducto
            // 
            this.txtcbproducto.Location = new System.Drawing.Point(330, 116);
            this.txtcbproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcbproducto.Name = "txtcbproducto";
            this.txtcbproducto.Size = new System.Drawing.Size(151, 22);
            this.txtcbproducto.TabIndex = 165;
            this.txtcbproducto.TextChanged += new System.EventHandler(this.txttpproducto_TextChanged_1);
            this.txtcbproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttpproducto_KeyPress);
            // 
            // txtfecha1
            // 
            this.txtfecha1.Location = new System.Drawing.Point(621, 41);
            this.txtfecha1.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(150, 22);
            this.txtfecha1.TabIndex = 164;
            this.txtfecha1.TextChanged += new System.EventHandler(this.txtfecha1_TextChanged);
            // 
            // lbtpproducto
            // 
            this.lbtpproducto.AutoSize = true;
            this.lbtpproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtpproducto.ForeColor = System.Drawing.Color.White;
            this.lbtpproducto.Location = new System.Drawing.Point(334, 81);
            this.lbtpproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtpproducto.Name = "lbtpproducto";
            this.lbtpproducto.Size = new System.Drawing.Size(140, 20);
            this.lbtpproducto.TabIndex = 162;
            this.lbtpproducto.Text = "Agregar Producto";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.White;
            this.lbfecha.Location = new System.Drawing.Point(656, 10);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(60, 20);
            this.lbfecha.TabIndex = 161;
            this.lbfecha.Text = "Fecha:";
            // 
            // lbinfventa
            // 
            this.lbinfventa.AutoSize = true;
            this.lbinfventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfventa.ForeColor = System.Drawing.Color.White;
            this.lbinfventa.Location = new System.Drawing.Point(4, 6);
            this.lbinfventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbinfventa.Name = "lbinfventa";
            this.lbinfventa.Size = new System.Drawing.Size(197, 25);
            this.lbinfventa.TabIndex = 160;
            this.lbinfventa.Text = "Informacion de Venta";
            // 
            // icbquitarproducto
            // 
            this.icbquitarproducto.IconChar = FontAwesome.Sharp.IconChar.X;
            this.icbquitarproducto.IconColor = System.Drawing.Color.DarkRed;
            this.icbquitarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbquitarproducto.IconSize = 30;
            this.icbquitarproducto.Location = new System.Drawing.Point(810, 170);
            this.icbquitarproducto.Name = "icbquitarproducto";
            this.icbquitarproducto.Size = new System.Drawing.Size(41, 44);
            this.icbquitarproducto.TabIndex = 176;
            this.icbquitarproducto.UseVisualStyleBackColor = true;
            this.icbquitarproducto.Click += new System.EventHandler(this.icbquitarproducto_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(489, 116);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 22);
            this.txtNombre.TabIndex = 178;
            this.txtNombre.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(525, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 177;
            this.label1.Text = "Producto";
            this.label1.Visible = false;
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(222, 116);
            this.txtfolio.Margin = new System.Windows.Forms.Padding(4);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(72, 22);
            this.txtfolio.TabIndex = 182;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(219, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 181;
            this.label3.Text = "Folio";
            // 
            // ibtncobra
            // 
            this.ibtncobra.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.ibtncobra.IconColor = System.Drawing.Color.Black;
            this.ibtncobra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtncobra.IconSize = 40;
            this.ibtncobra.Location = new System.Drawing.Point(772, 529);
            this.ibtncobra.Name = "ibtncobra";
            this.ibtncobra.Size = new System.Drawing.Size(60, 38);
            this.ibtncobra.TabIndex = 183;
            this.ibtncobra.UseVisualStyleBackColor = true;
            this.ibtncobra.Click += new System.EventHandler(this.ibtncobra_Click);
            // 
            // btnselecionar
            // 
            this.btnselecionar.HeaderText = "";
            this.btnselecionar.MinimumWidth = 6;
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Width = 30;
            // 
            // CodigoB
            // 
            this.CodigoB.HeaderText = "Codigo de barras";
            this.CodigoB.MinimumWidth = 6;
            this.CodigoB.Name = "CodigoB";
            this.CodigoB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CodigoB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CodigoB.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Cantidad.Width = 125;
            // 
            // PrecioU
            // 
            this.PrecioU.HeaderText = "Precio Unitario";
            this.PrecioU.MinimumWidth = 6;
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrecioU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PrecioU.Width = 125;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio total";
            this.PrecioTotal.MinimumWidth = 6;
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.Width = 120;
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(891, 648);
            this.Controls.Add(this.ibtncobra);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icbquitarproducto);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtmtotal);
            this.Controls.Add(this.lbcambio);
            this.Controls.Add(this.lbmontopago);
            this.Controls.Add(this.lbmontot);
            this.Controls.Add(this.txtcbproducto);
            this.Controls.Add(this.txtfecha1);
            this.Controls.Add(this.lbtpproducto);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbinfventa);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetalleVenta";
            this.Text = "frmDetalleVenta";
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtmtotal;
        private System.Windows.Forms.Label lbcambio;
        private System.Windows.Forms.Label lbmontopago;
        private System.Windows.Forms.Label lbmontot;
        private System.Windows.Forms.TextBox txtcbproducto;
        private System.Windows.Forms.TextBox txtfecha1;
        private System.Windows.Forms.Label lbtpproducto;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbinfventa;
        private FontAwesome.Sharp.IconButton icbquitarproducto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton ibtncobra;
        private System.Windows.Forms.DataGridViewButtonColumn btnselecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
    }
}