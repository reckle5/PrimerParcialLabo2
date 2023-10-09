using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pagos
    {
        public bool Matricula { get; set; }
        public bool CargosAdministrativos { get; set; }
        public bool CuotaMesActual { get; set; }

        public Pagos(bool matricula, bool cargosAdmim, bool cuota)
        {
            Matricula = matricula;
            CargosAdministrativos = cargosAdmim;
            CuotaMesActual = cuota;
        }
    }

}
