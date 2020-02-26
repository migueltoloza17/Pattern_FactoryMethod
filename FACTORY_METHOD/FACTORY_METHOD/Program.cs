using FACTORY_METHOD.Interfaces;
using FACTORY_METHOD.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTORY_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            string cTipoPago = string.Empty, cConceptoPago = string.Empty;
            decimal dImporte = 0M;

            IFactoryTipoPago factoryTipoPago;
            ITipoPago manejadorPago = new ManejadorPagoEfectivo();

            GeneraCadenaModalidades();

            Console.WriteLine("Seleccione una modalidad de pago");
            cTipoPago = Console.ReadLine();
            Console.WriteLine("Ingrese un concepto");
            cConceptoPago = Console.ReadLine();
            Console.WriteLine("Ingrese un importe");
            dImporte = Convert.ToDecimal(Console.ReadLine());

            switch (cTipoPago)
            {
                case "EFECTIVO":
                    manejadorPago = new ManejadorPagoEfectivo();
                    manejadorPago.NuevoPago(cConceptoPago, dImporte);
                    break;
                case "TARJETA":
                    manejadorPago = new ManejadorPagoTarjeta();
                    manejadorPago.NuevoPago(cConceptoPago, dImporte);
                    break;
                default:
                    break;
            }

            factoryTipoPago = new ManejadorFactoryTipoPago(manejadorPago);
            factoryTipoPago.ProcesarPago();

            Console.ReadKey();


        }

        static void GeneraCadenaModalidades()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("* Modalidades de pago                              *");
            Console.WriteLine("*       => EFECTIVO                                *");
            Console.WriteLine("*       => TARJETA                                 *");
            Console.WriteLine("*                                                  *");
            Console.WriteLine("****************************************************");
        }
    }
}
