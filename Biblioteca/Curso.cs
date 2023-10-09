using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Curso
    {

        public string NombreCurso { get; set; }
        public int CodigoCurso { get; set; }
        public string Descripcion { get; set; }
        public int CupoMaximo { get; set; }
        public int CargaHoraria { get; set; }
        public string Dia { get; set; }
        public int Aula { get; set; }

        public List<int> CodigosCursos = new List<int>();

        Random generadorAleatorio = new Random();
        public enum Turnos
        {
            Mañana,
            Tarde,
            Noche 

        }


        public Curso(string nombreCurso, string descripcion, int cupoMaximo)
        {
            NombreCurso = nombreCurso;
            CodigoCurso = GenerarCodigoCurso();
            Descripcion = descripcion;
            CupoMaximo = cupoMaximo;
        }

        public int GenerarCodigoCurso()
        {
            int codigoGenerado;

            do
            {
                codigoGenerado = generadorAleatorio.Next(100, 999);
            } while (CodigosCursos.Contains(codigoGenerado));

            CodigosCursos.Add(codigoGenerado);
            return codigoGenerado;
        }

        public override bool Equals(object obj)
        {
            if (obj is Curso otherCurso)
            {
                return NombreCurso == otherCurso.NombreCurso;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return NombreCurso.GetHashCode();
        }
        public static bool operator ==(List<Curso> listaCursos, Curso curso)
        {
            if (listaCursos == null)
            {
                return false;
            }

            return listaCursos.Contains(curso);

        }

        public static bool operator !=(List<Curso> listaCursos, Curso curso)
        {
            return !(listaCursos == curso);
        }

        public bool HayCupo()
        {
            if (this.CupoMaximo > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GenerarHorario()
        {
            this.CargaHoraria = generadorAleatorio.Next(2, 4);

            DayOfWeek[] diasDeLaSemana = (DayOfWeek[])Enum.GetValues(typeof(DayOfWeek));
            // Seleccionar un día aleatorio de la semana
            DayOfWeek diaAleatorio = diasDeLaSemana[generadorAleatorio.Next(diasDeLaSemana.Length)];

            this.Dia = diaAleatorio.ToString();
        }

        public void GenerarAula()
        {
            this.Aula = generadorAleatorio.Next(100, 200);
        }

        public  string ObtenerDescripcionTurno(string turno)
        {
            switch (turno)
            {
                case "Mañana":
                    return "8-12";
                case "Tarde":
                    return "13-17";
                case "Noche":
                    return "18-22";
                default:
                    return "Desconocido";
            }
        }
    }
}
