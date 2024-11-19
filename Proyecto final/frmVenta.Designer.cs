
namespace Proyecto_final
{
    partial class frmVenta
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
            this.dgvventa = new System.Windows.Forms.DataGridView();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.lbtituloventa = new System.Windows.Forms.Label();
            this.Folio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Produnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Prodxcant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_Creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtnsalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvventa
            // 
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Folio,
            this.prod_id,
            this.Prod_nombre,
            this.Precio_Produnitario,
            this.CantidadProd,
            this.Precio_Prodxcant,
            this.TotalVenta,
            this.fecha_Creacion});
            this.dgvventa.Location = new System.Drawing.Point(50, 115);
            this.dgvventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.RowHeadersWidth = 51;
            this.dgvventa.Size = new System.Drawing.Size(1126, 545);
            this.dgvventa.TabIndex = 98;
            // 
            // ibtnexportarexcel
            // 
            this.ibtnexportarexcel.FlatAppearance.BorderSize = 0;
            this.ibtnexportarexcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(204)))));
            this.ibtnexportarexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnexportarexcel.ForeColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnexportarexcel.IconColor = System.Drawing.Color.White;
            this.ibtnexportarexcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnexportarexcel.Location = new System.Drawing.Point(970, 9);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(157, 89);
            this.ibtnexportarexcel.TabIndex = 131;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = true;
            this.ibtnexportarexcel.Click += new System.EventHandler(this.ibtnexportarexcel_Click);
            // 
            // lbtituloventa
            // 
            this.lbtituloventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtituloventa.ForeColor = System.Drawing.Color.White;
            this.lbtituloventa.Location = new System.Drawing.Point(12, 9);
            this.lbtituloventa.Name = "lbtituloventa";
            this.lbtituloventa.Size = new System.Drawing.Size(651, 56);
            this.lbtituloventa.TabIndex = 132;
            this.lbtituloventa.Text = "LISTA DE VENTAS:";
            // 
            // Folio
            // 
            this.Folio.HeaderText = "Folio";
            this.Folio.MinimumWidth = 6;
            this.Folio.Name = "Folio";
            this.Folio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Folio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Folio.Width = 125;
            // 
            // prod_id
            // 
            this.prod_id.HeaderText = "Codigo de barras";
            this.prod_id.MinimumWidth = 6;
            this.prod_id.Name = "prod_id";
            this.prod_id.Width = 125;
            // 
            // Prod_nombre
            // 
            this.Prod_nombre.HeaderText = "Nombre del Producto";
            this.Prod_nombre.MinimumWidth = 6;
            this.Prod_nombre.Name = "Prod_nombre";
            this.Prod_nombre.Width = 125;
            // 
            // Precio_Produnitario
            // 
            this.Precio_Produnitario.HeaderText = "Precio Producto por unidad";
            this.Precio_Produnitario.MinimumWidth = 6;
            this.Precio_Produnitario.Name = "Precio_Produnitario";
            this.Precio_Produnitario.Width = 125;
            // 
            // CantidadProd
            // 
            this.CantidadProd.HeaderText = "Cantidad";
            this.CantidadProd.MinimumWidth = 6;
            this.CantidadProd.Name = "CantidadProd";
            this.CantidadProd.Width = 125;
            // 
            // Precio_Prodxcant
            // 
            this.Precio_Prodxcant.HeaderText = "Subtotal";
            this.Precio_Prodxcant.MinimumWidth = 6;
            this.Precio_Prodxcant.Name = "Precio_Prodxcant";
            this.Precio_Prodxcant.Width = 125;
            // 
            // TotalVenta
            // 
            this.TotalVenta.HeaderText = "Total de Venta";
            this.TotalVenta.MinimumWidth = 6;
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Width = 125;
            // 
            // fecha_Creacion
            // 
            this.fecha_Creacion.HeaderText = "FECHA DE VENTA";
            this.fecha_Creacion.MinimumWidth = 6;
            this.fecha_Creacion.Name = "fecha_Creacion";
            this.fecha_Creacion.Width = 200;
            // 
            // ibtnsalir
            // 
            this.ibtnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnsalir.FlatAppearance.BorderSize = 0;
            this.ibtnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnsalir.ForeColor = System.Drawing.Color.White;
            this.ibtnsalir.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.ibtnsalir.IconColor = System.Drawing.Color.White;
            this.ibtnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnsalir.IconSize = 50;
            this.ibtnsalir.Location = new System.Drawing.Point(-1, 45);
            this.ibtnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnsalir.Name = "ibtnsalir";
            this.ibtnsalir.Size = new System.Drawing.Size(130, 66);
            this.ibtnsalir.TabIndex = 133;
            this.ibtnsalir.Text = "Salir";
            this.ibtnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsalir.UseVisualStyleBackColor = true;
            this.ibtnsalir.Click += new System.EventHandler(this.ibtnsalir_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1213, 683);
            this.Controls.Add(this.ibtnsalir);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.lbtituloventa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvventa;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.Label lbtituloventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folio;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Produnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Prodxcant;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_Creacion;
        private FontAwesome.Sharp.IconButton ibtnsalir;
    }
}