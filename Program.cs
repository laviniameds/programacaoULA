using System;
using System.IO;

namespace C_
{
    class Program
    {
        static string toBinary(string valor){
            return Convert.ToString(Convert.ToInt32(valor), 2).PadLeft(5, '0');
        }
        static string toBinaryConst(string valor){
            return Convert.ToString(Convert.ToInt32(valor), 2).PadLeft(12, '0');
        }
        static void Main(string[] args)
        {        
            string[] lines = File.ReadAllLines(@"fat.txt");
            foreach (string line in lines)
            {
                string[] comandos = line.Split(' ');
                string op = toBinary(comandos[0]);
                string regDEST = toBinary(comandos[1]);
                

            }

            //Console.WriteLine("Digite a operação: \n0 - AND \n1 - OR\n2 - XOR\n3 - NAND\n4 - SOMA INT\n5 - SOMA NAT\n6 - SUBTRAIR\n7 - DESL ESQ\n8 - DESL DIR\n9 - DESL DIR A\n10 - ROLL LEFT\n11 - COMPARADOR\n12 - SOMA CONSTANTE\n29 - BNE\n30 - BEQ\n31 - JMP");
            //string op = toBinary(Console.ReadLine());
            //Console.WriteLine("Digite o numero correspondente ao regDEST Ex: 1, 2 .. 32");
            //string regDEST = toBinary(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao RS Ex: 1, 2 .. 32");
            string RS = toBinary(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente ao RT Ex: 1, 2 .. 32");
            string RT = toBinary(Console.ReadLine());
            Console.WriteLine("Digite o numero correspondente à constante Ex: 1, 2 .. 32");
            string constante = toBinaryConst(Console.ReadLine());
            string resultBin = op + regDEST + RS + RT + constante;
            int hex = Convert.ToInt32(resultBin,2);
            Console.WriteLine("O resultado é: {0} {1:X}", resultBin, hex);
            Console.WriteLine(resultBin.Length);
            
            /*int num, x, temp; //declara o as variaveis de numero e auxiliar x e temp
            int resultado = 1; //resultado do fatorial
            num = int.Parse(Console.ReadLine());//recebe o numero 
            while (num != 0) { //enquanto numero for diferente de zero
                x = num; 
                temp = 0; // temp = 0
                while (x != 0) { //enquanto x for diferente de zero
                    temp = temp + resultado; //temp é somado com o resultado
                    x = x - 1; // auxiliar é diminuido em 1
                }
                resultado = temp; //resultado é igual ao temporario
                num = num - 1; //o numero é diminuído em 1
            }
            Console.WriteLine("resultado: {0}"  ,resultado); //escreve o resultado*/
        }
    }
}
