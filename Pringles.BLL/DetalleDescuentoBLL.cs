using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class DetalleDescuentoBLL
    {
        private readonly IDetalleDescuentoRepository _detalleDescuentoRepository;

        public DetalleDescuentoBLL(IDetalleDescuentoRepository detalleDescuentoRepository)
        {
            _detalleDescuentoRepository = detalleDescuentoRepository;
        }

        /// <summary>
        /// Devuelve todos los detalles de descuentos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DetalleDescuento> ListarDetalleDescuentos()
        {
            return _detalleDescuentoRepository.BuscarDescuentosVigentes();
        }

        /// <summary>
        /// Crea un nuevo registro de detalle descuento
        /// </summary>
        /// <param name="detalleDescuento"></param>
        public void AltaDetalleDescuento(DetalleDescuento detalleDescuento)
        {
            detalleDescuento.Fecha_Reg = DateTime.Now;
            detalleDescuento.Estatus = true;
            _detalleDescuentoRepository.Save(detalleDescuento);
        }

        /// <summary>
        /// Elimina un registro de detalle descuento seleccionado
        /// </summary>
        /// <param name="detalleDescuento"></param>
        public void BajaDetalleDescuento(DetalleDescuento detalleDescuento)
        {
            detalleDescuento.Estatus = false;
            _detalleDescuentoRepository.Update(detalleDescuento);
        }

        public void ModificarDetalleDescuento(DetalleDescuento detalleDescuento)
        {
            _detalleDescuentoRepository.Update(detalleDescuento);
        }
    }
}
