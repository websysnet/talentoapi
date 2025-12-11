namespace talentoapi.Services
{
    using talentoapi.Dominio;
    using talentoapi.Infraestructura;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class EntrenadorServices
    {
        private readonly EntrenadorRepository _entrenadorRepository;

        public EntrenadorServices()
        {
            _entrenadorRepository = new EntrenadorRepository();
        }

        public List<Entrenador> GetEntrenadores()
        {
            return _entrenadorRepository.GetEntrenadores();
        }

        public async Task<Entrenador?> GetEntrenadorById(int id)
        {
            return await _entrenadorRepository.GetById(id);
        }

        public void CreateEntrenador(Entrenador entrenador)
        {
            _entrenadorRepository.AddEntrenador(entrenador);
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
        