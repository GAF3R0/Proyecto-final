using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace Proyecto_final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            List<USUARIO> TEST = new CN_USUARIOS().Listar();

            USUARIO ousuario = new CN_USUARIOS().Listar().Where(u => u.Nombre_Usuario == txtnomusuario.Text
            && u.Clave == txtclave.Text).FirstOrDefault();

            if (ousuario != null)
            {

                INICIO form = new INICIO(ousuario);

                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                if(TEST == null)
                {
                   
                    frmRegisprevio form = new frmRegisprevio();
                    form.Show();
                    this.Hide();

                    form.FormClosing += frm_closing;
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO EL USUARIO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }              
                
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtclave.Clear();
            txtnomusuario.Clear();

            this.Show();

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtnomusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclave_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }


}
