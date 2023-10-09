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
    public partial class CambiarContraseña : Form
    {
        private Estudiante estudiante;
        private Administrador administrador;

        public CambiarContraseña(ref Estudiante alumno, ref Administrador admin)
        {
            InitializeComponent();
            estudiante = alumno;
            administrador = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtRepetirPassword.Text))
            {
                actualizarPass(txtRepetirPassword.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // return;
            }
        }

        private void actualizarPass(string nuevaPass)
        {
            foreach (Estudiante alumno in administrador._listaEstudiantes)
            {
                if (estudiante.Equals(alumno))
                {
                    estudiante.Password = nuevaPass;
                    estudiante.cambiarPass = false;
                    Archivos.WriteStreamJson("Archivo Estudiantes.json", administrador._listaEstudiantes);
                    MessageBox.Show("Cambios realizados correctamente", "Confirmación", MessageBoxButtons.OK);

                }
            }
        }

    }
}

