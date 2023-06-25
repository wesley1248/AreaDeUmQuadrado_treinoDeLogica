using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino_de_logica_area_de_um_quadrado {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciado");

            Console.Write("Digite a medida do lado do quadrado: ");
            Informacoes_do_quadrado quadrado = new Informacoes_do_quadrado();
            quadrado.medida_do_lado = int.Parse(Console.ReadLine());

            Calculo calulos = new Calculo();
            int resultado = calulos.Calculo_da_area(quadrado.medida_do_lado);
            int area_multiplicada = calulos.area_multiplicada(quadrado.medida_do_lado);

            Console.WriteLine("A area do quadrado é " + resultado + " e a area multiplicada é " + area_multiplicada);

            Console.ReadKey();
        }
    }
}
