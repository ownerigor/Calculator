class Program {
    static void Main() {       
        Console.WriteLine("Olá! Este é o meu projeto de calculadora em C#! :) \n");
        Console.Write("Escolha um operador para calcular as tabelas de 1 a 10, são as opções: \n" +
                        "Digite 1 para soma; \n" +
                        "Digite 2 para subtração; \n" +
                        "Digite 3 para multiplicação; \n" +
                        "Digite 4 para divisão. \n");
        int? operador = null;
        try {
            operador = int.Parse(Console.ReadLine());
        }
        catch (FormatException) {
            Console.WriteLine("Erro: O valor digitado não é um número inteiro ou é nulo.");
            Environment.Exit(0);
        }
        catch (Exception ex) {
            Console.WriteLine("Erro: " + ex.Message);
            Environment.Exit(0);
        }
        
        if (operador <= 0 || operador > 4) {
            throw new ArgumentException($"O operador {operador} não é válido.");
        }        

        var sum = delegate (int number, int adder) { return number + adder; };
        var subtract = delegate (int number, int subtractor) { return number - subtractor; };
        var multiply = delegate (int number, int multiplier) { return number * multiplier; };        
        var divide = delegate (int number, int divider) { return number / divider; };        

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"\nTabela sendo operada com o número {i}");
            Console.WriteLine("-------------------- ");

            for (int j = 1; j <= 10; j++) {
                if (operador == 1) {
                    Console.WriteLine($"{i} + {j} = { sum(i,j)}");
                } else if (operador == 2) {
                    Console.WriteLine($"{i} - {j} = { subtract(i,j)}");
                } else if (operador == 3) {
                    Console.WriteLine($"{i} x {j} = { multiply(i,j)}");
                } else {
                    Console.WriteLine($"{i} ÷ {j} = { divide(i,j)}");
                }
            }
        }
    }
}