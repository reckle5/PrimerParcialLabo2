using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Administrador : Usuario
    {
        public string NombreCompleto { get; set; }
        public string Mail { get; set; }

     
        public List<Estudiante> _listaEstudiantes;
        public List<Curso> _listaCursos;

        public Administrador(string user, string password, string nombre, string mail) : base(user, password)
        {
            this.NombreCompleto = nombre;
            this.Mail = mail;
            _listaEstudiantes = Archivos.ReadStreamJson<Estudiante>("Archivo Estudiantes.json") ?? new List<Estudiante>();
            _listaCursos = Archivos.ReadStreamJson<Curso>("Archivo Curso.json") ?? new List<Curso>();
        }
        public bool ExisteEstudiante(Estudiante estudiante)
        {
            
            if (_listaEstudiantes == estudiante)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegistrarEstudiante(Estudiante estudiante)
        {
            if (_listaEstudiantes.Count == 0)
            {
                estudiante.Legajo = 1;
            }
            else
            {

                estudiante.Legajo = _listaEstudiantes[_listaEstudiantes.Count-1].Legajo + 1;
            }
           _listaEstudiantes.Add(estudiante);
            Archivos.WriteStreamJson("Archivo Estudiantes.json", _listaEstudiantes);
        }

        public void CambiarPasswordEstudiante(Estudiante estudiante,string eleccion)
        {
            estudiante.cambiarPass = eleccion == "si";
        }

        public void CrearCurso(Curso curso)
        {
            if (!ExisteCurso(curso))
            {
                _listaCursos.Add(curso);
                Archivos.WriteStreamJson("Archivo Curso.json", _listaCursos);
            }
        }

        public bool ExisteCurso(Curso curso)
        {
            if (_listaCursos == curso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCurso(string cursoSeleccionado)
        {
            Curso cursoAEliminar = _listaCursos.Find(curso => curso.NombreCurso == cursoSeleccionado);

            if (cursoAEliminar != null)
            {
                _listaCursos.Remove(cursoAEliminar);
                
                Archivos.WriteStreamJson("archivo curso.json", _listaCursos);
                return true;
            }
            else
            {
                return false;
            }
        }

      
        
    }
}

