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
    public partial class InfoCurso : Form
    {
        private Administrador administrador;
        private string cursoSeleccionado;

        public InfoCurso(ref Administrador _admin, string curso)
        {
            InitializeComponent();
            administrador = _admin;
            cursoSeleccionado = curso;
        }

        private void InfoCurso_Load(object sender, EventArgs e)
        {
            foreach (Curso curso in administrador._listaCursos)
            {
                if (curso.NombreCurso.Equals(cursoSeleccionado))
                {
                    lblNombreCurso.Text = curso.NombreCurso;
                    lblCodigoCurso.Text = curso.CodigoCurso.ToString();
                    lblDescripcionCurso.Text = curso.Descripcion;
                    lblCupoCurso.Text = curso.CupoMaximo.ToString();
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
