
namespace Proyecto_final
{
    partial class INICIO
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
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
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
            this.Con_botonee = new System.Windows.Forms.Panel();
            this.ibtnclientes = new FontAwesome.Sharp.IconButton();
            this.ibtninicio = new FontAwesome.Sharp.IconButton();
            this.ibtnsalir = new FontAwesome.Sharp.IconButton();
            this.ibtnacercade = new FontAwesome.Sharp.IconButton();
            this.ibtninventario = new FontAwesome.Sharp.IconButton();
            this.ibtnventas = new FontAwesome.Sharp.IconButton();
            this.ibtnmiembros = new FontAwesome.Sharp.IconButton();
            this.ibtnvisita = new FontAwesome.Sharp.IconButton();
            this.ibtnusuario = new FontAwesome.Sharp.IconButton();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.Con_botonee.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1500, 73);
            this.menutitulo.TabIndex = 2;
            this.menutitulo.Text = "menuStrip2";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(1307, 24);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(118, 29);
            this.lblusuario.TabIndex = 7;
            this.lblusuario.Text = "lblusuario";
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(202)))));
            this.lbtitulo.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.Color.White;
            this.lbtitulo.Location = new System.Drawing.Point(141, 20);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(115, 33);
            this.lbtitulo.TabIndex = 8;
            this.lbtitulo.Text = "UNI-FIT";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.Contenedor.Controls.Add(this.dgvprod);
            this.Contenedor.Controls.Add(this.txtpago);
            this.Contenedor.Controls.Add(this.txtcambio);
            this.Contenedor.Controls.Add(this.txtmtotal);
            this.Contenedor.Controls.Add(this.icbticket);
            this.Contenedor.Controls.Add(this.lbcambio);
            this.Contenedor.Controls.Add(this.lbmontopago);
            this.Contenedor.Controls.Add(this.lbmontot);
            this.Contenedor.Controls.Add(this.txtusuario2);
            this.Contenedor.Controls.Add(this.txttpproducto);
            this.Contenedor.Controls.Add(this.txtfecha1);
            this.Contenedor.Controls.Add(this.lb2usuario);
            this.Contenedor.Controls.Add(this.lbtpproducto);
            this.Contenedor.Controls.Add(this.lbfecha);
            this.Contenedor.Controls.Add(this.lbinfventa);
            this.Contenedor.Controls.Add(this.ibtnlimpiar);
            this.Contenedor.Controls.Add(this.ibtnbusca);
            this.Contenedor.Controls.Add(this.txtnmproducto);
            this.Contenedor.Controls.Add(this.lbnmproducto);
            this.Contenedor.Controls.Add(this.lbtitulodv);
            this.Contenedor.Location = new System.Drawing.Point(0, 73);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1231, 730);
            this.Contenedor.TabIndex = 11;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
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
            this.dgvprod.Location = new System.Drawing.Point(67, 171);
            this.dgvprod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.RowHeadersWidth = 51;
            this.dgvprod.Size = new System.Drawing.Size(984, 358);
            this.dgvprod.TabIndex = 154;
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
            this.txtpago.Location = new System.Drawing.Point(447, 553);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(79, 22);
            this.txtpago.TabIndex = 153;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(736, 555);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(81, 22);
            this.txtcambio.TabIndex = 152;
            // 
            // txtmtotal
            // 
            this.txtmtotal.Location = new System.Drawing.Point(168, 551);
            this.txtmtotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtmtotal.Name = "txtmtotal";
            this.txtmtotal.Size = new System.Drawing.Size(85, 22);
            this.txtmtotal.TabIndex = 151;
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
            this.icbticket.Location = new System.Drawing.Point(871, 535);
            this.icbticket.Margin = new System.Windows.Forms.Padding(4);
            this.icbticket.Name = "icbticket";
            this.icbticket.Size = new System.Drawing.Size(180, 62);
            this.icbticket.TabIndex = 150;
            this.icbticket.Text = "Generar Ticket";
            this.icbticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icbticket.UseVisualStyleBackColor = true;
            // 
            // lbcambio
            // 
            this.lbcambio.AutoSize = true;
            this.lbcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcambio.ForeColor = System.Drawing.Color.White;
            this.lbcambio.Location = new System.Drawing.Point(544, 555);
            this.lbcambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcambio.Name = "lbcambio";
            this.lbcambio.Size = new System.Drawing.Size(167, 25);
            this.lbcambio.TabIndex = 149;
            this.lbcambio.Text = "Monto de Cambio";
            this.lbcambio.Click += new System.EventHandler(this.lbcambio_Click);
            // 
            // lbmontopago
            // 
            this.lbmontopago.AutoSize = true;
            this.lbmontopago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontopago.ForeColor = System.Drawing.Color.White;
            this.lbmontopago.Location = new System.Drawing.Point(283, 553);
            this.lbmontopago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmontopago.Name = "lbmontopago";
            this.lbmontopago.Size = new System.Drawing.Size(145, 25);
            this.lbmontopago.TabIndex = 148;
            this.lbmontopago.Text = "Monto de Pago";
            // 
            // lbmontot
            // 
            this.lbmontot.AutoSize = true;
            this.lbmontot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmontot.ForeColor = System.Drawing.Color.White;
            this.lbmontot.Location = new System.Drawing.Point(36, 553);
            this.lbmontot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmontot.Name = "lbmontot";
            this.lbmontot.Size = new System.Drawing.Size(116, 25);
            this.lbmontot.TabIndex = 147;
            this.lbmontot.Text = "Monto Total";
            // 
            // txtusuario2
            // 
            this.txtusuario2.Location = new System.Drawing.Point(624, 128);
            this.txtusuario2.Margin = new System.Windows.Forms.Padding(4);
            this.txtusuario2.Name = "txtusuario2";
            this.txtusuario2.Size = new System.Drawing.Size(193, 22);
            this.txtusuario2.TabIndex = 145;
            // 
            // txttpproducto
            // 
            this.txttpproducto.Location = new System.Drawing.Point(312, 128);
            this.txttpproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txttpproducto.Name = "txttpproducto";
            this.txttpproducto.Size = new System.Drawing.Size(193, 22);
            this.txttpproducto.TabIndex = 144;
            // 
            // txtfecha1
            // 
            this.txtfecha1.Location = new System.Drawing.Point(31, 128);
            this.txtfecha1.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha1.Name = "txtfecha1";
            this.txtfecha1.Size = new System.Drawing.Size(193, 22);
            this.txtfecha1.TabIndex = 143;
            // 
            // lb2usuario
            // 
            this.lb2usuario.AutoSize = true;
            this.lb2usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2usuario.ForeColor = System.Drawing.Color.White;
            this.lb2usuario.Location = new System.Drawing.Point(620, 96);
            this.lb2usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2usuario.Name = "lb2usuario";
            this.lb2usuario.Size = new System.Drawing.Size(67, 20);
            this.lb2usuario.TabIndex = 142;
            this.lb2usuario.Text = "Usuario";
            // 
            // lbtpproducto
            // 
            this.lbtpproducto.AutoSize = true;
            this.lbtpproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtpproducto.ForeColor = System.Drawing.Color.White;
            this.lbtpproducto.Location = new System.Drawing.Point(308, 96);
            this.lbtpproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtpproducto.Name = "lbtpproducto";
            this.lbtpproducto.Size = new System.Drawing.Size(136, 20);
            this.lbtpproducto.TabIndex = 141;
            this.lbtpproducto.Text = "Tipo de Producto";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.White;
            this.lbfecha.Location = new System.Drawing.Point(37, 96);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(60, 20);
            this.lbfecha.TabIndex = 140;
            this.lbfecha.Text = "Fecha:";
            // 
            // lbinfventa
            // 
            this.lbinfventa.AutoSize = true;
            this.lbinfventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinfventa.ForeColor = System.Drawing.Color.White;
            this.lbinfventa.Location = new System.Drawing.Point(25, 54);
            this.lbinfventa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbinfventa.Name = "lbinfventa";
            this.lbinfventa.Size = new System.Drawing.Size(197, 25);
            this.lbinfventa.TabIndex = 139;
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
            this.ibtnlimpiar.Location = new System.Drawing.Point(947, 49);
            this.ibtnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnlimpiar.Name = "ibtnlimpiar";
            this.ibtnlimpiar.Size = new System.Drawing.Size(121, 43);
            this.ibtnlimpiar.TabIndex = 138;
            this.ibtnlimpiar.Text = "Limpiar";
            this.ibtnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnlimpiar.UseVisualStyleBackColor = true;
            this.ibtnlimpiar.Click += new System.EventHandler(this.ibtnlimpiar_Click);
            // 
            // ibtnbusca
            // 
            this.ibtnbusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnbusca.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.ibtnbusca.IconColor = System.Drawing.Color.Black;
            this.ibtnbusca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnbusca.IconSize = 30;
            this.ibtnbusca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnbusca.Location = new System.Drawing.Point(820, 49);
            this.ibtnbusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnbusca.Name = "ibtnbusca";
            this.ibtnbusca.Size = new System.Drawing.Size(121, 43);
            this.ibtnbusca.TabIndex = 137;
            this.ibtnbusca.Text = " Buscar";
            this.ibtnbusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnbusca.UseVisualStyleBackColor = true;
            // 
            // txtnmproducto
            // 
            this.txtnmproducto.Location = new System.Drawing.Point(567, 60);
            this.txtnmproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtnmproducto.Name = "txtnmproducto";
            this.txtnmproducto.Size = new System.Drawing.Size(245, 22);
            this.txtnmproducto.TabIndex = 2;
            // 
            // lbnmproducto
            // 
            this.lbnmproducto.AutoSize = true;
            this.lbnmproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnmproducto.ForeColor = System.Drawing.Color.White;
            this.lbnmproducto.Location = new System.Drawing.Point(352, 60);
            this.lbnmproducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnmproducto.Name = "lbnmproducto";
            this.lbnmproducto.Size = new System.Drawing.Size(197, 25);
            this.lbnmproducto.TabIndex = 1;
            this.lbnmproducto.Text = "Numero de Producto:";
            // 
            // lbtitulodv
            // 
            this.lbtitulodv.AutoSize = true;
            this.lbtitulodv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulodv.ForeColor = System.Drawing.Color.White;
            this.lbtitulodv.Location = new System.Drawing.Point(27, 14);
            this.lbtitulodv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtitulodv.Name = "lbtitulodv";
            this.lbtitulodv.Size = new System.Drawing.Size(214, 31);
            this.lbtitulodv.TabIndex = 0;
            this.lbtitulodv.Text = "Detalle de Venta";
            // 
            // Con_botonee
            // 
            this.Con_botonee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Con_botonee.Controls.Add(this.ibtnclientes);
            this.Con_botonee.Controls.Add(this.ibtninicio);
            this.Con_botonee.Controls.Add(this.ibtnsalir);
            this.Con_botonee.Controls.Add(this.ibtnacercade);
            this.Con_botonee.Controls.Add(this.ibtninventario);
            this.Con_botonee.Controls.Add(this.ibtnventas);
            this.Con_botonee.Controls.Add(this.ibtnmiembros);
            this.Con_botonee.Controls.Add(this.ibtnvisita);
            this.Con_botonee.Controls.Add(this.ibtnusuario);
            this.Con_botonee.Location = new System.Drawing.Point(1227, 72);
            this.Con_botonee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Con_botonee.Name = "Con_botonee";
            this.Con_botonee.Size = new System.Drawing.Size(273, 729);
            this.Con_botonee.TabIndex = 14;
            this.Con_botonee.Paint += new System.Windows.Forms.PaintEventHandler(this.Con_botonee_Paint);
            // 
            // ibtnclientes
            // 
            this.ibtnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnclientes.FlatAppearance.BorderSize = 0;
            this.ibtnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnclientes.ForeColor = System.Drawing.Color.White;
            this.ibtnclientes.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.ibtnclientes.IconColor = System.Drawing.Color.White;
            this.ibtnclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnclientes.IconSize = 50;
            this.ibtnclientes.Location = new System.Drawing.Point(29, 145);
            this.ibtnclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnclientes.Name = "ibtnclientes";
            this.ibtnclientes.Size = new System.Drawing.Size(107, 89);
            this.ibtnclientes.TabIndex = 7;
            this.ibtnclientes.Text = "Cliente";
            this.ibtnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnclientes.UseVisualStyleBackColor = true;
            this.ibtnclientes.Click += new System.EventHandler(this.ibtnclientes_Click);
            // 
            // ibtninicio
            // 
            this.ibtninicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtninicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtninicio.FlatAppearance.BorderSize = 0;
            this.ibtninicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtninicio.ForeColor = System.Drawing.Color.White;
            this.ibtninicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibtninicio.IconColor = System.Drawing.Color.White;
            this.ibtninicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtninicio.IconSize = 50;
            this.ibtninicio.Location = new System.Drawing.Point(27, 52);
            this.ibtninicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtninicio.Name = "ibtninicio";
            this.ibtninicio.Size = new System.Drawing.Size(107, 89);
            this.ibtninicio.TabIndex = 7;
            this.ibtninicio.Text = "Inicio";
            this.ibtninicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtninicio.UseVisualStyleBackColor = true;
            this.ibtninicio.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.ibtnsalir.Location = new System.Drawing.Point(85, 458);
            this.ibtnsalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnsalir.Name = "ibtnsalir";
            this.ibtnsalir.Size = new System.Drawing.Size(107, 89);
            this.ibtnsalir.TabIndex = 6;
            this.ibtnsalir.Text = "Salir";
            this.ibtnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnsalir.UseVisualStyleBackColor = true;
            this.ibtnsalir.Click += new System.EventHandler(this.ibtnsalir_Click);
            // 
            // ibtnacercade
            // 
            this.ibtnacercade.AllowDrop = true;
            this.ibtnacercade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnacercade.FlatAppearance.BorderSize = 0;
            this.ibtnacercade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnacercade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnacercade.ForeColor = System.Drawing.Color.White;
            this.ibtnacercade.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.ibtnacercade.IconColor = System.Drawing.Color.White;
            this.ibtnacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnacercade.IconSize = 50;
            this.ibtnacercade.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnacercade.Location = new System.Drawing.Point(145, 334);
            this.ibtnacercade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnacercade.Name = "ibtnacercade";
            this.ibtnacercade.Size = new System.Drawing.Size(107, 89);
            this.ibtnacercade.TabIndex = 5;
            this.ibtnacercade.Text = "Acerca de";
            this.ibtnacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnacercade.UseVisualStyleBackColor = true;
            this.ibtnacercade.Click += new System.EventHandler(this.ibtnacercade_Click);
            // 
            // ibtninventario
            // 
            this.ibtninventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtninventario.FlatAppearance.BorderSize = 0;
            this.ibtninventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtninventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtninventario.ForeColor = System.Drawing.Color.White;
            this.ibtninventario.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.ibtninventario.IconColor = System.Drawing.Color.White;
            this.ibtninventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtninventario.IconSize = 50;
            this.ibtninventario.Location = new System.Drawing.Point(145, 240);
            this.ibtninventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtninventario.Name = "ibtninventario";
            this.ibtninventario.Size = new System.Drawing.Size(107, 89);
            this.ibtninventario.TabIndex = 4;
            this.ibtninventario.Text = "Inventario";
            this.ibtninventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtninventario.UseVisualStyleBackColor = true;
            this.ibtninventario.Click += new System.EventHandler(this.ibtninventario_Click);
            // 
            // ibtnventas
            // 
            this.ibtnventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnventas.FlatAppearance.BorderSize = 0;
            this.ibtnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnventas.ForeColor = System.Drawing.Color.White;
            this.ibtnventas.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.ibtnventas.IconColor = System.Drawing.Color.White;
            this.ibtnventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnventas.IconSize = 50;
            this.ibtnventas.Location = new System.Drawing.Point(141, 52);
            this.ibtnventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnventas.Name = "ibtnventas";
            this.ibtnventas.Size = new System.Drawing.Size(107, 89);
            this.ibtnventas.TabIndex = 3;
            this.ibtnventas.Text = "Ventas";
            this.ibtnventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnventas.UseVisualStyleBackColor = true;
            this.ibtnventas.Click += new System.EventHandler(this.ibtnventas_Click);
            // 
            // ibtnmiembros
            // 
            this.ibtnmiembros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnmiembros.FlatAppearance.BorderSize = 0;
            this.ibtnmiembros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnmiembros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnmiembros.ForeColor = System.Drawing.Color.White;
            this.ibtnmiembros.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ibtnmiembros.IconColor = System.Drawing.Color.White;
            this.ibtnmiembros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnmiembros.IconSize = 50;
            this.ibtnmiembros.Location = new System.Drawing.Point(145, 145);
            this.ibtnmiembros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnmiembros.Name = "ibtnmiembros";
            this.ibtnmiembros.Size = new System.Drawing.Size(107, 89);
            this.ibtnmiembros.TabIndex = 2;
            this.ibtnmiembros.Text = "Miembros";
            this.ibtnmiembros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnmiembros.UseVisualStyleBackColor = true;
            this.ibtnmiembros.Click += new System.EventHandler(this.ibtnmiembros_Click);
            // 
            // ibtnvisita
            // 
            this.ibtnvisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnvisita.FlatAppearance.BorderSize = 0;
            this.ibtnvisita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnvisita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnvisita.ForeColor = System.Drawing.Color.White;
            this.ibtnvisita.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.ibtnvisita.IconColor = System.Drawing.Color.White;
            this.ibtnvisita.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnvisita.IconSize = 50;
            this.ibtnvisita.Location = new System.Drawing.Point(27, 240);
            this.ibtnvisita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnvisita.Name = "ibtnvisita";
            this.ibtnvisita.Size = new System.Drawing.Size(107, 89);
            this.ibtnvisita.TabIndex = 1;
            this.ibtnvisita.Text = "Visitantes";
            this.ibtnvisita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnvisita.UseVisualStyleBackColor = true;
            this.ibtnvisita.Click += new System.EventHandler(this.ibtnvisita_Click);
            // 
            // ibtnusuario
            // 
            this.ibtnusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnusuario.FlatAppearance.BorderSize = 0;
            this.ibtnusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(203)))));
            this.ibtnusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnusuario.ForeColor = System.Drawing.Color.White;
            this.ibtnusuario.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.ibtnusuario.IconColor = System.Drawing.Color.White;
            this.ibtnusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnusuario.IconSize = 50;
            this.ibtnusuario.Location = new System.Drawing.Point(27, 334);
            this.ibtnusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibtnusuario.Name = "ibtnusuario";
            this.ibtnusuario.Size = new System.Drawing.Size(107, 89);
            this.ibtnusuario.TabIndex = 0;
            this.ibtnusuario.Text = "Usuarios";
            this.ibtnusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ibtnusuario.UseVisualStyleBackColor = true;
            this.ibtnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.Con_botonee);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.menutitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIO";
            this.Load += new System.EventHandler(this.INICIO_Load);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.Con_botonee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbtitulo;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel Contenedor;
        private FontAwesome.Sharp.IconButton ibtnusuario;
        private FontAwesome.Sharp.IconButton ibtnsalir;
        private FontAwesome.Sharp.IconButton ibtnacercade;
        private FontAwesome.Sharp.IconButton ibtninventario;
        private FontAwesome.Sharp.IconButton ibtnventas;
        private FontAwesome.Sharp.IconButton ibtnmiembros;
        private FontAwesome.Sharp.IconButton ibtnvisita;
        private FontAwesome.Sharp.IconButton ibtninicio;
        private FontAwesome.Sharp.IconButton ibtnclientes;
        private System.Windows.Forms.TextBox txtnmproducto;
        private System.Windows.Forms.Label lbnmproducto;
        private System.Windows.Forms.Label lbtitulodv;
        private FontAwesome.Sharp.IconButton ibtnbusca;
        private FontAwesome.Sharp.IconButton ibtnlimpiar;
        private System.Windows.Forms.Label lbinfventa;
        private System.Windows.Forms.Label lbtpproducto;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.TextBox txtusuario2;
        private System.Windows.Forms.TextBox txttpproducto;
        private System.Windows.Forms.TextBox txtfecha1;
        private System.Windows.Forms.Label lb2usuario;
        private System.Windows.Forms.Panel Con_botonee;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtmtotal;
        private FontAwesome.Sharp.IconButton icbticket;
        private System.Windows.Forms.Label lbcambio;
        private System.Windows.Forms.Label lbmontopago;
        private System.Windows.Forms.Label lbmontot;
        private System.Windows.Forms.TextBox txtpago;
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