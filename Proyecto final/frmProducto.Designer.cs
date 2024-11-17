
namespace Proyecto_final
{
    partial class frmProducto
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
            this.lbtitulolistaproductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCB = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lbNP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lbprecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbcaducidad = new System.Windows.Forms.Label();
            this.txtCaducidad = new System.Windows.Forms.TextBox();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.btnselecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CodigoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // lbtitulolistaproductos
            // 
            this.lbtitulolistaproductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbtitulolistaproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistaproductos.ForeColor = System.Drawing.Color.White;
            this.lbtitulolistaproductos.Location = new System.Drawing.Point(315, -3);
            this.lbtitulolistaproductos.Name = "lbtitulolistaproductos";
            this.lbtitulolistaproductos.Size = new System.Drawing.Size(767, 701);
            this.lbtitulolistaproductos.TabIndex = 116;
            this.lbtitulolistaproductos.Text = "LISTA DE PRODUCTOS:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 699);
            this.label1.TabIndex = 117;
            this.label1.Text = "Datos de registro";
            // 
            // lbCB
            // 
            this.lbCB.AutoSize = true;
            this.lbCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCB.ForeColor = System.Drawing.Color.White;
            this.lbCB.Location = new System.Drawing.Point(20, 89);
            this.lbCB.Name = "lbCB";
            this.lbCB.Size = new System.Drawing.Size(162, 20);
            this.lbCB.TabIndex = 118;
            this.lbCB.Text = "Codigo de Barras:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(24, 118);
            this.txtCodigoBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(212, 22);
            this.txtCodigoBarras.TabIndex = 119;
            // 
            // lbNP
            // 
            this.lbNP.AutoSize = true;
            this.lbNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNP.ForeColor = System.Drawing.Color.White;
            this.lbNP.Location = new System.Drawing.Point(20, 152);
            this.lbNP.Name = "lbNP";
            this.lbNP.Size = new System.Drawing.Size(216, 20);
            this.lbNP.TabIndex = 120;
            this.lbNP.Text = "Descricion del producto:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 187);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 22);
            this.txtNombre.TabIndex = 121;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.White;
            this.lbCantidad.Location = new System.Drawing.Point(20, 223);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(89, 20);
            this.lbCantidad.TabIndex = 122;
            this.lbCantidad.Text = "Cantidad:";
            this.lbCantidad.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(24, 254);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(212, 22);
            this.txtCantidad.TabIndex = 123;
            // 
            // lbprecio
            // 
            this.lbprecio.AutoSize = true;
            this.lbprecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecio.ForeColor = System.Drawing.Color.White;
            this.lbprecio.Location = new System.Drawing.Point(20, 278);
            this.lbprecio.Name = "lbprecio";
            this.lbprecio.Size = new System.Drawing.Size(69, 20);
            this.lbprecio.TabIndex = 124;
            this.lbprecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(24, 317);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(212, 22);
            this.txtPrecio.TabIndex = 125;
            // 
            // lbcaducidad
            // 
            this.lbcaducidad.AutoSize = true;
            this.lbcaducidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbcaducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcaducidad.ForeColor = System.Drawing.Color.White;
            this.lbcaducidad.Location = new System.Drawing.Point(20, 355);
            this.lbcaducidad.Name = "lbcaducidad";
            this.lbcaducidad.Size = new System.Drawing.Size(180, 20);
            this.lbcaducidad.TabIndex = 126;
            this.lbcaducidad.Text = "Fecha de Caducidad";
            // 
            // txtCaducidad
            // 
            this.txtCaducidad.ForeColor = System.Drawing.Color.DimGray;
            this.txtCaducidad.Location = new System.Drawing.Point(24, 390);
            this.txtCaducidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaducidad.Name = "txtCaducidad";
            this.txtCaducidad.Size = new System.Drawing.Size(212, 22);
            this.txtCaducidad.TabIndex = 127;
            this.txtCaducidad.Text = "ej. 2024-12-01";
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
            this.dgvprod.Location = new System.Drawing.Point(250, 73);
            this.dgvprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.RowHeadersWidth = 51;
            this.dgvprod.Size = new System.Drawing.Size(661, 572);
            this.dgvprod.TabIndex = 97;
            this.dgvprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprod_CellContentClick);
            this.dgvprod.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvprod_CellPainting);
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
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ibtnexportarexcel.FlatAppearance.BorderSize = 0;
            this.ibtnexportarexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnexportarexcel.ForeColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(164, 459);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(80, 82);
            this.ibtnexportarexcel.TabIndex = 130;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = false;
            this.ibtnexportarexcel.Click += new System.EventHandler(this.ibtnexportarexcel_Click);
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ibtneliminar.FlatAppearance.BorderSize = 0;
            this.ibtneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtneliminar.ForeColor = System.Drawing.Color.White;
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.White;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.Location = new System.Drawing.Point(84, 467);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(74, 67);
            this.ibtneliminar.TabIndex = 129;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = false;
            this.ibtneliminar.Click += new System.EventHandler(this.ibtneliminar_Click);
            // 
            // ibtnsave
            // 
            this.ibtnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ibtnsave.FlatAppearance.BorderSize = 0;
            this.ibtnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnsave.ForeColor = System.Drawing.Color.White;
            this.ibtnsave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnsave.IconColor = System.Drawing.Color.White;
            this.ibtnsave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsave.Location = new System.Drawing.Point(4, 467);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(74, 67);
            this.ibtnsave.TabIndex = 128;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = false;
            this.ibtnsave.Click += new System.EventHandler(this.ibtnsave_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(909, 695);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtneliminar);
            this.Controls.Add(this.ibtnsave);
            this.Controls.Add(this.txtCaducidad);
            this.Controls.Add(this.lbcaducidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lbprecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNP);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.lbCB);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtitulolistaproductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtitulolistaproductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCB;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lbNP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lbprecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lbcaducidad;
        private System.Windows.Forms.TextBox txtCaducidad;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.DataGridViewButtonColumn btnselecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecharegistro;
    }
}