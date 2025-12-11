namespace talentoapi.Infraestructura;
using talentoapi.Dominio;


class DeporteRepository
{
   

    private List<Deporte> deportes = new List<Deporte>
    {
        new Deporte { Id = 1, Nombre = "Fútbol", Descripcion = "Deporte de equipo jugado entre dos conjuntos de once jugadores cada uno.", Tipo = "Equipo", ImagenUrl = "https://example.com/futbol.jpg" },
        new Deporte { Id = 2, Nombre = "Baloncesto", Descripcion = "Deporte de equipo en el que dos conjuntos de cinco jugadores intentan anotar puntos lanzando una pelota a través del aro del equipo contrario.", Tipo = "Equipo", ImagenUrl = "https://example.com/baloncesto.jpg" },
        new Deporte { Id = 3, Nombre = "Natación", Descripcion = "Deporte que consiste en desplazarse en el agua utilizando los brazos y las piernas.", Tipo = "Individual", ImagenUrl = "https://example.com/natacion.jpg" },
        new Deporte { Id = 4, Nombre = "Atletismo", Descripcion = "Conjunto de disciplinas deportivas que incluyen carreras, saltos y lanzamientos.", Tipo = "Individual", ImagenUrl = "https://example.com/atletismo.jpg" },
        new Deporte { Id = 5, Nombre = "Tenis", Descripcion = "Deporte que se juega entre dos jugadores (individual) o dos parejas (dobles) que golpean una pelota con una raqueta sobre una red.", Tipo = "Individual/Dobles", ImagenUrl = "https://example.com/tenis.jpg" },
        new Deporte { Id = 6, Nombre = "Ciclismo", Descripcion = "Deporte que consiste en montar en bicicleta, ya sea en carretera, montaña o pista.", Tipo = "Individual/Equipo", ImagenUrl = "https://example.com/ciclismo.jpg" }
    };
    public List<Deporte> getDeportes()
    {
        return deportes;
    }   

    public Deporte getDeporteById(int id)
    {
        return deportes.FirstOrDefault(d => d.Id == id);
    }

    public void addDeporte(Deporte deporte)
    {
        deportes.Add(deporte);
    }

    public void updateDeporte(Deporte deporte)
    {
        var existingDeporte = deportes.FirstOrDefault(d => d.Id == deporte.Id);
        if (existingDeporte != null)
        {
            existingDeporte.Nombre = deporte.Nombre;
            existingDeporte.Descripcion = deporte.Descripcion;
            existingDeporte.Tipo = deporte.Tipo;
            existingDeporte.ImagenUrl = deporte.ImagenUrl;
        }
    }

    public void deleteDeporte(int id)
    {
        var deporte = deportes.FirstOrDefault(d => d.Id == id);
        if (deporte != null)
        {
            deportes.Remove(deporte);
        }
    }
}