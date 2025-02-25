using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnBienesRaices
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Calculo de pagos para casas de interes social\n");

				Console.WriteLine("Digite los ingresos del comprador: ");
				decimal ingresos = decimal.Parse(Console.ReadLine());

				Console.WriteLine("Ingrese el costo de la casa: ");
				decimal costocasa = decimal.Parse(Console.ReadLine());

				Console.WriteLine("¿Es cabeza de familia? (S/N): ");
				bool esCabeza = Console.ReadLine().Trim().ToUpper() == "S";

				clsCuotaCasa calculadora = new clsCuotaCasa(ingresos, costocasa, esCabeza);

				Console.WriteLine("\nResultados: ");
				Console.WriteLine($"Enganche requerido: {calculadora.CalcularEnganche():C}");
				Console.WriteLine($"Cuota mensual: {calculadora.CalcularCuotaMensual():C}");
			}
			catch (Exception ex)
			{

				Console.WriteLine("Error en la entrada de datos: " + ex.Message);
			}
        }
    }
}
