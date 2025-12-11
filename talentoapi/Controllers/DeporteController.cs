namespace talentoapi.Controllers
{
    class DeporteController
    {
        private readonly Services.DeporteServices _deporteServices;

        public DeporteController()
        {
            _deporteServices = new Services.DeporteServices();
        }

        public List<Dominio.Deporte> GetDeportes()
        {
            return _deporteServices.GetDeportes();
        }

        public Dominio.Deporte GetDeporteById(int id)
        {
            return _deporteServices.GetDeporteById(id);
        }

        public void AddDeporte(Dominio.Deporte deporte)
        {
            _deporteServices.AddDeporte(deporte);
        }

        public void UpdateDeporte(Dominio.Deporte deporte)
        {
            _deporteServices.UpdateDeporte(deporte);
        }

        public void DeleteDeporte(int id)
        {
            _deporteServices.DeleteDeporte(id);
        }
    }
    
}