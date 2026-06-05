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
    public partial class EmpleadoForm : Form
    {
        public EmpleadoForm()
        {
            InitializeComponent();

            pnlPantallaEmpleado.BackColor = ColorTranslator.FromHtml("#040712");

            this.DoubleBuffered = true;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            pnlControlesEmpleado.BackColor = ColorTranslator.FromHtml("#1E293B");


        }


        //------------------------VALIDACIONES------------------------

        private void mtbIdEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarLongitudIdEmpleado();
        }

        public bool ValidarLongitudIdEmpleado()
        {
            if (mtbIdEmpleado.Text.Length != 7)
            {
                errIdEmpleado.SetError(mtbIdEmpleado, "El ID del empleado debe tener exactamente 7 caracteres.");
                return false;
            }
            else
            {
                errIdEmpleado.SetError(mtbIdEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void txtNombreEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarNombreEmpleado();
        }

        public bool ValidarNombreEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txtNombreEmpleado.Text))
            {
                errNombreEmpleado.SetError(txtNombreEmpleado, "El nombre del empleado no puede estar vacío.");
                return false;
            }
            else
            {
                errNombreEmpleado.SetError(txtNombreEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void txtApellidoPaternoEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarApellidoPaternoEmpleado();
        }

        public bool ValidarApellidoPaternoEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txtApellidoPaternoEmpleado.Text))
            {
                errApellidoPaternoEmpleado.SetError(txtApellidoPaternoEmpleado, "El apellido paterno del empleado no puede estar vacío.");
                return false;
            }
            else
            {
                errApellidoPaternoEmpleado.SetError(txtApellidoPaternoEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void txtApellidoMaternoEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarApellidoMaternoEmpleado();
        }

        public bool ValidarApellidoMaternoEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txtApellidoMaternoEmpleado.Text))
            {
                errApellidoMaternoEmpleado.SetError(txtApellidoMaternoEmpleado, "El apellido materno del empleado no puede estar vacío.");
                return false;
            }
            else
            {
                errApellidoMaternoEmpleado.SetError(txtApellidoMaternoEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void dtpFechaNacimientoEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarFechaNacimientoEmpleado();
        }

        public bool ValidarFechaNacimientoEmpleado()
        {
            DateTime fechaNacimiento = dtpFechaNacimientoEmpleado.Value;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            if (fechaNacimiento > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            if (fechaNacimiento > DateTime.Today)
            {
                errFechaNacimientoEmpleado.SetError(dtpFechaNacimientoEmpleado,
                    "La fecha de nacimiento no puede ser futura.");
                return false;
            }
            else if (edad < 18)
            {
                errFechaNacimientoEmpleado.SetError(dtpFechaNacimientoEmpleado,
                    "El empleado debe ser mayor de edad.");
                return false;
            }
            else
            {
                errFechaNacimientoEmpleado.SetError(dtpFechaNacimientoEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void cmbSexoEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarSexoEmpleado();
        }

        public bool ValidarSexoEmpleado()
        {
            if (cmbSexoEmpleado.SelectedIndex == -1)
            {
                errSexoEmpleado.SetError(cmbSexoEmpleado, "Debe seleccionar un sexo para el empleado.");
                return false;
            }
            else
            {
                errSexoEmpleado.SetError(cmbSexoEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void txtRfcEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarRfcEmpleado();
        }

        public bool ValidarRfcEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txtRfcEmpleado.Text))
            {
                errRfcEmpleado.SetError(txtRfcEmpleado, "El RFC del empleado no puede estar vacío.");
                return false;
            }
            else
            {
                errRfcEmpleado.SetError(txtRfcEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void txtTelefonoEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarTelefonoEmpleado();
        }

        public bool ValidarTelefonoEmpleado()
        {
            if (string.IsNullOrWhiteSpace(txtTelefonoEmpleado.Text))
            {
                errTelefonoEmpleado.SetError(
                    txtTelefonoEmpleado,
                    "El número de teléfono no puede estar vacío."
                );

                return false;
            }
            else if (!txtTelefonoEmpleado.Text.All(char.IsDigit))
            {
                errTelefonoEmpleado.SetError(
                    txtTelefonoEmpleado,
                    "El número de teléfono solo debe contener dígitos."
                );

                return false;
            }
            else if (txtTelefonoEmpleado.Text.Length != 10)
            {
                errTelefonoEmpleado.SetError(
                    txtTelefonoEmpleado,
                    "El número de teléfono debe tener exactamente 10 dígitos."
                );
                return false;
            }
            else
            {
                errTelefonoEmpleado.SetError(txtTelefonoEmpleado, "");
                return true;
            }
        }

        private void txtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosNumeroTelefonoEmpleado(e);
        }

        public void SoloNumerosNumeroTelefonoEmpleado(KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //------------------------

        private void cmbEstatusEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarEstatusEmpleado();
        }

        public bool ValidarEstatusEmpleado()
        {
            if (cmbEstatusEmpleado.SelectedIndex == -1)
            {
                errEstatusEmpleado.SetError(cmbEstatusEmpleado, "Debe seleccionar un estatus para el empleado.");
                return false;
            }
            else
            {
                errEstatusEmpleado.SetError(cmbEstatusEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void nudSueldoEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarSueldoEmpleado();
        }

        public bool ValidarSueldoEmpleado()
        {
            if (string.IsNullOrWhiteSpace(nudSueldoEmpleado.Text))
            {
                errSueldoEmpleado.SetError(nudSueldoEmpleado, "Debe ingresar un sueldo.");
                return false;
            }
            else if (!double.TryParse(nudSueldoEmpleado.Text, out double sueldo))
            {
                errSueldoEmpleado.SetError(nudSueldoEmpleado, "El sueldo debe contener únicamente números.");
                return false;
            }
            else if (sueldo <= 0)
            {
                errSueldoEmpleado.SetError(nudSueldoEmpleado, "El sueldo debe ser mayor que cero.");
                return false;
            }
            else
            {
                errSueldoEmpleado.SetError(nudSueldoEmpleado, "");
                return true;
            }
        }

        //------------------------

        private void cmbAreaEmpleado_Leave(object sender, EventArgs e)
        {
            ValidarAreaEmpleado();
        }

        public bool ValidarAreaEmpleado()
        {
            if (cmbAreaEmpleado.SelectedIndex == -1)
            {
                errAreaEmpleado.SetError(cmbAreaEmpleado, "Debe seleccionar un área para el empleado.");
                return false;
            }
            else
            {
                errAreaEmpleado.SetError(cmbAreaEmpleado, "");
                return true;
            }
        }






















        EmpleadoDAO dao = new EmpleadoDAO();





        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoDTO empleado = new EmpleadoDTO();

            empleado.IdEmpleado = int.Parse(mtbIdEmpleado.Text);
            empleado.Nombre = txtNombreEmpleado.Text;
            empleado.ApellidoPaterno = txtApellidoPaternoEmpleado.Text;
            empleado.ApellidoMaterno = txtApellidoMaternoEmpleado.Text;
            empleado.FechaNacimiento = dtpFechaNacimientoEmpleado.Value;
            if (!string.IsNullOrWhiteSpace(cmbSexoEmpleado.Text))
            {
                empleado.Sexo = cmbSexoEmpleado.Text[0];
            }
            empleado.Rfc = txtRfcEmpleado.Text;
            empleado.Telefono = txtTelefonoEmpleado.Text;
            switch (cmbEstatusEmpleado.Text.ToLower()) // lo pasamos todo a minúsculas 
            {
                case "activo":
                    empleado.Estatus = 1; // 🔢 CÓDIGO QUE TÚ DEFINES
                    break;
                case "suspendido":
                    empleado.Estatus = 2;
                    break;
                case "inactivo":
                    empleado.Estatus = 3;
                    break;
                default:
                    MessageBox.Show("Estatus no reconocido");
                    return; // ❌ DETIENE SI ES ALGO QUE NO TIENES DEFINIDO
            }
            empleado.Sueldo = Convert.ToDouble(nudSueldoEmpleado.Text);
            empleado.Area = cmbAreaEmpleado.Text;




            if (dao.Actualizar(empleado))
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
            mtbIdEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoPaternoEmpleado.Clear();
            txtApellidoMaternoEmpleado.Clear();
            dtpFechaNacimientoEmpleado.Value = DateTime.Now;
            cmbSexoEmpleado.SelectedIndex = -1;
            txtRfcEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            cmbEstatusEmpleado.SelectedIndex = -1;
            nudSueldoEmpleado.Clear();
            cmbAreaEmpleado.SelectedItem = -1;

        }
        private void CargarDatos()
        {
            dgvEmpleado.DataSource = dao.ObtenerTodos();

            dgvAuditorias.DataSource = dao.MostrarAuditorias();
        }
        private void btnInsertarEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoDTO empleado = new EmpleadoDTO();

            empleado.IdEmpleado = long.Parse(mtbIdEmpleado.Text);
            empleado.Nombre = txtNombreEmpleado.Text;
            empleado.ApellidoPaterno = txtApellidoPaternoEmpleado.Text;
            empleado.ApellidoMaterno = txtApellidoMaternoEmpleado.Text;
            empleado.FechaNacimiento = dtpFechaNacimientoEmpleado.Value;
            if (!string.IsNullOrWhiteSpace(cmbSexoEmpleado.Text))
            {
                empleado.Sexo = cmbSexoEmpleado.Text[0];
            }
            empleado.Rfc = txtRfcEmpleado.Text;
            empleado.Telefono = txtTelefonoEmpleado.Text;
            switch (cmbEstatusEmpleado.Text.ToLower()) // lo pasamos todo a minúsculas para que no falle
            {
                case "activo":
                    empleado.Estatus = 1; // 🔢 CÓDIGO QUE TÚ DEFINES
                    break;
                case "suspendido":
                    empleado.Estatus = 2;
                    break;
                case "inactivo":
                    empleado.Estatus = 3;
                    break;
                default:
                    MessageBox.Show("Estatus no reconocido");
                    return; // ❌ DETIENE SI ES ALGO QUE NO TIENES DEFINIDO
            }
            empleado.Sueldo = Convert.ToDouble(nudSueldoEmpleado.Text);
            empleado.Area = cmbAreaEmpleado.Text;


            if (dao.Insertar(empleado))
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

        private void pnlPantallaEmpleado_Paint(object sender, PaintEventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            int id = int.Parse(mtbIdEmpleado.Text);




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

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
            EmpleadoDAO dao = new EmpleadoDAO();

            if (string.IsNullOrWhiteSpace(txtBuscarEmpleado.Text))
            {
                dgvEmpleado.DataSource = dao.ObtenerTodos();
            }
            else
            {
                dgvEmpleado.DataSource = dao.BuscarEmpleado(txtBuscarEmpleado.Text);
            }



            if (string.IsNullOrWhiteSpace(txtBuscarEmpleado.Text))
            {
                dgvAuditorias.DataSource = dao.MostrarAuditorias();
            }
            else
            {
                dgvAuditorias.DataSource = dao.BuscarAuditorias(txtBuscarEmpleado.Text);
            }
            
        }

        private void pnlControlesEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbAreaEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //------------------------







    }
}
