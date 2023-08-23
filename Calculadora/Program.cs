public class Program
{
    static void Main(string[] args)
    {
        // Pegando o primeiro numero digitado pelo usuario
        Console.WriteLine("Digite o primeiro número: ");
        int numb1 = Convert.ToInt32(Console.ReadLine());

        // Pegando o segundo numero digitado pelo usuario
        Console.WriteLine("Digite o segundo número: ");
        int numb2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escoha qual operação desejada:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        // Pegando a oção de operação, selecionada pelo usuario
        int oper = Convert.ToInt32(Console.ReadLine());
        string operacao = "";

        //Resultado começado com (0)
        int resultado = 0;

        switch (oper)
        {
            case 1: 
                resultado = numb1 + numb2;
                operacao = "soma";
                break;
            case 2: 
                resultado = numb1 - numb2;
                operacao = "subtração";
                break;
            case 3:
                resultado = numb1 * numb2;
                operacao = "multiplicação";
                break;
            case 4:
                resultado = numb1 / numb2;
                operacao = "divisão";
                break;
        }

        Console.WriteLine("O resultado da "+operacao+" é: " +resultado);
    }
}