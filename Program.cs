using System;
using System.IO;

namespace C_
{
    class Program
    {
        static string toBinary(string valor){
            return Convert.ToString(Convert.ToInt32(valor), 2).PadLeft(5, '0');
        }
        static void Main(string[] args)
        {        
            Console.WriteLine("Digite a operação: \n0 - AND \n1 - OR\n2 - XOR\n3 - NAND\n4 - SOMA INT\n5 - SOMA NAT\n6 - SUBTRAIR\n7 - DESL ESQ\n8 - DESL DIR\n9 - DESL DIR A\n10 - ROLL LEFT\n11 - COMPARADOR");
            string op = toBinary(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao regDEST Ex: 1, 2 .. 32");
            string regDEST = toBinary(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao RS Ex: 1, 2 .. 32");
            string RS = toBinary(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao RT Ex: 1, 2 .. 32");
            string RT = toBinary(Console.ReadLine());
            string constante = "000000000000";
            string resultBin = op + regDEST + RS + RT + constante;
            int hex = Convert.ToInt32(resultBin,2);
            Console.WriteLine("O resultado é: {0} {1:X}", resultBin, hex);
            Console.ReadKey();

            string nomeArquivo = @"/home/lavinia/Documentos/ULA/fatorial.txt";
        }
    }
}
