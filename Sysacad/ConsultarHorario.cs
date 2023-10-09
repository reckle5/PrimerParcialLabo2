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
    public partial class ConsultarHorario : Form
    {
        private Estudiante estudiante;
        private Administrador administrador;
        private ListViewGroup? materias;

        public ConsultarHorario(ref Estudiante alumno, ref Administrador admin)
        {
            InitializeComponent();
            estudiante = alumno;
            administrador = admin;
        }

        private void ConsultarHorario_Load(object sender, EventArgs e)
        {
            if (estudiante.listaMisCursos != null)
            {
                foreach (Curso materia in estudiante.listaMisCursos)
                {
                    materias = new ListViewGroup(materia.NombreCurso, HorizontalAlignment.Left);

                    listView1.Items.Add(new ListViewItem($"Codigo: {materia.CodigoCurso.ToString()}", materias));
                    listView1.Items.Add(new ListViewItem($"Descripcion: {materia.Descripcion}", materias));
                    listView1.Items.Add(new ListViewItem($"Carga Horaria: {materia.CargaHoraria.ToString()}", materias));
                    listView1.Items.Add(new ListViewItem($"Dia de cursada: {materia.Dia.ToString()}", materias));
                    listView1.Items.Add(new ListViewItem($"Turno: {materia.ObtenerDescripcionTurno(estudiante.HorarioCursada.ToString())}", materias));
                    listView1.Items.Add(new ListViewItem($"Turno: {materia.Aula}", materias));


                    listView1.Groups.Add(materias);
                }
            }
            else
            {
                MessageBox.Show("no esta inscrito a ninguna materia");

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            PanelEstudiante panelEstudiante = new(ref estudiante, ref administrador);
            panelEstudiante.Show();
            this.Hide();
        }
    }
}
