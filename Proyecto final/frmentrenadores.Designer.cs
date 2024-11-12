namespace Proyecto_final
{
    partial class frmentrenadores
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
            this.dgvusuario = new System.Windows.Forms.DataGridView();
            this.Id_Entrenadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNE = new System.Windows.Forms.Label();
            this.txtNombreEntrenadores = new System.Windows.Forms.TextBox();
            this.lbedad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.txtTelefonoEmergencia = new System.Windows.Forms.TextBox();
            this.lbcalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lbciudad = new System.Windows.Forms.Label();
            this.textCiudad = new System.Windows.Forms.TextBox();
            this.lbestado = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.ibtnsave = new FontAwesome.Sharp.IconButton();
            this.ibtneliminar = new FontAwesome.Sharp.IconButton();
            this.ibtnexportarexcel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtitulolistaentrenadores = new System.Windows.Forms.Label();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ibtnbusca = new FontAwesome.Sharp.IconButton();
            this.ibtnlimpiar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvusuario
            // 
            this.dgvusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Entrenadores,
            this.NombreE,
            this.Edad,
            this.Telefono,
            this.Direccion,
            this.Ciudad,
            this.Estado});
            this.dgvusuario.Location = new System.Drawing.Point(175, 67);
            this.dgvusuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvusuario.Name = "dgvusuario";
            this.dgvusuario.RowHeadersWidth = 51;
            this.dgvusuario.Size = new System.Drawing.Size(618, 432);
            this.dgvusuario.TabIndex = 96;
            // 
            // Id_Entrenadores
            // 
            this.Id_Entrenadores.HeaderText = "Id Entrenadores";
            this.Id_Entrenadores.MinimumWidth = 6;
            this.Id_Entrenadores.Name = "Id_Entrenadores";
            this.Id_Entrenadores.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id_Entrenadores.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id_Entrenadores.Visible = false;
            this.Id_Entrenadores.Width = 125;
            // 
            // NombreE
            // 
            this.NombreE.HeaderText = "Nombre Entrenador";
            this.NombreE.MinimumWidth = 6;
            this.NombreE.Name = "NombreE";
            this.NombreE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NombreE.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Telefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Telefono.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Direccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Direccion.Width = 125;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.MinimumWidth = 6;
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // lbNE
            // 
            this.lbNE.AutoSize = true;
            this.lbNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNE.ForeColor = System.Drawing.Color.White;
            this.lbNE.Location = new System.Drawing.Point(-1, 79);
            this.lbNE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNE.Name = "lbNE";
            this.lbNE.Size = new System.Drawing.Size(172, 17);
            this.lbNE.TabIndex = 97;
            this.lbNE.Text = "Nombre Entrenadores:";
            // 
            // txtNombreEntrenadores
            // 
            this.txtNombreEntrenadores.Location = new System.Drawing.Point(0, 98);
            this.txtNombreEntrenadores.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEntrenadores.Name = "txtNombreEntrenadores";
            this.txtNombreEntrenadores.Size = new System.Drawing.Size(155, 20);
            this.txtNombreEntrenadores.TabIndex = 98;
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.ForeColor = System.Drawing.Color.White;
            this.lbedad.Location = new System.Drawing.Point(-1, 120);
            this.lbedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(50, 17);
            this.lbedad.TabIndex = 99;
            this.lbedad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(0, 139);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(155, 20);
            this.txtEdad.TabIndex = 100;
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono.ForeColor = System.Drawing.Color.White;
            this.lbtelefono.Location = new System.Drawing.Point(-3, 161);
            this.lbtelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(77, 17);
            this.lbtelefono.TabIndex = 101;
            this.lbtelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(0, 180);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(155, 20);
            this.txtTelefono.TabIndex = 102;
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.ForeColor = System.Drawing.Color.White;
            this.lbdireccion.Location = new System.Drawing.Point(-1, 202);
            this.lbdireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(81, 17);
            this.lbdireccion.TabIndex = 103;
            this.lbdireccion.Text = "Direccion:";
            // 
            // txtTelefonoEmergencia
            // 
            this.txtTelefonoEmergencia.Location = new System.Drawing.Point(0, 221);
            this.txtTelefonoEmergencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoEmergencia.Name = "txtTelefonoEmergencia";
            this.txtTelefonoEmergencia.Size = new System.Drawing.Size(155, 20);
            this.txtTelefonoEmergencia.TabIndex = 104;
            // 
            // lbcalle
            // 
            this.lbcalle.AutoSize = true;
            this.lbcalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbcalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcalle.ForeColor = System.Drawing.Color.White;
            this.lbcalle.Location = new System.Drawing.Point(0, 243);
            this.lbcalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcalle.Name = "lbcalle";
            this.lbcalle.Size = new System.Drawing.Size(49, 17);
            this.lbcalle.TabIndex = 105;
            this.lbcalle.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(0, 262);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(155, 20);
            this.txtCalle.TabIndex = 106;
            // 
            // lbciudad
            // 
            this.lbciudad.AutoSize = true;
            this.lbciudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbciudad.ForeColor = System.Drawing.Color.White;
            this.lbciudad.Location = new System.Drawing.Point(0, 284);
            this.lbciudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbciudad.Name = "lbciudad";
            this.lbciudad.Size = new System.Drawing.Size(63, 17);
            this.lbciudad.TabIndex = 107;
            this.lbciudad.Text = "Ciudad:";
            // 
            // textCiudad
            // 
            this.textCiudad.Location = new System.Drawing.Point(2, 303);
            this.textCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.textCiudad.Name = "textCiudad";
            this.textCiudad.Size = new System.Drawing.Size(155, 20);
            this.textCiudad.TabIndex = 108;
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestado.ForeColor = System.Drawing.Color.White;
            this.lbestado.Location = new System.Drawing.Point(0, 325);
            this.lbestado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(63, 17);
            this.lbestado.TabIndex = 109;
            this.lbestado.Text = "Estado:";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(0, 344);
            this.textEstado.Margin = new System.Windows.Forms.Padding(2);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(155, 20);
            this.textEstado.TabIndex = 110;
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
            this.ibtnsave.Location = new System.Drawing.Point(-1, 368);
            this.ibtnsave.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnsave.Name = "ibtnsave";
            this.ibtnsave.Size = new System.Drawing.Size(64, 66);
            this.ibtnsave.TabIndex = 111;
            this.ibtnsave.Text = "Guardar";
            this.ibtnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsave.UseVisualStyleBackColor = false;
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
            this.ibtneliminar.Location = new System.Drawing.Point(107, 368);
            this.ibtneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtneliminar.Name = "ibtneliminar";
            this.ibtneliminar.Size = new System.Drawing.Size(64, 66);
            this.ibtneliminar.TabIndex = 112;
            this.ibtneliminar.Text = "Eliminar";
            this.ibtneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtneliminar.UseVisualStyleBackColor = false;
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
            this.ibtnexportarexcel.Location = new System.Drawing.Point(50, 416);
            this.ibtnexportarexcel.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnexportarexcel.Name = "ibtnexportarexcel";
            this.ibtnexportarexcel.Size = new System.Drawing.Size(64, 81);
            this.ibtnexportarexcel.TabIndex = 113;
            this.ibtnexportarexcel.Text = "Exportar a excel";
            this.ibtnexportarexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnexportarexcel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 512);
            this.label1.TabIndex = 114;
            this.label1.Text = "Datos de registro";
            // 
            // lbtitulolistaentrenadores
            // 
            this.lbtitulolistaentrenadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbtitulolistaentrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulolistaentrenadores.ForeColor = System.Drawing.Color.White;
            this.lbtitulolistaentrenadores.Location = new System.Drawing.Point(197, -1);
            this.lbtitulolistaentrenadores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtitulolistaentrenadores.Name = "lbtitulolistaentrenadores";
            this.lbtitulolistaentrenadores.Size = new System.Drawing.Size(614, 75);
            this.lbtitulolistaentrenadores.TabIndex = 115;
            this.lbtitulolistaentrenadores.Text = "LISTA DE ENTRENADORES:";
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.lbbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.White;
            this.lbbuscar.Location = new System.Drawing.Point(378, 36);
            this.lbbuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(81, 17);
            this.lbbuscar.TabIndex = 116;
            this.lbbuscar.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(95, 21);
            this.comboBox1.TabIndex = 117;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 118;
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.Location = new System.Drawing.Point(709, 27);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(30, 35);
            this.ibtnbusca.TabIndex = 119;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // ibtnlimpiar
            // 
            this.ibtnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Brush;
            this.ibtnlimpiar.IconColor = System.Drawing.Color.Black;
            this.ibtnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnlimpiar.IconSize = 30;
            this.ibtnlimpiar.Location = new System.Drawing.Point(751, 27);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(30, 35);
            this.ibtnlimpiar.TabIndex = 120;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            // 
            // frmentrenadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 508);
            this.Controls.Add(this.ibtnlimpiar);
            this.Controls.Add(this.ibtnbusca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.ibtnexportarexcel);
            this.Controls.Add(this.ibtneliminar);
            this.Controls.Add(this.ibtnsave);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.lbestado);
            this.Controls.Add(this.textCiudad);
            this.Controls.Add(this.lbciudad);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lbcalle);
            this.Controls.Add(this.txtTelefonoEmergencia);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lbtelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.txtNombreEntrenadores);
            this.Controls.Add(this.lbNE);
            this.Controls.Add(this.dgvusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtitulolistaentrenadores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmentrenadores";
            this.Text = "frmentrenadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvusuario;
        private System.Windows.Forms.Label lbNE;
        private System.Windows.Forms.TextBox txtNombreEntrenadores;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.TextBox txtTelefonoEmergencia;
        private System.Windows.Forms.Label lbcalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lbciudad;
        private System.Windows.Forms.TextBox textCiudad;
        private System.Windows.Forms.Label lbestado;
        private System.Windows.Forms.TextBox textEstado;
        private FontAwesome.Sharp.IconButton ibtnsave;
        private FontAwesome.Sharp.IconButton ibtneliminar;
        private FontAwesome.Sharp.IconButton ibtnexportarexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtitulolistaentrenadores;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Entrenadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}