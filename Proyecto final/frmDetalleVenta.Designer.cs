
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
            this.btnselecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtmtotal = new System.Windows.Forms.TextBox();
            this.icbticket = new FontAwesome.Sharp.IconButton();
            this.lbcambio = new System.Windows.Forms.Label();
            this.lbmontopago = new System.Windows.Forms.Label();
            this.lbmontot = new System.Windows.Forms.Label();
            this.txtusuario2 = new System.Windows.Forms.TextBox();
            this.txttpproducto = new System.Windows.Forms.TextBox();
            this.txtfecha1 = new System.Windows.Forms.TextBox();
            this.lb2usuario = new System.Windows.Forms.Label();
            this.lbtpproducto = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbinfventa = new System.Windows.Forms.Label();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.txtnmproducto = new System.Windows.Forms.TextBox();
            this.lbnmproducto = new System.Windows.Forms.Label();
            this.lbtitulodv = new System.Windows.Forms.Label();
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
            this.Precio,
            this.FechaC,
            this.Fecharegistro});
            this.dgvprod.Location = new System.Drawing.Point(54, 143);
            this.dgvprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.RowHeadersWidth = 51;
            this.dgvprod.Size = new System.Drawing.Size(984, 358);
            this.dgvprod.TabIndex = 174;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Precio.Width = 125;
            // 
            // FechaC
            // 
            this.FechaC.HeaderText = "Fecha Caducidad";
            this.FechaC.MinimumWidth = 6;
            this.FechaC.Name = "FechaC";
            this.FechaC.Width = 120;
            // 
            // Fecharegistro
            // 
            this.Fecharegistro.HeaderText = "FECHA DE REGISTRO";
            this.Fecharegistro.MinimumWidth = 6;
            this.Fecharegistro.Name = "Fecharegistro";
            this.Fecharegistro.Visible = false;
            this.Fecharegistro.Width = 125;
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(434, 525);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(79, 22);
            this.txtpago.TabIndex = 173;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(723, 527);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(81, 22);
            this.txtcambio.TabIndex = 172;
            // 
            // txtmtotal
            // 
            this.txtmtotal.Location = new System.Drawing.Point(155, 523);
            this.txtmtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtmtotal.Name = "txtmtotal";
            this.txtmtotal.Size = new System.Drawing.Size(85, 22);
            this.txtmtotal.TabIndex = 171;
            // 
            // icbticket
            // 
            this.icbticket.FlatAppearance.BorderSize = 0;
            this.icbticket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.icbticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbticket.ForeColor = System.Drawing.Color.White;
            this.icbticket.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.icbticket.IconColor = System.Drawing.Color.White;
            this.icbticket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icbticket.Location = new System.Drawing.Point(858, 507);
            this.icbticket.Margin = new System.Windows.Forms.Padding(4);
            this.icbticket.Name = "icbticket";
            this.icbticket.Size = new System.Drawing.Size(180, 62);
            this.icbticket.TabIndex = 170;
            this.icbticket.Text = "Generar Ticket";
            this.icbticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbticket.UseVisualStyleBackColor = true;
            // 
            // lbcambio
            // 
            this.lbcambio.AutoSize = true;
            this.lbcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcambio.ForeColor = System.Drawing.Color.White;
            this.lbcambio.Location = new System.Drawing.Point(531, 527);
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
            this.lbmontopago.Location = new System.Drawing.Point(270, 525);
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
            this.lbmontot.Location = new System.Drawing.Point(23, 525);
            this.lbmontot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmontot.Name = "lbmontot";
            this.lbmontot.Size = new System.Drawing.Size(116, 25);
            this.lbmontot.TabIndex = 167;
            this.lbmontot.Text = "Monto Total";
            // 
            // txtusuario2
            // 
            this.txtusuario2.Location = new System.Drawing.Point(611, 100);
            this.txtusuario2.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario2.Name = "txtusuario2";
            this.txtusuario2.Size = new System.Drawing.Size(193, 22);
            this.txtusuario2.TabIndex = 166;
            // 
            // txttpproducto
            // 
            this.txttpproducto.Location = new System.Drawing.Point(299, 100);
            this.txttpproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txttpproducto.Name = "txttpproducto";
            this.txttpproducto.Size = new System.Drawing.Size(193, 22);
            this.txttpproducto.TabIndex = 165;
            // 
            // txtfecha1
            // 
            this.txtfecha1.Location = new System.Drawing.Point(18, 100);
            this.txtfecha1.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(193, 22);
            this.txtfecha1.TabIndex = 164;
            // 
            // lb2usuario
            // 
            this.lb2usuario.AutoSize = true;
            this.lb2usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2usuario.ForeColor = System.Drawing.Color.White;
            this.lb2usuario.Location = new System.Drawing.Point(607, 68);
            this.lb2usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2usuario.Name = "lb2usuario";
            this.lb2usuario.Size = new System.Drawing.Size(67, 20);
            this.lb2usuario.TabIndex = 163;
            this.lb2usuario.Text = "Usuario";
            // 
            // lbtpproducto
            // 
            this.lbtpproducto.AutoSize = true;
            this.lbtpproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtpproducto.ForeColor = System.Drawing.Color.White;
            this.lbtpproducto.Location = new System.Drawing.Point(295, 68);
            this.lbtpproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtpproducto.Name = "lbtpproducto";
            this.lbtpproducto.Size = new System.Drawing.Size(136, 20);
            this.lbtpproducto.TabIndex = 162;
            this.lbtpproducto.Text = "Tipo de Producto";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.White;
            this.lbfecha.Location = new System.Drawing.Point(24, 68);
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
            this.lbinfventa.Location = new System.Drawing.Point(12, 26);
            this.lbinfventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbinfventa.Name = "lbinfventa";
            this.lbinfventa.Size = new System.Drawing.Size(197, 25);
            this.lbinfventa.TabIndex = 160;
            this.lbinfventa.Text = "Informacion de Venta";
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnlimpiar.Location = new System.Drawing.Point(934, 21);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(121, 43);
            this.ibtnlimpiar.TabIndex = 159;
            this.ibtnlimpiar.Text = "Limpiar";
            this.ibtnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnbusca.Location = new System.Drawing.Point(807, 21);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(121, 43);
            this.ibtnbusca.TabIndex = 158;
            this.ibtnbusca.Text = " Buscar";
            this.ibtnbusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // txtnmproducto
            // 
            this.txtnmproducto.Location = new System.Drawing.Point(554, 32);
            this.txtnmproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtnmproducto.Name = "txtnmproducto";
            this.txtnmproducto.Size = new System.Drawing.Size(245, 22);
            this.txtnmproducto.TabIndex = 157;
            // 
            // lbnmproducto
            // 
            this.lbnmproducto.AutoSize = true;
            this.lbnmproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnmproducto.ForeColor = System.Drawing.Color.White;
            this.lbnmproducto.Location = new System.Drawing.Point(339, 32);
            this.lbnmproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnmproducto.Name = "lbnmproducto";
            this.lbnmproducto.Size = new System.Drawing.Size(197, 25);
            this.lbnmproducto.TabIndex = 156;
            this.lbnmproducto.Text = "Numero de Producto:";
            // 
            // lbtitulodv
            // 
            this.lbtitulodv.AutoSize = true;
            this.lbtitulodv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulodv.ForeColor = System.Drawing.Color.White;
            this.lbtitulodv.Location = new System.Drawing.Point(14, -14);
            this.lbtitulodv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitulodv.Name = "lbtitulodv";
            this.lbtitulodv.Size = new System.Drawing.Size(214, 31);
            this.lbtitulodv.TabIndex = 155;
            this.lbtitulodv.Text = "Detalle de Venta";
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtmtotal);
            this.Controls.Add(this.icbticket);
            this.Controls.Add(this.lbcambio);
            this.Controls.Add(this.lbmontopago);
            this.Controls.Add(this.lbmontot);
            this.Controls.Add(this.txtusuario2);
            this.Controls.Add(this.txttpproducto);
            this.Controls.Add(this.txtfecha1);
            this.Controls.Add(this.lb2usuario);
            this.Controls.Add(this.lbtpproducto);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbinfventa);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.txtnmproducto);
            this.Controls.Add(this.lbnmproducto);
            this.Controls.Add(this.lbtitulodv);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDetalleVenta";
            this.Text = "frmDetalleVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.DataGridViewButtonColumn btnselecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecharegistro;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtmtotal;
        private FontAwesome.Sharp.IconButton icbticket;
        private System.Windows.Forms.Label lbcambio;
        private System.Windows.Forms.Label lbmontopago;
        private System.Windows.Forms.Label lbmontot;
        private System.Windows.Forms.TextBox txtusuario2;
        private System.Windows.Forms.TextBox txttpproducto;
        private System.Windows.Forms.TextBox txtfecha1;
        private System.Windows.Forms.Label lb2usuario;
        private System.Windows.Forms.Label lbtpproducto;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbinfventa;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private System.Windows.Forms.TextBox txtnmproducto;
        private System.Windows.Forms.Label lbnmproducto;
        private System.Windows.Forms.Label lbtitulodv;
    }
}