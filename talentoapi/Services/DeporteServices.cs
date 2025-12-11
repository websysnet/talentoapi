namespace talentoapi.Services;
using talentoapi.Dominio;
using talentoapi.Infraestructura;

class DeporteServices
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

    public Deporte GetDeporteById(int id){
        return _deporteRepository.getDeporteById(id);
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
