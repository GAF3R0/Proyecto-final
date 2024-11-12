
namespace Proyecto_final
{
    partial class frmregistar_Visitantes
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
            this.dgvvisita = new System.Windows.Forms.DataGridView();
            this.dgvbtnseleciona = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Emer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.lbtitulovisitantes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisita)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvisita
            // 
            this.dgvvisita.AllowUserToAddRows = false;
            this.dgvvisita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnseleciona,
            this.Estatus,
            this.Id_Cliente,
            this.Nombrev,
            this.Telefono,
            this.Telefono_Emer,
            this.Correo,
            this.Domicilio,
            this.Ciudad,
            this.FechaCreacion});
            this.dgvvisita.Location = new System.Drawing.Point(57, 125);
            this.dgvvisita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvvisita.Name = "dgvvisita";
            this.dgvvisita.RowHeadersWidth = 51;
            this.dgvvisita.Size = new System.Drawing.Size(1085, 532);
            this.dgvvisita.TabIndex = 99;
            // 
            // dgvbtnseleciona
            // 
            this.dgvbtnseleciona.HeaderText = "";
            this.dgvbtnseleciona.MinimumWidth = 6;
            this.dgvbtnseleciona.Name = "dgvbtnseleciona";
            this.dgvbtnseleciona.Width = 30;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.MinimumWidth = 6;
            this.Estatus.Name = "Estatus";
            this.Estatus.Visible = false;
            this.Estatus.Width = 125;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "Identificador de cliente";
            this.Id_Cliente.MinimumWidth = 6;
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Width = 125;
            // 
            // Nombrev
            // 
            this.Nombrev.HeaderText = "Nombre Visitante";
            this.Nombrev.MinimumWidth = 6;
            this.Nombrev.Name = "Nombrev";
            this.Nombrev.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // Telefono_Emer
            // 
            this.Telefono_Emer.HeaderText = "Telefono Emergencia";
            this.Telefono_Emer.MinimumWidth = 6;
            this.Telefono_Emer.Name = "Telefono_Emer";
            this.Telefono_Emer.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 125;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha De Visita ";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Width = 125;
            // 
            // ibtneliminar
            // 
            this.ibtneliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtneliminar.FlatAppearance.BorderSize = 0;
            this.ibtneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.ibtneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtneliminar.ForeColor = System.Drawing.Color.White;
            this.ibtneliminar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ibtneliminar.IconColor = System.Drawing.Color.White;
            this.ibtneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtneliminar.Location = new System.Drawing.Point(716, 32);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(139, 89);
            this.ibtneliminar.TabIndex = 131;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = true;
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
            this.ibtnexportarexcel.Location = new System.Drawing.Point(345, 32);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(157, 89);
            this.ibtnexportarexcel.TabIndex = 132;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = false;
            this.ibtnexportarexcel.Click += new System.EventHandler(this.ibtnexportarexcel_Click);
            // 
            // lbtitulovisitantes
            // 
            this.lbtitulovisitantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbtitulovisitantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulovisitantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulovisitantes.Location = new System.Drawing.Point(15, 17);
            this.lbtitulovisitantes.Name = "lbtitulovisitantes";
            this.lbtitulovisitantes.Size = new System.Drawing.Size(829, 92);
            this.lbtitulovisitantes.TabIndex = 133;
            this.lbtitulovisitantes.Text = "LISTA DE VISITANTES:";
            // 
            // frmregistar_Visitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1213, 683);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtneliminar);
            this.Controls.Add(this.dgvvisita);
            this.Controls.Add(this.lbtitulovisitantes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmregistar_Visitantes";
            this.Text = "frmVisitantes";
            this.Load += new System.EventHandler(this.frmregistar_Visitantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvisita;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.Label lbtitulovisitantes;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnseleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Emer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
    }
}