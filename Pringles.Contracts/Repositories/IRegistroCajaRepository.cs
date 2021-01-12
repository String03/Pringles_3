using Pringles.EE;

namespace Pringles.Contracts.Repositories
{
    public interface IRegistroCajaRepository : IRepository<RegistroCaja>
    {
        /// <summary>
        /// Crea un registro nuevo de caja abierta si la caja a abrir no tiene un
        /// registro abierto. Para abrir un registro de caja, la caja a asignar
        /// no puede tener registros abiertos.
        /// </summary>
        /// <param name="initialAmount">Monto con el que se va a inicializar la caja.</param>
        /// <param name="userId">Id del usuario que opera en la caja.</param>
        /// <param name="posId">Id de la caja.</param>
        void InicializarRegistroCaja(decimal initialAmount, int userId, int posId);

        /// <summary>
        /// Determina si el registro de caja se encuentra abierto.
        /// </summary>
        /// <param name="cajaId">Caja a validar.</param>
        /// <returns></returns>
        bool TieneRegistroAbierto(int cajaId);

        /// <summary>
        /// Retorna el registro de caja correspondiente.
        /// </summary>
        /// <param name="cajaId">Caja a consultar registro.</param>
        /// <returns></returns>
        RegistroCaja BuscarCajaVigente(int cajaId);

        /// <summary>
        /// Aplica el cierre de una caja que se encuentre abierta. Para aplicar
        /// el cierre el registro de caja tiene que estar vigente.
        /// </summary>
        /// <param name="cajaId"></param>
        void CerrarCaja(int cajaId);
    }
}
