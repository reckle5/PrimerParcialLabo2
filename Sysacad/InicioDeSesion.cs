using Biblioteca;

namespace Sysacad
{
    public partial class InicioDeSesion : Form
    {

        private Administrador administrador;
        private Estudiante estudiante;

        public InicioDeSesion()
        {
            InitializeComponent();
            administrador = new Administrador("reckle5", "1234", "Carolina Gonzalez", "gonzalezpcarolinabelen@gmail.com");
            estudiante = new Estudiante();

        }

        private void IniciarSesion(string usuario, string contraseņa)
        {
            bool ingresoExitoso = false;

            if (administrador.LogIn(administrador, usuario, contraseņa))
            {
                PanelAdministracion panelAdmin = new();
                panelAdmin.Show();
                this.Hide();
                ingresoExitoso = true;
            }
            else
            {
                foreach (Estudiante alumno in administrador._listaEstudiantes)
                {

                    if (alumno.LogIn(alumno, usuario, contraseņa))
                    {
                        estudiante = alumno;
                        PanelEstudiante panelEstudiante = new(ref estudiante, ref administrador);
                        panelEstudiante.Show();
                        this.Hide();
                        ingresoExitoso = true;
                    }
                }
            }
            if (!ingresoExitoso)
            {
                MessageBox.Show("Usuario o Contraseņa incorrectos!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String ingresoUsuario = textBoxUsuario.Text.ToLower();
            String ingresoContraseņa = textBoxPassword.Text.ToLower();

            IniciarSesion(ingresoUsuario, ingresoContraseņa);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "Reckle5";
            textBoxPassword.Text = "1234";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "caro@gmail.com";
            textBoxPassword.Text = "1234";
        }
    }

}