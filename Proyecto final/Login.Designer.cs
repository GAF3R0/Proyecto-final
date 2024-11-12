
namespace Proyecto_final
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnomusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.btningresar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(180, 331);
            this.txtclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(295, 22);
            this.txtclave.TabIndex = 13;
            this.txtclave.TextChanged += new System.EventHandler(this.txtclave_TextChanged);
            // 
            // txtnomusuario
            // 
            this.txtnomusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomusuario.Location = new System.Drawing.Point(180, 268);
            this.txtnomusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnomusuario.Name = "txtnomusuario";
            this.txtnomusuario.Size = new System.Drawing.Size(295, 22);
            this.txtnomusuario.TabIndex = 12;
            this.txtnomusuario.TextChanged += new System.EventHandler(this.txtnomusuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(200, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "UNA-FIT";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btncancelar.IconColor = System.Drawing.Color.White;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 21;
            this.btncancelar.Location = new System.Drawing.Point(360, 389);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(180, 57);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.btningresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btningresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.ForeColor = System.Drawing.Color.White;
            this.btningresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btningresar.IconColor = System.Drawing.Color.White;
            this.btningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btningresar.IconSize = 21;
            this.btningresar.Location = new System.Drawing.Point(116, 389);
            this.btningresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(180, 57);
            this.btningresar.TabIndex = 16;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(65)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(685, 666);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtnomusuario);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btningresar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnomusuario;
        private System.Windows.Forms.Label label2;
    }
}

