using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Sysacad
{
    public partial class RegistrarEstudiante : Form
    {
        private Administrador _admin;
        private Estudiante _nuevoEstudiante;

        public RegistrarEstudiante()
        {
            InitializeComponent();
            _nuevoEstudiante = new Estudiante();
            _admin = new Administrador("reckle5", "1234", "Carolina Gonzalez", "gonzalezpcarolinabelen@gmail.com");
        }

        private Estudiante? CrearEstudiante()
        {
            _nuevoEstudiante.User = txtBoxUsuario.Text.ToLower();
            _nuevoEstudiante.Password = txtBoxContraseña.Text.ToLower();
            _nuevoEstudiante.NombreCompleto = txtBoxNombreCompleto.Text.ToUpper();
            _nuevoEstudiante.Mail = txtBoxMail.Text.ToLower();
            _nuevoEstudiante.Direccion = txtBoxdireccion.Text.ToLower();
            _nuevoEstudiante.HorarioCursada = comboBox1.SelectedItem.ToString();
            bool conversionExitosa = true;
            try
            {
                _nuevoEstudiante.Dni = int.Parse(txtBoxDni.Text);
                _nuevoEstudiante.Telefono = int.Parse(txtBoxTelefono.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("El campo DNI y Telefono solo acepta numeros", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conversionExitosa = false;
            }

            if (conversionExitosa)
            {

                return _nuevoEstudiante;
            }
            else
            {
                return null;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (_nuevoEstudiante != null)
            {
                CrearEstudiante();

                if (_admin.ExisteEstudiante(_nuevoEstudiante))
                {
                    MessageBox.Show("El alumno ya se encuentra registrado", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarFormulario();
                }
                else
                {
                    _admin.RegistrarEstudiante(_nuevoEstudiante);
                    MessageBox.Show("Alumno registrado correctamente", "Confirmacion!", MessageBoxButtons.OK);
                    PanelAdministracion panelAdmin = new();
                    panelAdmin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El alumno no pudo ser registrado, vuelva a intentarlo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarFormulario();
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            PanelAdministracion panelAdmin = new PanelAdministracion();

            panelAdmin.ShowDialog();
            this.Close();
        }

        private void checkBoxSi_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNo.Enabled = !checkBoxSi.Checked;
            string eleccionCheckBox = "si";
            _admin.CambiarPasswordEstudiante(_nuevoEstudiante, eleccionCheckBox);
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSi.Enabled = !checkBoxNo.Checked;
            string eleccionCheckBox = "no";
            _admin.CambiarPasswordEstudiante(_nuevoEstudiante, eleccionCheckBox);
        }

        private void LimpiarFormulario()
        {
            txtBoxContraseña.Text = string.Empty;
            txtBoxdireccion.Text = string.Empty;
            txtBoxDni.Text = string.Empty;
            txtBoxMail.Text = string.Empty;
            txtBoxNombreCompleto.Text = string.Empty;
            txtBoxTelefono.Text = string.Empty;
            txtBoxUsuario.Text = string.Empty;

            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{_admin._listaEstudiantes.Count}");
        }


        private void RegistrarEstudiante_Load(object sender, EventArgs e)
        {
            Curso.Turnos[] cursada = (Curso.Turnos[])Enum.GetValues(typeof(Curso.Turnos));

            foreach (Curso.Turnos horarios in cursada)
            {
                comboBox1.Items.Add(horarios);
            }
        }
    }
}
