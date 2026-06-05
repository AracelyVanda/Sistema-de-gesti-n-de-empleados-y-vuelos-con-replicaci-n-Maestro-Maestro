using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd_proyecto_2026
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();

            pnlPantallaInicio.BackColor = ColorTranslator.FromHtml("#040712");

            this.DoubleBuffered = true;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
        }
    }
}
