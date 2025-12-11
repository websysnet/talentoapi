namespace talentoapi.Infraestructura
{
    using System.Linq.Expressions;
    using System.Collections.Generic;
    using talentoapi.Dominio;
    using System.Security.Cryptography.X509Certificates;

    public class EntrenadorRepository
    {
        private List<Entrenador> entrenadores = new List<Entrenador>
        {
           new Entrenador
           {
               Id = 1,
               Nombres = "Juan",
               Apellidos = "Perez",
               Nivel = "Avanzado",
               Deporte = new Deporte { Id = 1, Nombre = "Futbol" },
               LugarEntrenamiento = "Estadio Nacional",
               Horario = "Lunes a Viernes 6am-8am",
               Experiencia = "10 años entrenando equipos juveniles",
               imagenUrl = "http://example.com/juan.jpg"
           },
           new Entrenador
           {
                Id = 2,
                Nombres = "Maria",
                Apellidos = "Gomez",
                Nivel = "Intermedio",
                Deporte = new Deporte { Id = 2, Nombre = "Natacion" },
                LugarEntrenamiento = "Piscina Municipal",
                Horario = "Martes y Jueves 5pm-7pm",
                Experiencia = "5 años entrenando nadadores competitivos",
                imagenUrl = "http://example.com/maria.jpg"
           }, 
           new Entrenador
           {
                Id = 3,
                Nombres = "Carlos",
                Apellidos = "Lopez",
                Nivel = "Principiante",
                Deporte = new Deporte { Id = 3, Nombre = "Tenis" },
                LugarEntrenamiento = "Club de Tenis Central",
                Horario = "Sabados 9am-11am",
                Experiencia = "3 años entrenando jugadores recreativos",
                imagenUrl = "http://example.com/carlos.jpg"
           }
        };

        public  List<Entrenador> GetEntrenadores()
        {
                 
            return entrenadores;
        }

        public async Task<Entrenador?> GetById(int id)
        {
            return  entrenadores.FirstOrDefault(e => e.Id == id);
        }
        public  void AddEntrenador(Entrenador entrenador)
        {
            entrenadores.Add(entrenador);
        }

        public void UpdateEntrenador(Entrenador entrenador)
        {
            var existingEntrenador = entrenadores.FirstOrDefault(e => e.Id == entrenador.Id);
            if (existingEntrenador != null)
            {
                existingEntrenador.Nombres = entrenador.Nombres;
                existingEntrenador.Apellidos = entrenador.Apellidos;
                existingEntrenador.Nivel = entrenador.Nivel;
                existingEntrenador.Deporte = entrenador.Deporte;
                existingEntrenador.LugarEntrenamiento = entrenador.LugarEntrenamiento;
                existingEntrenador.Horario = entrenador.Horario;
                existingEntrenador.Experiencia = entrenador.Experiencia;
                existingEntrenador.imagenUrl = entrenador.imagenUrl;
            }
        }

        public void DeleteEntrenador(int id)
        {
            var entrenadorToRemove = entrenadores.FirstOrDefault(e => e.Id == id);
            if (entrenadorToRemove != null)
            {
                entrenadores.Remove(entrenadorToRemove);
            }
        }

        
    }
    
}