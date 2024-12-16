// See https://aka.ms/new-console-template for more information
class Program(){
    static void Main(string [] args)
    { 
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------------------");

        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());
        
        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    static void Soma()
    {
        Console.Clear();
        // Inserindo o primeiro valor --------------------------------
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        // Inserindo o segundo valor ---------------------------------
        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        // Exibindo resultado ----------------------------------------
        float resultado = v1 + v2;
        Console.WriteLine($"A soma dos valores é igual a {resultado}.");
        Console.ReadKey();

        Menu();
    }
    static void Subtracao()
    {
        Console.Clear();
        // Inserindo o primeiro valor --------------------------------
        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        // Inserindo o segundo valor ---------------------------------
        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        // Exibindo resultado ----------------------------------------
        float resultado = v1 - v2;
        Console.WriteLine($"A subtração dos valores é igual a {resultado}.");
        Console.ReadKey();
        Menu();

    }
    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1/v2;

        Console.WriteLine($"A divisao dos valores é igual a {resultado}.");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = v1 * v2;

        Console.WriteLine($"A multiplicação dos valores é igual a {resultado}.");
        Console.ReadKey();
        Menu();

    }
}




