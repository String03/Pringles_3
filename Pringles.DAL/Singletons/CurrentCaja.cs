using Pringles.EE;
using System;

namespace Pringles.DAL.Singletons
{
    public class CurrentCaja
    {
        //Una referencia asi mismo, por eso es estático
        private static CurrentCaja _instance;

        private Caja _caja;

        public Caja Caja { get => _caja; }

        //public Caja Caja { get { return _caja}  }

        private CurrentCaja()
        {
        }

        /// <summary>
        /// Solamente asigna la caja una vez
        /// </summary>
        /// <param name="caja"></param>
        public void SetCaja(Caja caja)
        {
            if (_caja != null)
            {
                throw new Exception("intenta reasignar caja");
            }
            _caja = caja;
        }

        //Un solo new porque solo se instancia una vez
        public static CurrentCaja GetInstance()
        {
            if (_instance == null)
                _instance = new CurrentCaja();
            return _instance;
        }
    }
}
