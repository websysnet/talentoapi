namespace talentoapi.Controllers
{
    using talentoapi.Dominio;
    using talentoapi.Services;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class EntrenadorServices
    {
        private readonly EntrenadorServices _entrenadorRepository;

        public EntrenadorServices()
        {
            _entrenadorRepository = new EntrenadorServices();
        }
        public List<Entrenador> GetEntrenadores()
        {
            return _entrenadorRepository.GetEntrenadores();
        }
        public async Task<Entrenador?> GetEntrenadorById(int id)
        {
            return await _entrenadorRepository.GetEntrenadorById(id);
        }
        public void CreateEntrenador(Entrenador entrenador)
        {
            _entrenadorRepository.CreateEntrenador(entrenador); 
        }
        public void DeleteEntrenador(int id)
        {
            _entrenadorRepository.DeleteEntrenador(id);
        }
        public void UpdateEntrenador(Entrenador entrenador)
        {
            _entrenadorRepository.UpdateEntrenador(entrenador);
        }
        
    }
}