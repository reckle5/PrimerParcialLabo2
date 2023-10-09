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
    public partial class PanelAdministracion : Form
    {
        public PanelAdministracion()
        {
            InitializeComponent();
        }

        private void lblResgistrarEstudiante_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrarEstudiante nuevoRegistro = new();
            nuevoRegistro.Show();
            this.Close();
        }

        private void lblCursos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GestionarCursos gestionarCursos = new();
            gestionarCursos.Show();
            this.Close();

        }
    }
}
