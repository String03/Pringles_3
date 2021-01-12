using Pringles.Contracts.Repositories;
using Pringles.EE;
using Pringles.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pringles.DAL
{
    public class RegistroCajaRepository : Repository<RegistroCaja>, IRegistroCajaRepository
    {
        public void CerrarCaja(int cajaId)
        {
            RegistroCaja registroCaja = BuscarCajaVigente(cajaId);
            if (registroCaja == null)
                throw new CajaCerradaException();
            registroCaja.Vigente = false;
            Update(registroCaja);
        }

        public void InicializarRegistroCaja(decimal montoInicial, int usuarioId, int cajaId)
        {
            if (TieneRegistroAbierto(cajaId))
                throw new CajaAbiertaException();
            RegistroCaja registroCaja = new RegistroCaja
            {
                Caja_Fk = cajaId,
                Vigente = true,
                Fecha_Calendario = DateTime.Now,
                Fecha_Reg = DateTime.Now,
                Monto_Inicial = montoInicial
            };
            Save(registroCaja);
        }

        public bool TieneRegistroAbierto(int cajaId)
        {
            return BuscarCajaVigente(cajaId) != null;
        }

        public RegistroCaja BuscarCajaVigente(int cajaId)
        {
            string query = "SELECT * FROM REGISTROCAJA WHERE CAJA_FK = @CAJAID AND VIGENTE = 1";
            IDictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@CAJAID", cajaId }
            };
            return ExecuteSelectStatement(query, parameters).FirstOrDefault();
        }
    }
}
