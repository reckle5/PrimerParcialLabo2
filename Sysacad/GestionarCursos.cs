using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Sysacad
{
    public partial class GestionarCursos : Form
    {
        private Administrador _admin;

        private string cursoSeleccionado;
        private int opcionElegida;

        public GestionarCursos()
        {
            InitializeComponent();
            _admin = new Administrador("reckle5", "1234", "Carolina Gonzalez", "gonzalezpcarolinabelen@gmail.com");

        }

        private static void SetFontForCheckedRadioButton(object sender)
        {
            System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)sender;

            if (radioButton.Checked)
            {
                // Cambia la fuente del texto cuando el RadioButton se selecciona
                radioButton.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            }
            else
            {
                // Restaura la fuente original cuando el RadioButton no está seleccionado
                radioButton.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void RadioButtonInfo_CheckedChanged(object sender, EventArgs e)
        {
            SetFontForCheckedRadioButton(sender);
            opcionElegida = 0;
        }
        private void RadioButtonEditar_CheckedChanged(object sender, EventArgs e)
        {
            SetFontForCheckedRadioButton(sender);
            opcionElegida = 1;
        }

        private void RadioButtonEliminar_CheckedChanged(object sender, EventArgs e)
        {
            SetFontForCheckedRadioButton(sender);
            opcionElegida = 2;
        }

        private void GestionarCursos_Load(object sender, EventArgs e)
        {
            if (_admin._listaCursos != null)
            {
                foreach (Curso curso in _admin._listaCursos)
                {
                    comboBoxCursos.Items.Add(curso.NombreCurso.ToString());
                }
            }
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            AgregarCurso formsAgregarCurso = new(ref _admin);
            formsAgregarCurso.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (opcionElegida)
            {
                case 0:
                    InfoCurso formInfo = new(ref _admin, cursoSeleccionado);
                    formInfo.Show();
                    this.Hide();
                    break;
                case 1:
                    EditarCurso formEditar = new(ref _admin, cursoSeleccionado);
                    formEditar.Show();
                    this.Hide();
                    break;
                case 2:
                    DialogResult respuesta = MessageBox.Show($"Esta seguro que quiere eliminar el curso: {cursoSeleccionado}", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        bool cursoEliminado = _admin.EliminarCurso(cursoSeleccionado);
                        if (cursoEliminado)
                        {
                            MessageBox.Show($"Curso: {cursoSeleccionado} eliminado correctamente", "Confimacion", MessageBoxButtons.OK);
                            comboBoxCursos.Items.Remove(cursoSeleccionado);
                        }
                        else
                        {
                            MessageBox.Show($"Curso: {cursoSeleccionado}no pudo ser eliminado", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cursoSeleccionado = comboBoxCursos.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelAdministracion panelAdmin = new PanelAdministracion();

            panelAdmin.ShowDialog();
            this.Close();
        }
    }
}