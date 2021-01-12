using Pringles.Contracts.Repositories;
using Pringles.EE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pringles.BLL
{
    public class ClienteBLL
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteBLL(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        /// <summary>
        /// Modifica el cliente seleccionado
        /// </summary>
        /// <param name="cliente"></param>
        public void ModificarCliente(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        /// <summary>
        /// Retorna todos los clientes activos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cliente> ListarClientes()
        {
            return _clienteRepository.GetAll().Where(c => c.Activo != false);
        }

        /// <summary>
        /// Guarda un cliente nuevo en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        public void AltaCliente(Cliente cliente)
        {
            _clienteRepository.Save(cliente);
        }

        /// <summary>
        /// Elimina un cliente seleccionado
        /// </summary>
        /// <param name="cliente"></param>
        public void BajaCliente(Cliente cliente)
        {
            _clienteRepository.Delete(cliente);
        }

        /// <summary>
        /// Elimina un cliente al marcarlo como inactivo
        /// </summary>
        /// <param name="cliente"></param>
        public void DesvincularCliente(Cliente cliente)
        {
            cliente.Activo = false;
            cliente.Fecha_Modificacion = DateTime.Now;
            ModificarCliente(cliente);
        }

        /// <summary>
        /// Se encarga de buscar el cliente con más compras
        /// </summary>
        /// <returns></returns>
        public Cliente BuscarMejorCliente()
        {
            return _clienteRepository.BuscarMejorCliente();
        }
    }
}
