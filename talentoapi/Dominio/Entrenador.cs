namespace talentoapi.Dominio
{

    public class Entrenador
    {
        public int Id { get; set; }

        public string? Nombres { get; set; }

        public string? Apellidos { get; set; }

        public string? Nivel {get;set;}

        public Deporte? Deporte {get;set;}

        public string? LugarEntrenamiento {get;set;} 

        public string? Horario {get;set;}   

        public string? Experiencia {get;set;}

        public string? imagenUrl {get;set;}

    }
}
