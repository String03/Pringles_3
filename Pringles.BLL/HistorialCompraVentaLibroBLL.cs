using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class HistorialCompraVentaLibroBLL
    {
        private readonly IRepository<HistorialCompraVentaLibro> _historialCompraVentaLibroRepository;

        public HistorialCompraVentaLibroBLL(IRepository<HistorialCompraVentaLibro> historialCompraVentaLibroRepository)
        {
            _historialCompraVentaLibroRepository = historialCompraVentaLibroRepository;
        }


        public IEnumerable<HistorialCompraVentaLibro> ListarHistorialCompraVentaLibros()
        {
            return _historialCompraVentaLibroRepository.GetAll();
        }

        public void AltaHistorialCompraVentaLibro(HistorialCompraVentaLibro historialCompraVentaLibro)
        {
            _historialCompraVentaLibroRepository.Save(historialCompraVentaLibro);
        }

        public void BajaHistorialCompraVentaLibro(HistorialCompraVentaLibro historialCompraVentaLibro)
        {
            _historialCompraVentaLibroRepository.Delete(historialCompraVentaLibro);
        }

        public void ModificarHistorialCompraVentaLibro(HistorialCompraVentaLibro historialCompraVentaLibro)
        {
            _historialCompraVentaLibroRepository.Update(historialCompraVentaLibro);
        }
    }
}
