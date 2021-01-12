using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pringles.BLL
{
    public class ProveedorBLL
    {
        private readonly IProveedorRepository _proveedorRepository;
       

        public ProveedorBLL(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
           
            
        }

        /// <summary>
        /// Registra un nuevo proveedor
        /// </summary>
        /// <param name="proveedor"></param>
        public void GuardarProveedorNuevo(Proveedor proveedor)
        {
            try
            {
                _proveedorRepository.Save(proveedor);
            }
            catch (Exception ex)
            {
                ThrowExceptionProveedor("Error guardando proveedor " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina el proveedor seleccionado
        /// </summary>
        /// <param name="proveedor"></param>
        public void EliminarProveedor(Proveedor proveedor)
        {
            try
            {
                Proveedor temp = _proveedorRepository.Find(proveedor.Id);
                if (temp == null)
                    ThrowExceptionProveedor("El proveedor a eliminar no existe");
                _proveedorRepository.Delete(proveedor);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Actualiza el proveedor seleccionado
        /// </summary>
        /// <param name="proveedor"></param>
        public void ModificarProveedor(Proveedor proveedor)
        {
            _proveedorRepository.Update(proveedor);
        }

        /// <summary>
        /// Lista todos los proveedorse
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Proveedor> ListarProveedores()
        {
            return _proveedorRepository.GetAll();
        }

        private void ThrowExceptionProveedor(string message)
        {
            Exception ex = new Exception(message);
            throw ex;
        }

        /// <summary>
        /// Lista los proveedores según más rápido envía el pedido
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MayorRapidezDTO> BuscarProveedorConMayorRapidez()
        {
            return _proveedorRepository.BuscarProveedorMayorRapidez();
        }
    }
}
