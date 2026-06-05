using System.Diagnostics.Eventing.Reader;
using System.Globalization;

namespace bd_proyecto_2026
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();

            AbrirFormulario(new InicioForm());

            // Panel lateral
            pnlMenuInferior.BackColor = ColorTranslator.FromHtml("#111827");

            // Panel formulario
            pnlPantalla.BackColor = ColorTranslator.FromHtml("#1E293B");

            pnlSeleccion.BackColor = ColorTranslator.FromHtml("#228be6");

            foreach (Button boton in pnlMenuInferior.Controls.OfType<Button>())
            {
                PersonalizarBoton(boton);
            }


        }

        //------------------------------------------------------------

        private void btnInicio_Click(object sender, EventArgs e)
        {
            cargarFormulario(new InicioForm());
            pnlSeleccion.Height = btnInicio.Height;
            pnlSeleccion.Top = btnInicio.Top;

        }

        private void btnVuelo_Click(object sender, EventArgs e)
        {
            cargarFormulario(new VueloForm());
            pnlSeleccion.Height = btnVuelo.Height;
            pnlSeleccion.Top = btnVuelo.Top;
        }


        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            cargarFormulario(new EmpleadoForm());
            pnlSeleccion.Height = btnEmpleado.Height;
            pnlSeleccion.Top = btnEmpleado.Top;
        }

        public void cargarFormulario(object Form)
        {
            if (this.pnlPantalla.Controls.Count > 0)
                this.pnlPantalla.Controls.RemoveAt(0);

            Form formhijo = Form as Form;
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            this.pnlPantalla.Controls.Add(formhijo);
            this.pnlPantalla.Tag = formhijo;
            formhijo.Show();
        }


        //------------------------------------------------------------

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            ColapsarMenu();
        }

        private void ColapsarMenu()
        {
            if (this.pnlMenuLateral.Width > 200)
            {
                pnlMenuLateral.Width = 100;
                picLogoUAEMEX.Visible = false;
                btnMenuLateral.Location = new Point(0, 0); // cabe dentro de los 100px
                foreach (Button boton in pnlMenuInferior.Controls.OfType<Button>())
                {
                    boton.Text = "";
                    boton.ImageAlign = ContentAlignment.MiddleCenter;
                    boton.Padding = new Padding(0);
                }
            }
            else
            {
                pnlMenuLateral.Width = 250;
                picLogoUAEMEX.Visible = true;
                btnMenuLateral.Location = new Point(146, 0); // su posición original
                foreach (Button boton in pnlMenuInferior.Controls.OfType<Button>())
                {
                    boton.Text = "   " + boton.Tag.ToString();
                    boton.ImageAlign = ContentAlignment.MiddleLeft;
                    boton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        //------------------------------------------------------------

        public void PersonalizarBoton(Button btn)
        {
            //btnMenuLateral.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#2a2d37");
            btnMenuLateral.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#2f3f69");

            btnInicio.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#2f3f69");

            //btnVuelo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVuelo.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#2f3f69");

            //btnEmpleado.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEmpleado.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#2f3f69");

        }

        private void AbrirFormulario(Form formulario)
        {
            pnlPantalla.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlPantalla.Controls.Add(formulario);
            formulario.Show();
        }


    }
}
