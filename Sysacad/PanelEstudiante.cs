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
    public partial class PanelEstudiante : Form
    {
        private Estudiante estudiante;
        private Administrador administrador;
        public PanelEstudiante(ref Estudiante alumno, ref Administrador admin)
        {
            InitializeComponent();
            estudiante = alumno;
            administrador = admin;

        }

        private void PanelEstudiante_Load(object sender, EventArgs e)
        {
            if (estudiante.cambiarPass)
            {
                CambiarContraseña cambiarPass = new(ref estudiante, ref administrador);
                this.Hide();
                cambiarPass.ShowDialog();
            }
        }

        private void lblInscripcion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InscripcionCurso inscripciones = new(ref estudiante, ref administrador);
            inscripciones.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConsultarHorario horario = new(ref estudiante, ref administrador);
            horario.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PagosPendientes pagos = new(ref estudiante);
            pagos.Show();
            this.Hide();
        }
    }
}
