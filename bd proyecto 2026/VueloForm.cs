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
    public partial class VueloForm : Form
    {
        public VueloForm()
        {
            InitializeComponent();

            pnlPantallaVuelo.BackColor = ColorTranslator.FromHtml("#040712");

            this.DoubleBuffered = true;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            pnlControlesVuelo.BackColor = ColorTranslator.FromHtml("#1E293B");
        }

        //------------------------VALIDACIONES------------------------

        private void mtbIdVuelo_Leave(object sender, EventArgs e)
        {
            ValidarLongitudIdVuelo();
        }

        public bool ValidarLongitudIdVuelo()
        {
            if (mtbIdVuelo.Text.Length != 7)
            {
                errIdVuelo.SetError(mtbIdVuelo, "El ID del vuelo debe tener exactamente 7 caracteres.");
                return false;
            }
            else
            {
                errIdVuelo.SetError(mtbIdVuelo, "");
                return true;
            }
        }

        //------------------------

        private void txtOrigenVuelo_Leave(object sender, EventArgs e)
        {
            ValidarOrigenVuelo();
        }

        public bool ValidarOrigenVuelo()
        {
            if (string.IsNullOrWhiteSpace(txtOrigenVuelo.Text))
            {
                errOrigenVuelo.SetError(txtOrigenVuelo, "El origen del vuelo no puede estar vacío.");
                return false;
            }
            else
            {
                errOrigenVuelo.SetError(txtOrigenVuelo, "");
                return true;
            }
        }

        //------------------------

        private void txtDestinoVuelo_Leave(object sender, EventArgs e)
        {
            ValidarDestinoVuelo();
        }

        public bool ValidarDestinoVuelo()
        {
            if (string.IsNullOrWhiteSpace(txtDestinoVuelo.Text))
            {
                errDestinoVuelo.SetError(txtDestinoVuelo, "El destino del vuelo no puede estar vacío.");
                return false;
            }
            else
            {
                errDestinoVuelo.SetError(txtDestinoVuelo, "");
                return true;
            }
        }

        //------------------------

        private void nudNumeroAsientosVuelo_Leave(object sender, EventArgs e)
        {
            ValidarNumeroAsientosVuelo();
        }

        public bool ValidarNumeroAsientosVuelo()
        {
            if (nudNumeroAsientosVuelo.Value <= 0)
            {
                errNumeroAsientosVuelo.SetError(nudNumeroAsientosVuelo, "El número de asientos debe ser mayor que cero.");
                return false;
            }
            else
            {
                errNumeroAsientosVuelo.SetError(nudNumeroAsientosVuelo, "");
                return true;
            }
        }

        //------------------------

        private void nudPrecioVuelo_Leave(object sender, EventArgs e)
        {
            //ValidarPrecioVuelo();
            if (!ValidarPrecioVuelo())
            {
                return;
            }
        }

        public bool ValidarPrecioVuelo()
        {

            if (string.IsNullOrWhiteSpace(nudPrecioVuelo.Text))
            {
                errPrecioVuelo.SetError(nudPrecioVuelo, "Debe ingresar un precio.");
                return false;
            }
            else if (!double.TryParse(nudPrecioVuelo.Text, out double precio))
            {
                errPrecioVuelo.SetError(nudPrecioVuelo, "Solo se permiten números.");
                return false;
            }
            else if (precio <= 0)
            {
                errPrecioVuelo.SetError(nudPrecioVuelo, "El precio debe ser mayor que cero.");
                return false;
            }
            else
            {
                errPrecioVuelo.SetError(nudPrecioVuelo, "");
                return true;
            }
        }

        //------------------------

        private void dtpFechaInicioVuelo_Leave(object sender, EventArgs e)
        {
            //ValidarFechaInicioVuelo();
        }

        /*public bool ValidarFechaInicioVuelo()
        {
            if (dtpFechaInicioVuelo.Value < DateTime.Now)
            {
                errFechaInicioVuelo.SetError(dtpFechaInicioVuelo, "La fecha de inicio del vuelo no puede ser en el pasado.");
                return false;
            }
            else
            {
                errFechaInicioVuelo.SetError(dtpFechaInicioVuelo, "");
                return true;
            }
        }*/

        //------------------------

        private void dtpFechaFinVuelo_Leave(object sender, EventArgs e)
        {
            ValidarFechaFinVuelo();
        }

        public bool ValidarFechaFinVuelo()
        {
            if (dtpFechaFinVuelo.Value < dtpFechaInicioVuelo.Value)
            {
                errFechaFinVuelo.SetError(dtpFechaFinVuelo, "La fecha de fin del vuelo no puede ser anterior a la fecha de inicio.");
                return false;
            }
            else
            {
                errFechaFinVuelo.SetError(dtpFechaFinVuelo, "");
                return true;
            }
        }

        //------------------------

        private void cmbEstatusVuelo_Leave(object sender, EventArgs e)
        {
            ValidarEstatusVuelo();
        }

        public bool ValidarEstatusVuelo()
        {
            if (cmbEstatusVuelo.SelectedIndex == -1)
            {
                errEstatusVuelo.SetError(cmbEstatusVuelo, "Debe seleccionar un estatus para el vuelo.");
                return false;
            }
            else
            {
                errEstatusVuelo.SetError(cmbEstatusVuelo, "");
                return true;
            }
        }













        VueloDAO dao = new VueloDAO();


        private void btnActualizarVuelo_Click(object sender, EventArgs e)
        {
            VueloDTO vuelo = new VueloDTO();

            vuelo.IdVuelo = int.Parse(mtbIdVuelo.Text);
            vuelo.Origen = txtOrigenVuelo.Text;
            vuelo.Destino = txtDestinoVuelo.Text;
            vuelo.NoAsientos = Convert.ToInt16(nudNumeroAsientosVuelo.Text);
            vuelo.Precio = Convert.ToDouble(nudPrecioVuelo.Text);
            vuelo.FechaInicio = dtpFechaInicioVuelo.Value;
            vuelo.FechaLlegada = dtpFechaFinVuelo.Value;
            switch (cmbEstatusVuelo.Text.ToLower()) // lo pasamos todo a minúsculas 
            {
                case "programado":
                    vuelo.Estatus = 1; // 🔢 CÓDIGO QUE TÚ DEFINES
                    break;
                case "en vuelo":
                    vuelo.Estatus = 2;
                    break;
                case "aterrizado":
                    vuelo.Estatus = 3;
                    break;
                case "cancelado":
                    vuelo.Estatus = 4;
                    break;
                case "retrasado":
                    vuelo.Estatus = 5;
                    break;
                default:
                    MessageBox.Show("Estatus no reconocido");
                    return; // ❌ DETIENE SI ES ALGO QUE NO TIENES DEFINIDO
            }



            if (dao.Actualizar(vuelo))
            {
                MessageBox.Show("Registro actualizado correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }
        private void Limpiar()
        {
            mtbIdVuelo.Clear();
            txtOrigenVuelo.Clear();
            txtDestinoVuelo.Clear();
            nudNumeroAsientosVuelo.Value = 0;
            nudPrecioVuelo.Clear();
            dtpFechaInicioVuelo.Value = DateTime.Now;
            dtpFechaFinVuelo.Value = DateTime.Now;
            cmbEstatusVuelo.SelectedIndex = -1;

            CargarDatos();
        }
        private void CargarDatos()
        {
            dgvVuelo.DataSource = dao.ObtenerTodos();
            dgvAuditorias.DataSource = dao.MostrarAuditorias();
        }
        private void btnInsertarVuelo_Click(object sender, EventArgs e)
        {
            VueloDTO vuelo = new VueloDTO();

            vuelo.IdVuelo = long.Parse(mtbIdVuelo.Text);
            vuelo.Origen = txtOrigenVuelo.Text;
            vuelo.Destino = txtDestinoVuelo.Text;
            vuelo.NoAsientos = Convert.ToInt16(nudNumeroAsientosVuelo.Text);
            vuelo.Precio = Convert.ToDouble(nudPrecioVuelo.Text);
            vuelo.FechaInicio = dtpFechaInicioVuelo.Value;
            vuelo.FechaLlegada = dtpFechaFinVuelo.Value;
            switch (cmbEstatusVuelo.Text.ToLower()) // lo pasamos todo a minúsculas para que no falle
            {
                case "programado":
                    vuelo.Estatus = 1; // 🔢 CÓDIGO QUE TÚ DEFINES
                    break;
                case "en vuelo":
                    vuelo.Estatus = 2;
                    break;
                case "aterrizado":
                    vuelo.Estatus = 3;
                    break;
                case "cancelado":
                    vuelo.Estatus = 4;
                    break;
                case "retrasado":
                    vuelo.Estatus = 5;
                    break;
                default:
                    MessageBox.Show("Estatus no reconocido");
                    return; // ❌ DETIENE SI ES ALGO QUE NO TIENES DEFINIDO
            }



            if (dao.Insertar(vuelo))
            {
                MessageBox.Show("Registro insertado correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
        }

        private void pnlPantallaVuelo_Paint(object sender, PaintEventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminarVuelo_Click(object sender, EventArgs e)
        {
            int id = int.Parse(mtbIdVuelo.Text);




            if (dao.Eliminar(id))
            {
                MessageBox.Show("Registro eliminado correctamente");
                CargarDatos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {
            Limpiar();
            CargarDatos();
        }

        private void txtBuscarVuelo_TextChanged(object sender, EventArgs e)
        {

            CargarDatos(); 
            VueloDAO dao = new VueloDAO();

            if (string.IsNullOrWhiteSpace(txtBuscarVuelo.Text))
            {
                dgvVuelo.DataSource = dao.ObtenerTodos();
            }
            else
            {
                dgvVuelo.DataSource = dao.BuscarVuelo(txtBuscarVuelo.Text);
            }



            if (string.IsNullOrWhiteSpace(txtBuscarVuelo.Text))
            {
                dgvAuditorias.DataSource = dao.MostrarAuditorias();
            }
            else
            {
                dgvAuditorias.DataSource = dao.BuscarAuditorias(txtBuscarVuelo.Text);
            }
            
        }

        private void cmbEstatusVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //------------------------





    }
}
