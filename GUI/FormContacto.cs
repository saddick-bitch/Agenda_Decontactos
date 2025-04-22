using BLL;
using EL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormContacto : Form
    {
        private readonly ContactoBLL contactoBLL = new ContactoBLL();
        private readonly TipoContactoBLL tipoContactoBLL = new TipoContactoBLL();

        public FormContacto()
        {
            InitializeComponent();
        }

        private void FormContacto_Load(object sender, EventArgs e)
        {
            CargarTiposContacto();
            CargarContactos();
        }

        private void CargarTiposContacto()
        {
            var tipos = tipoContactoBLL.ObtenerTodos();
            cmbTipoContacto.DataSource = tipos;
            cmbTipoContacto.DisplayMember = "Nombre";
            cmbTipoContacto.ValueMember = "Id";
        }

        private void CargarContactos()
        {
            var lista = contactoBLL.ObtenerTodos();
            dgvContactos.DataSource = null;
            dgvContactos.DataSource = lista;

            if (dgvContactos.Columns.Contains("TipoContacto"))
                dgvContactos.Columns["TipoContacto"].Visible = false;
            if (dgvContactos.Columns.Contains("Direcciones"))
                dgvContactos.Columns["Direcciones"].Visible = false;
            if (dgvContactos.Columns.Contains("ContactoEtiquetas"))
                dgvContactos.Columns["ContactoEtiquetas"].Visible = false;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbTipoContacto.SelectedIndex = 0;
            dgvContactos.ClearSelection();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            var contacto = new Contacto
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                TipoContactoId = Convert.ToInt32(cmbTipoContacto.SelectedValue)
            };

            try
            {
                if (contactoBLL.Insertar(contacto))
                {
                    MessageBox.Show("Contacto guardado exitosamente.");
                    Limpiar();
                    CargarContactos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un contacto para eliminar.");
                return;
            }

            var fila = dgvContactos.SelectedRows[0];
            var contacto = fila.DataBoundItem as Contacto;

            if (contacto == null) return;

            var confirmar = MessageBox.Show($"¿Eliminar a {contacto.Nombre} {contacto.Apellido}?",
                "Confirmar", MessageBoxButtons.YesNo);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    if (contactoBLL.Eliminar(contacto.Id))
                    {
                        MessageBox.Show("Contacto eliminado.");
                        CargarContactos();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
