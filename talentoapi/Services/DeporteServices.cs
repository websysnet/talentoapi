namespace talentoapi.Services;

using talentoapi.Dominio;
using talentoapi.Infraestructura;

public class DeporteServices
{
    private readonly DeporteRepository _deporteRepository;

    public DeporteServices()
    {
        _deporteRepository = new DeporteRepository();
    }

    public List<Deporte> GetDeportes()
    {
        return _deporteRepository.getDeportes();
    }

    public Deporte GetDeporteById(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("El ID del deporte no puede ser menor o igual a cero.");
        }
        else
        {
            var deporte = _deporteRepository.getDeporteById(id);
            if (deporte == null)
            {
                throw new KeyNotFoundException($"No se encontró ningún deporte con el ID {id}.");
            }
            return deporte;
        }


    }

    public void AddDeporte(Deporte deporte)
    {
        _deporteRepository.addDeporte(deporte);
    }

    public void UpdateDeporte(Deporte deporte)
    {
        _deporteRepository.updateDeporte(deporte);
    }

    public void DeleteDeporte(int id)
    {
        _deporteRepository.deleteDeporte(id);
    }
}
