using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sysacad
{
    public partial class InscripcionCurso : Form
    {
        private Estudiante estudiante;
        private Administrador administrador;
        private ListViewGroup? materias;
        private bool inscripcionExitosa =  false;

        public InscripcionCurso(ref Estudiante alumno, ref Administrador admin)
        {
            InitializeComponent();
            estudiante = alumno;
            administrador = admin;

        }

        private void InscripcionCurso_Load(object sender, EventArgs e)
        {
            if (administrador._listaCursos.Count > 0)
            {
                foreach (Curso materia in administrador._listaCursos)
                {
                    materias = new ListViewGroup(materia.NombreCurso, HorizontalAlignment.Left);

                    listView1.Items.Add(new ListViewItem($"Codigo: {materia.CodigoCurso.ToString()}", materias));
                    listView1.Items.Add(new ListViewItem($"Descripcion: {materia.Descripcion}", materias));
                    listView1.Items.Add(new ListViewItem($"Cupo Maximo: {materia.CupoMaximo.ToString()}", materias));

                    listView1.Groups.Add(materias);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string nombreCursoSeleccionado = selectedItem.Group.Header;

                lblCursoSeleccionado.Visible = true;
                lblCursoSeleccionado.Text = nombreCursoSeleccionado;
            }
        }

        private void btnIncribirse_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string nombreCursoSeleccionado = selectedItem.Group.Header;

                foreach (Curso materia in administrador._listaCursos)
                {
                    bool cursoCoincide = nombreCursoSeleccionado.Equals(materia.NombreCurso);
                    bool hayCupo = materia.HayCupo();

                    if (hayCupo)
                    {

                        if (cursoCoincide && estudiante.AgregarCurso(materia))
                        {
                            estudiante.ActualizarLista();
                            Archivos.WriteStreamJson("Archivo Curso.json", administrador._listaCursos);
                            MessageBox.Show($"Registro Exitoso a {materia.NombreCurso}", "Confirmacion!", MessageBoxButtons.OK);
                            inscripcionExitosa = true;
                            break;
                        }
                    }
                    if(!hayCupo)
                    {
                        MessageBox.Show($"El cupo para {materia.NombreCurso} ya esta completo", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                }

                if (!inscripcionExitosa)
                {
                    MessageBox.Show($"Error al inscribirse a la materia", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            PanelEstudiante panelEstudiante = new(ref estudiante, ref administrador);
            panelEstudiante.Show();
            this.Hide();
        }
    }
}
