using System;
using POO_Static;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine( Math.Pow(2,5) );

            Console.WriteLine("Digite um valor :");
            Conversor.valorUsuario = float.Parse( Console.ReadLine() );
            Console.WriteLine("A quantia de dolar para real é : ");
            Console.WriteLine( Conversor.ConverterDolarParaReal());
            Console.WriteLine("A quantia de real para dolar é : ");
            Console.WriteLine( Conversor.ConverterRealParaDolar());

            Console.WriteLine(Conversor.ConverterEuroParaReal());
            Console.WriteLine("A quantia de euro para real é : ");
            Console.WriteLine(Conversor.ConverterRealParaEuro());


            Testar();
        }

        static void Testar(){

        }
    }
}
