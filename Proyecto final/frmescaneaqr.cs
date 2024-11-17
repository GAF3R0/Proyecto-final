using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class frmescaneaqr : Form
    {
        CN_CLIENTE qrmiembro = new CN_CLIENTE();
        public frmescaneaqr()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ibtnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(txtid.Text, out int idMiembro))
            {

                CLIENTE clin = qrmiembro.OMPID(idMiembro);

                if (clin != null)
                {
                    txtid.Text = clin.Cli_Id.ToString();
                    lbnombre.Text = clin.Cli_Nombre;
                    lbphone.Text = clin.Cli_Telefono;
                    lbphoneemer.Text = clin.Cli_Telefono_Emer;
                    lbfechaini.Text = clin.Fecha_Creacion.ToString("yyyy-MM-dd");
                    lbFT.Text = clin.Fecha_termina.ToString("yyyy-MM-dd");
                    lbestatus.Text = clin.oestatus.Est_descricion;
                }
                else
                {
                    MessageBox.Show("Miembro no encontrado.");
                }
            }

        }
    }
}
