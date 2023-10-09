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
    public partial class AgregarCurso : Form
    {

        private Administrador? administrador;
        private Curso nuevoCurso;
        public AgregarCurso(ref Administrador _admin)
        {
            InitializeComponent();
            administrador = _admin;
            nuevoCurso = new Curso("", "", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nuevoCurso.NombreCurso = txtBoxNombre.Text;
            nuevoCurso.Descripcion = txtBoxDescripcion.Text;
            nuevoCurso.CupoMaximo = int.Parse(txtBoxCupo.Text);
            nuevoCurso.GenerarHorario();
            nuevoCurso.GenerarAula();

            administrador.CrearCurso(nuevoCurso);
            MessageBox.Show("Curso creado Exitosamente!", "Confirmacion", MessageBoxButtons.OK);
            LimpiarFormulario();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionarCursos formGestionarCurso = new();
            formGestionarCurso.Show();
            this.Hide();
        }

        private void LimpiarFormulario()
        {
            txtBoxNombre.Text = string.Empty;
            txtBoxDescripcion.Text = string.Empty; 
            txtBoxCupo.Text = string.Empty;
        }
    }
}
