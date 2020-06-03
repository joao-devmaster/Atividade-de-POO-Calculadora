using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
          Calculo conta = new Calculo();
            Console.WriteLine("Faça um cálculo abaixo \n Utilize: \n + para soma, - para subtração, x para multiplicação e / para divisão");
            string calculo = Console.ReadLine();
           conta.ManipularCalculos(calculo);
            Console.WriteLine("Resultado: "+ conta.resultado);

            conta.resultado = 0;

            System.Console.WriteLine("Digite números separados por vírgula:");
            conta.CalcularMedia( Console.ReadLine() );
            System.Console.WriteLine("Média: "+conta.resultado);


        }
    }
}
