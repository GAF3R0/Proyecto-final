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
using FontAwesome.Sharp;

namespace Proyecto_final
{
    public partial class INICIO : Form
    {
        private static USUARIO usuarioactual;
        private static IconButton a = null;
        private static Form FormularioActivo = null;

        public INICIO(USUARIO objUSUARIO)
        {
            usuarioactual = objUSUARIO;
            InitializeComponent();
        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            Con_botonee.BackColor = Color.FromArgb(28, 32, 40);
            List<PERMISO> Listaper = new CN_PERMISO().Listar(usuarioactual.Id_Usuario);

            foreach (IconButton iconButton in Con_botonee.Controls.OfType<IconButton>())
            {
                foreach (var permiso in Listaper)
                {
                    Console.WriteLine($"Comparando iconButton.Name: {iconButton.Name} con permiso.Nombremenu: {permiso.Nombremenu}");
                }

                bool encontrado = Listaper.Any(m => m.Nombremenu == iconButton.Name);

                if (!encontrado)
                {
                    iconButton.Visible = false;
                }
            }

            lblusuario.Text = usuarioactual.Nombre_Usuario;

            // Abrir automáticamente frmDetalleVenta al cargar el formulario INICIO
            Abrirformulariobtn(null, new frmDetalleVenta());
        }

        private void Abrirformulariobtn(IconButton b, Form formulario)
        {
            if (a != null)
            {
                a.BackColor = Color.FromArgb(28, 32, 40);
            }

            if (b != null)
            {
                b.BackColor = Color.FromArgb(3, 79, 204);
                a = b;
            }


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            Contenedor.Controls.Clear();
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Abrir frmDetalleVenta
            Abrirformulariobtn(null, new frmDetalleVenta());
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnusuario, new frmUsuario());
        }

        private void ibtnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ibtnvisita_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnvisita, new frmregistar_Visitantes());
        }

        private void ibtnmiembros_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnmiembros, new frmMienbros());
        }

     

        private void ibtninventario_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtninventario, new frmProducto());
        }

        private void ibtnclientes_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnclientes, new frmcliente());
        }

        private void ibtnacercade_Click(object sender, EventArgs e)
        {
            Abrirformulariobtn(ibtnacercade, new frmacercade());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Con_botonee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbcambio_Click(object sender, EventArgs e)
        {

        }

        private void ibtnlimpiar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

