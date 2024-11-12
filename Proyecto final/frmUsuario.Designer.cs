
namespace Proyecto_final
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.conte_listau = new System.Windows.Forms.Panel();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            this.cboestado = new System.Windows.Forms.ComboBox();
            this.lbestado = new System.Windows.Forms.Label();
            this.cborol = new System.Windows.Forms.ComboBox();
            this.lbrol = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lbcorreo = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.lbclave = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lbphone = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.dgvbtnseleciona = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbtitulolistausuario = new System.Windows.Forms.Label();
            this.conte_listau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // conte_listau
            // 
            this.conte_listau.Controls.Add(this.ibtneliminar);
            this.conte_listau.Controls.Add(this.ibtnsave);
            this.conte_listau.Controls.Add(this.cboestado);
            this.conte_listau.Controls.Add(this.lbestado);
            this.conte_listau.Controls.Add(this.cborol);
            this.conte_listau.Controls.Add(this.lbrol);
            this.conte_listau.Controls.Add(this.txtcorreo);
            this.conte_listau.Controls.Add(this.lbcorreo);
            this.conte_listau.Controls.Add(this.txtclave);
            this.conte_listau.Controls.Add(this.lbclave);
            this.conte_listau.Controls.Add(this.txtphone);
            this.conte_listau.Controls.Add(this.lbphone);
            this.conte_listau.Controls.Add(this.txtNombre);
            this.conte_listau.Controls.Add(this.lbNU);
            this.conte_listau.Controls.Add(this.label1);
            this.conte_listau.Controls.Add(this.dgvusuario);
            this.conte_listau.Controls.Add(this.lbtitulolistausuario);
            this.conte_listau.Location = new System.Drawing.Point(1, 1);
            this.conte_listau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conte_listau.Name = "conte_listau";
            this.conte_listau.Size = new System.Drawing.Size(1311, 755);
            this.conte_listau.TabIndex = 36;
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
            this.ibtneliminar.Location = new System.Drawing.Point(42, 582);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(157, 89);
            this.ibtneliminar.TabIndex = 49;
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
            this.ibtnsave.Location = new System.Drawing.Point(42, 450);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(157, 89);
            this.ibtnsave.TabIndex = 48;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = false;
            this.ibtnsave.Click += new System.EventHandler(this.ibtnsave_Click);
            // 
            // cboestado
            // 
            this.cboestado.FormattingEnabled = true;
            this.cboestado.Location = new System.Drawing.Point(0, 402);
            this.cboestado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboestado.Name = "cboestado";
            this.cboestado.Size = new System.Drawing.Size(238, 24);
            this.cboestado.TabIndex = 47;
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado.ForeColor = System.Drawing.Color.White;
            this.lbestado.Location = new System.Drawing.Point(3, 368);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(73, 20);
            this.lbestado.TabIndex = 46;
            this.lbestado.Text = "Estado:";
            // 
            // cborol
            // 
            this.cborol.FormattingEnabled = true;
            this.cborol.Location = new System.Drawing.Point(3, 340);
            this.cborol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cborol.Name = "cborol";
            this.cborol.Size = new System.Drawing.Size(238, 24);
            this.cborol.TabIndex = 45;
            // 
            // lbrol
            // 
            this.lbrol.AutoSize = true;
            this.lbrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrol.ForeColor = System.Drawing.Color.White;
            this.lbrol.Location = new System.Drawing.Point(1, 316);
            this.lbrol.Name = "lbrol";
            this.lbrol.Size = new System.Drawing.Size(49, 20);
            this.lbrol.TabIndex = 44;
            this.lbrol.Text = "Rol :";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(0, 278);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(238, 22);
            this.txtcorreo.TabIndex = 43;
            // 
            // lbcorreo
            // 
            this.lbcorreo.AutoSize = true;
            this.lbcorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcorreo.ForeColor = System.Drawing.Color.White;
            this.lbcorreo.Location = new System.Drawing.Point(-4, 255);
            this.lbcorreo.Name = "lbcorreo";
            this.lbcorreo.Size = new System.Drawing.Size(72, 20);
            this.lbcorreo.TabIndex = 42;
            this.lbcorreo.Text = "Correo:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(0, 217);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(238, 22);
            this.txtclave.TabIndex = 41;
            // 
            // lbclave
            // 
            this.lbclave.AutoSize = true;
            this.lbclave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclave.ForeColor = System.Drawing.Color.White;
            this.lbclave.Location = new System.Drawing.Point(-4, 193);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(111, 20);
            this.lbclave.TabIndex = 40;
            this.lbclave.Text = "Contraseña:";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(0, 166);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(238, 22);
            this.txtphone.TabIndex = 39;
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbphone.ForeColor = System.Drawing.Color.White;
            this.lbphone.Location = new System.Drawing.Point(3, 143);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(87, 20);
            this.lbphone.TabIndex = 38;
            this.lbphone.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(3, 103);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 22);
            this.txtNombre.TabIndex = 37;
            // 
            // lbNU
            // 
            this.lbNU.AutoSize = true;
            this.lbNU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNU.ForeColor = System.Drawing.Color.White;
            this.lbNU.Location = new System.Drawing.Point(3, 79);
            this.lbNU.Name = "lbNU";
            this.lbNU.Size = new System.Drawing.Size(151, 20);
            this.lbNU.TabIndex = 8;
            this.lbNU.Text = "Nombre Usuario:";
            this.lbNU.Click += new System.EventHandler(this.lbNU_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-10, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 734);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datos de registro";
            // 
            // dgvusuario
            // 
            this.dgvusuario.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvbtnseleciona,
            this.Id_Usuario,
            this.NombreU,
            this.Telefono,
            this.Correo,
            this.Clave,
            this.id_rol,
            this.descripcion,
            this.Estado_Valor,
            this.estado});
            this.dgvusuario.EnableHeadersVisualStyles = false;
            this.dgvusuario.Location = new System.Drawing.Point(379, 79);
            this.dgvusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvusuario.MultiSelect = false;
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.ReadOnly = true;
            this.dgvusuario.RowHeadersVisible = false;
            this.dgvusuario.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvusuario.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvusuario.Size = new System.Drawing.Size(786, 580);
            this.dgvusuario.TabIndex = 19;
            this.dgvusuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuario_CellContentClick);
            this.dgvusuario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvusuario_CellPainting);
            // 
            // dgvbtnseleciona
            // 
            this.dgvbtnseleciona.HeaderText = "";
            this.dgvbtnseleciona.MinimumWidth = 6;
            this.dgvbtnseleciona.Name = "dgvbtnseleciona";
            this.dgvbtnseleciona.ReadOnly = true;
            this.dgvbtnseleciona.Width = 30;
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.HeaderText = "Id Usuario";
            this.Id_Usuario.MinimumWidth = 6;
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            this.Id_Usuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Usuario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Usuario.Visible = false;
            this.Id_Usuario.Width = 125;
            // 
            // NombreU
            // 
            this.NombreU.HeaderText = "Nombre Usuario";
            this.NombreU.MinimumWidth = 6;
            this.NombreU.Name = "NombreU";
            this.NombreU.ReadOnly = true;
            this.NombreU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreU.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefono.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Correo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Correo.Width = 125;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Clave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Clave.Width = 125;
            // 
            // id_rol
            // 
            this.id_rol.HeaderText = "ID ROL";
            this.id_rol.MinimumWidth = 6;
            this.id_rol.Name = "id_rol";
            this.id_rol.ReadOnly = true;
            this.id_rol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_rol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id_rol.Visible = false;
            this.id_rol.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Rol";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descripcion.Width = 125;
            // 
            // Estado_Valor
            // 
            this.Estado_Valor.HeaderText = "Estado Valor";
            this.Estado_Valor.MinimumWidth = 6;
            this.Estado_Valor.Name = "Estado_Valor";
            this.Estado_Valor.ReadOnly = true;
            this.Estado_Valor.Visible = false;
            this.Estado_Valor.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // lbtitulolistausuario
            // 
            this.lbtitulolistausuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbtitulolistausuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistausuario.ForeColor = System.Drawing.Color.White;
            this.lbtitulolistausuario.Location = new System.Drawing.Point(276, -1);
            this.lbtitulolistausuario.Name = "lbtitulolistausuario";
            this.lbtitulolistausuario.Size = new System.Drawing.Size(1009, 742);
            this.lbtitulolistausuario.TabIndex = 1;
            this.lbtitulolistausuario.Text = "LISTA DE USUARIOS:";
            this.lbtitulolistausuario.Click += new System.EventHandler(this.lbtitulolistausuario_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 683);
            this.Controls.Add(this.conte_listau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.conte_listau.ResumeLayout(false);
            this.conte_listau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel conte_listau;
        private System.Windows.Forms.Label lbtitulolistausuario;
        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNU;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private System.Windows.Forms.ComboBox cboestado;
        private System.Windows.Forms.Label lbestado;
        private System.Windows.Forms.ComboBox cborol;
        private System.Windows.Forms.Label lbrol;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lbcorreo;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label lbclave;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lbphone;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnseleciona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}