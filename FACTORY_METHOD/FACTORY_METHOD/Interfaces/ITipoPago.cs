using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD.Interfaces
{
    public interface ITipoPago
    {
        void NuevoPago(string _cConcepto, decimal _dPago);
        void GenerarPago();
        bool ValidarPago(decimal _dPago);
        void ImprimirConcepto(string _cConcepto, string _cEstatus, decimal _dDecimal);
    }
}
