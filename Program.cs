using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int seletor = 0;
            Console.WriteLine("Digite a operação: \n1 - AND \n2 - OR\n3 - XOR\n4 - NAND\n5 - SOMA INT\n6 - SOMA NAT\n7 - SUBTRAIR\n8 - DESL ESQ\n9 - DESL DIR\n10 - DESL DIR A\n11 - ROLL LEFT\n12 - COMPARADOR");
            string op = Console.ReadLine();
            switch(op){
                default: Console.WriteLine("operação inválida");
                break;
                case "1": seletor = 00000;
                break;
                case "2": seletor = 00001;
                break;
                case "3": seletor = 00010;
                break;
                case "4": seletor = 00011;
                break;
                case "5": seletor = 00100;
                break;
                case "6": seletor = 00101;
                break;
                case "7": seletor = 00110;
                break;
                case "8": seletor = 00111;
                break;
                case "9": seletor = 01000;
                break;
                case "10": seletor = 01001;
                break;
                case "11": seletor = 01010;
                break;
                case "12": seletor = 01011;
                break;
            }
            Console.WriteLine("");
            
        }
    }
}
