using FACTORY_METHOD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD.Servicios
{
    public class ManejadorPagoTarjeta : ITipoPago
    {
        public string cConcepto;
        public decimal dPago;
        public void NuevoPago(string _cConcepto, decimal _dPago)
        {
            this.cConcepto = _cConcepto;
            this.dPago = _dPago;
        }

        public void GenerarPago()
        {
            bool lImporteValido = false;
            lImporteValido = ValidarPago(dPago);
            ImprimirConcepto(cConcepto, lImporteValido ? "autorizado" : "rechazado", dPago);
        }        

        public bool ValidarPago(decimal _dPago)
        {
            return (_dPago > 5000);
        }

        public void ImprimirConcepto(string _cConcepto, string _cEstatus, decimal _dDecimal)
        {
            Console.WriteLine(
                 "Pedio " +
                 _cConcepto + " con importe de " + _dDecimal + " con tarjeta fue " + _cEstatus);
        }
    }
}
