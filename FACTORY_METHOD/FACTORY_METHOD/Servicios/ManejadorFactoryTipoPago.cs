using FACTORY_METHOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD.Servicios
{
    public class ManejadorFactoryTipoPago : IFactoryTipoPago
    {
        private ITipoPago svrManejadorPago;
        public ManejadorFactoryTipoPago(ITipoPago _svrManejadorPago)
        {
            this.svrManejadorPago = _svrManejadorPago;
        }

        public void ProcesarPago()
        {
            this.svrManejadorPago.GenerarPago();
        }        
    }
}
