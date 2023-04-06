namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch - case;
            int num;
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("O numero digitado é o 0!"); break;   

                case 1:
                    Console.WriteLine("O numero digitado é o 1!"); break;

                default: Console.WriteLine("O número digitado não é 0 e nem 1!"); break;
            }

            
            // Calculadora básica usando switch-case;
            Console.WriteLine("Digite o 1º número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação desejada (+, -, x, /): ");
            char operacao = Console.ReadLine();   

            double resultado = 0;
            switch (operacao)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case 'x':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("O resultado é: " + resultado);


            // Ternario;
            int x = 0, i;

            i = int.Parse(Console.ReadLine());
            x = (i % 2 == 0) ? x = 1 : x = 2;
            Console.WriteLine(x);

            Console.WriteLine(i + " é " + (i % 2 == 0 ? "PAR" : "IMPAR"));


        }
    }
}