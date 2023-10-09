using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante : Usuario
    {
        public string NombreCompleto { get; set; }
        public string Mail { get; set; }
        public int Dni{ get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Legajo { get; set; }
        public string HorarioCursada { get; set; }
        public bool cambiarPass { get; set; }
        public Pagos PagosEstudiante { get; set; }

        public List<Curso> listaMisCursos;


        public Estudiante(string user, string password, string nombre, string mail, int dni, string direccion,int telefono) : base(user, password)
        {
            this.NombreCompleto = nombre;
            this.Mail = mail;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            listaMisCursos = Archivos.ReadStreamJson<Curso>($"CursosEstudiante_{this.Dni}.json") ?? new List<Curso>();
            PagosEstudiante = new Pagos(false, false, false);
        }

        public Estudiante() :base("","")
        {
            listaMisCursos = Archivos.ReadStreamJson<Curso>($"CursosEstudiante_{this.Dni}.json") ?? new List<Curso>();

        }


        public static bool operator ==(List<Estudiante> listaEstudiantes, Estudiante alumno)
        {
            foreach (Estudiante i in listaEstudiantes)
            {
                if ((i.Dni, i.Mail) == (alumno.Dni, alumno.Mail))
                {
                    return true; 
                }
            }
            return false;

        }

        public static bool operator !=(List<Estudiante> listaEstudiantes, Estudiante alumno)
        {
            return !(listaEstudiantes == alumno);
        }

        public void PrimerInicioDeSesion(string nuevaContraseña)
        {
            if (cambiarPass)
            {
                this.Password = nuevaContraseña;
                cambiarPass = false;
            }
        }

        public static implicit operator Estudiante(string estudiante)
        {
            var datos = estudiante.Split('-');

            return new Estudiante(datos[0], datos[1], datos[2], datos[3], int.Parse(datos[4]), datos[5], int.Parse(datos[6]));
        }


        public bool AgregarCurso(Curso curso)
        {
            if (!ExisteCurso(curso))
            {
                listaMisCursos.Add(curso);
                curso.CupoMaximo -= 1;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ActualizarLista()
        {
            Archivos.WriteStreamJson($"CursosEstudiante_{this.Dni}.json", listaMisCursos);

        }

        public bool ExisteCurso(Curso curso)
        {
            if (listaMisCursos == curso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
