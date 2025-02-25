using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnBienesRaices
{
    public class clsCuotaCasa
    {
        public decimal Ingresos { get; set; }
        public decimal CostoCasa { get; set; }
        public bool EsCabezaFamilia { get; set; }

        public clsCuotaCasa(decimal ingresos, decimal costocasa, bool escabezahogar) 
        {
            Ingresos = ingresos;
            CostoCasa = costocasa;
            EsCabezaFamilia = escabezahogar;
        }


        public decimal CalcularEnganche()
        {
            if (Ingresos < 600000m)
                return CostoCasa * 0.15m;

            return CostoCasa * 0.30m;
        }

        public decimal CalcularCuotaMensual()
        {
            decimal enganche = CalcularEnganche();
            decimal resto = CostoCasa - enganche;

            int años = Ingresos < 600000m ? 10 : 7;
            int meses = años * 12;

            decimal cuota = resto / meses;

            if (EsCabezaFamilia)
                cuota *= 0.97m;

            return cuota;
        }
    }
}
