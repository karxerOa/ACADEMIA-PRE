using Biblioteca;
using Biblioteca.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACADEMIA_PRE.PanelesAdmin
{
    public partial class PanelRegistrarEstudiante : Form
    {

        public PanelRegistrarEstudiante()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {           
            Carrera carreraSeleccionada = (Carrera)comboxCarrera.SelectedItem;
            lblArea.Text = carreraSeleccionada.Area.Tipo_area;           
        }
        private void llenarCombo() {
            ControladorCarreras controlador = new ControladorCarreras(ConexionBD.CadenaConexion);
            List<Carrera> carreras = controlador.ObtenerCarreras();

            comboxCarrera.DataSource = carreras;
            comboxCarrera.DisplayMember = "Nombre_carrera"; 
            comboxCarrera.ValueMember = "Id_carrera";
        }
        private void PanelRegistrarEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Preparar el usuario
                Usuario usuario = new Usuario
                {
                    User = txtUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Rol = "Estudiante"
                };

                // 2. Insertar usuario y obtener ID
                ControladorUsuario controlUsuario = new ControladorUsuario(ConexionBD.CadenaConexion);
                string idUsuario = controlUsuario.InsertarUsuario(usuario.User, usuario.Contraseña, usuario.Rol);

                if (string.IsNullOrEmpty(idUsuario))
                {
                    MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                usuario.Id_usuario = idUsuario;

                // 3. Crear apoderado si aplica
                Apoderado apoderado = null;
                if (rbSíApoderado.Checked)
                {
                    apoderado = new Apoderado
                    {
                        nombre_apoderado = txtApoderado.Text,
                        telefono_apoderado = txtCelular.Text
                    };

                    ControladorApoderado controlApod = new ControladorApoderado(ConexionBD.CadenaConexion);
                    string idApoderado = controlApod.InsertarApoderado(apoderado).ToString();

                    if (idApoderado == "")
                    {
                        MessageBox.Show("Error al registrar apoderado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    apoderado.Id_apoderado = idApoderado;
                }

                // 4. Crear estudiante
                Estudiante estudiante = new Estudiante
                {
                    Usuario = usuario,
                    Carrera = (Carrera)comboxCarrera.SelectedItem,
                    Nombre = txtNombreEst.Text,
                    ApellidoPaterno = txtApePaEs.Text,
                    ApellidoMaterno = txtApeMaEst.Text,
                    Edad = int.Parse(txtEdadEst.Text),
                    DNI = txtDNIest.Text,
                    Telefono = txtNumEst.Text,
                    Apoderado = apoderado // puede ser null
                };

                ControladorEstudiante controlEst = new ControladorEstudiante(ConexionBD.CadenaConexion);

                if (!controlEst.InsertarEstudiante(estudiante))
                {
                    // Eliminamos el usuario si falló el estudiante
                    controlUsuario.EliminarUsuario(idUsuario);
                    MessageBox.Show("Error al registrar el estudiante. Se canceló el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbSíApoderado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSíApoderado.Checked)
            {
                txtApoderado.Enabled = true;
                txtCelular.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbNoApoderado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoApoderado.Checked)
            {
                txtApoderado.Text = "";
                txtCelular.Text = "";
                txtApoderado.Enabled = false;
                txtCelular.Enabled = false;
            }
        }
        private void LimpiarCampos()
        {
            txtNombreEst.Text = "";
            txtApePaEs.Text = "";
            txtApeMaEst.Text = "";
            txtEdadEst.Text = "";
            txtDNIest.Text = "";
            txtNumEst.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtApoderado.Text = "";
            txtCelular.Text = "";
            comboxCarrera.SelectedIndex = 0;
            rbNoApoderado.Checked = true;
        }

    }
}