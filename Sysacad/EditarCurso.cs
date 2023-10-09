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

namespace Sysacad
{
    public partial class EditarCurso : Form
    {
        private Administrador administrador;

        private string cursoSeleccionado;
        private bool codigoRepetido;
        public EditarCurso(ref Administrador _admin, string curso)
        {
            InitializeComponent();

            administrador = _admin;

            cursoSeleccionado = curso;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool codigoRepetido = false;

                foreach (Curso curso in administrador._listaCursos)
                {
                    if (curso.NombreCurso.Equals(cursoSeleccionado))
                    {
                        int nuevoCodigoCurso;
                        int nuevoCupoCurso;

                        if (int.TryParse(txtBoxCodigo.Text, out nuevoCodigoCurso) && int.TryParse(txtBoxCupo.Text, out nuevoCupoCurso))
                        {
                            // Solo actualiza el código si la conversión es exitosa
                            curso.CodigoCurso = nuevoCodigoCurso;
                            curso.NombreCurso = txtBoxNombre.Text;
                            curso.Descripcion = txtBoxDescripcion.Text;
                            curso.CupoMaximo = nuevoCupoCurso;

                            // Verifica si hay códigos repetidos
                            foreach (Curso otroCurso in administrador._listaCursos)
                            {
                                if (otroCurso != curso && otroCurso.CodigoCurso == nuevoCodigoCurso)
                                {
                                    codigoRepetido = true;
                                    break; // Sal del bucle tan pronto como encuentres un duplicado
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código del curso no es válido, intenta nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }
                    }
                }

                if (!codigoRepetido)
                {
                    Archivos.WriteStreamJson("Archivo curso.json", administrador._listaCursos);

                    MessageBox.Show("Cambios realizados correctamente", "Confirmación", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El código del curso ya está en uso por otro curso, intenta nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           

        private void EditarCurso_Load(object sender, EventArgs e)
        {
            foreach (Curso curso in administrador._listaCursos)
            {
                if (curso.NombreCurso.Equals(cursoSeleccionado))
                {
                    txtBoxNombre.Text = curso.NombreCurso;
                    txtBoxCodigo.Text = curso.CodigoCurso.ToString();
                    txtBoxDescripcion.Text = curso.Descripcion;
                    txtBoxCupo.Text = curso.CupoMaximo.ToString();
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            GestionarCursos formGestionarCursos = new();
            formGestionarCursos.Show();
            this.Hide();
        }
    }
}
