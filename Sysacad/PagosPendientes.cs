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
    public partial class PagosPendientes : Form
    {
        private Estudiante estudiante;
        private int PagoTotal = 0;
        private enum gastos
        {
            Matricula = 15000,
            Cuota = 20000,
            Materiales = 7000
        }
        public PagosPendientes(ref Estudiante alumno)
        {
            InitializeComponent();
            estudiante = alumno;
            dvgPagos.CellEndEdit += dvgPagos_CellEndEdit;
        }

        private void PagosPendientes_Load(object sender, EventArgs e)
        {
            int indice = dvgPagos.Rows.Add();
            dvgPagos.Rows[indice].Cells[0].Value = gastos.Matricula;
            dvgPagos.Rows[indice].Cells[1].Value = $"$ {(int)gastos.Matricula}";

            indice = dvgPagos.Rows.Add();
            dvgPagos.Rows[indice].Cells[0].Value = gastos.Cuota;
            dvgPagos.Rows[indice].Cells[1].Value = $"$ {(int)gastos.Cuota}";

            indice = dvgPagos.Rows.Add();
            dvgPagos.Rows[indice].Cells[0].Value = gastos.Materiales;
            dvgPagos.Rows[indice].Cells[1].Value = $"$ {(int)gastos.Materiales}";

          
        }
        private void dvgPagos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                object nuevoValor = dvgPagos.Rows[indice].Cells[2].Value;

                PagoTotal += Convert.ToInt32(nuevoValor);
            }
            if (PagoTotal > 0)
            {
                lblPagototal.Visible = true;
                lblPagototal.Text = PagoTotal.ToString();
            }


        }

    }
}

