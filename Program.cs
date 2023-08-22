namespace Aula_01_Calcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            var inicio = "S";
            while (inicio == "S" || inicio == "s")
            {

                Console.WriteLine("Digite o primeiro numero: ");
                num1 = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite segundo número numero: ");
                num2 = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Escolha uma operação\n [+]Soma\n [-]Sub\n [*]Mult\n [/]Div\n");
                var op = Console.ReadLine()[0];
                Console.Clear();
                switch (op)
                {

                    case '+':

                        double _soma = Soma(num1, num2);
                        Console.WriteLine($"{num1} + {num2}\n A soma é: {_soma}");
                        Console.WriteLine("Deseja continuar? S/N");
                        inicio = Console.ReadLine();
                        Console.Clear();
                        break;

                    case '-':
                        double _sub = Sub(num1, num2);
                        Console.WriteLine($"{num1} - {num2}\n A subtração é: {_sub}");
                        Console.WriteLine("Deseja continuar? S/N");
                        inicio = Console.ReadLine();
                        Console.Clear();
                        break;

                    case '*':
                        double _mult = Mult(num1, num2);
                        Console.WriteLine($"{num1} * {num2}\n A multiplicação é: {_mult}");
                        Console.WriteLine("Deseja continuar? S/N");
                        inicio = Console.ReadLine();
                        Console.Clear();
                        break;

                    case '/':
                        double _div = Div(num1, num2);
                        Console.WriteLine($"{num1} / {num2}\n A divisão é: {_div}");
                        Console.WriteLine("Deseja continuar? S/N");
                        inicio = Console.ReadLine();
                        Console.Clear();
                        break;


                }
            }
            Console.WriteLine(" _____________________");
            Thread.Sleep(200);
            Console.WriteLine("|  _________________  |");
            Thread.Sleep(200);
            Console.WriteLine("| |                 | |");
            Thread.Sleep(200);
            Console.WriteLine("| |   T H A N K S   | |");
            Thread.Sleep(200);
            Console.WriteLine("| |_________________| |");
            Thread.Sleep(200);
            Console.WriteLine("|  ___ ___ ___   ___  |");
            Thread.Sleep(200);
            Console.WriteLine("| | 7 | 8 | 9 | | + | |");
            Thread.Sleep(200);
            Console.WriteLine("| |___|___|___| |___| |");
            Thread.Sleep(200);
            Console.WriteLine("| | 4 | 5 | 6 | | - | |");
            Thread.Sleep(200);
            Console.WriteLine("| |___|___|___| |___| |");
            Thread.Sleep(200);
            Console.WriteLine("| | 1 | 2 | 3 | | x | |");
            Thread.Sleep(200);
            Console.WriteLine("| |___|___|___| |___| |");
            Thread.Sleep(200);
            Console.WriteLine("| | . |   | = | | / | |");
            Thread.Sleep(200);
            Console.WriteLine("| |___|___|___| |___| |");
            Thread.Sleep(200);
            Console.WriteLine("|_____________________|");
        }

        private static double Div(double num1, double num2)
        {
            if (num2 == 0) { return num2; 
            }
            return num1 / num2;
        }

        private static double Mult(double num1, double num2)
        {
           return num1 * num2;
        }

        private static double Sub(double num1, double num2)
        {
          return num1 - num2;
        }

        private static double Soma(double num1, double num2)
        {
          return num1 + num2;
        }
    }
}