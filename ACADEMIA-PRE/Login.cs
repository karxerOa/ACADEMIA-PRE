using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ACADEMIA_PRE
{
    public partial class Login : Form
    {
        private string rolSeleccionado;
        public Login(string rol)
        {
            InitializeComponent();
            rolSeleccionado = rol;
            lblRol.Text = "Rol: " + rolSeleccionado;

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            ControladorUsuario controlador = new ControladorUsuario(ConexionBD.CadenaConexion);

            if (controlador.ValidarUsuario(nombre, contraseña, rolSeleccionado))
            {
                MessageBox.Show($"Bienvenido {nombre} - Rol: {rolSeleccionado}");

                if (rolSeleccionado == "Administrador")
                    new MenúAdmin().Show();
                else if (rolSeleccionado == "Docente")
                    new MenúDocente().Show();
                else
                    new MenúEstudiante().Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }

        private string ObtenerIdDocente(string nombreUsuario)
        {
            using (SqlConnection connection = new SqlConnection(ConexionBD.CadenaConexion))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_docente FROM Docente WHERE Nombre = @Nombre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombreUsuario);
                        object result = command.ExecuteScalar();
                        return result?.ToString() ?? "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener ID del docente: " + ex.Message);
                    return "";
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
