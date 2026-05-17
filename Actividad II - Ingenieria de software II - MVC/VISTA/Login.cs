using Actividad_II___Ingenieria_de_software_II___MVC.CONTROLADOR;
using Actividad_II___Ingenieria_de_software_II___MVC.VISTA;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Actividad_II___Ingenieria_de_software_II___MVC
{
    public partial class Login : Form
    {

        private LoginController _controller;

        public Login()
        {
            InitializeComponent();
            _controller = new LoginController(); // Instanciar el controlador
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Le pedimos al controlador que haga el trabajo pesado
            string resultado = _controller.IniciarSesion(UserBox.Text, PassBox.Text);

            switch (resultado)
            {
                case "CAMPOS_VACIOS":
                    MessageBox.Show("Por favor, complete todos los campos.");
                    break;
                case "INCORRECTO":
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    break;
                case "Administrador":
                    this.Hide();
                    Admin AdminForm = new Admin();
                    AdminForm.Show();
                    break;
                case "Profesor":
                    this.Hide();
                    Teacher TeacherForm = new Teacher();
                    TeacherForm.Show();
                    break;
                case "Estudiante":
                    this.Hide();
                    Student StudentForm = new Student();
                    StudentForm.Show();
                    break;
                default:
                    // Captura errores de base de datos o roles no autorizados
                    if (resultado.StartsWith("ERROR:"))
                        MessageBox.Show(resultado);
                    else
                        MessageBox.Show("Usuario no autorizado");
                    break;
            }
        }
    }
}
