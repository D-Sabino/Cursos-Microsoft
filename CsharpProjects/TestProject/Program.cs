//int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//Exercicio cara ou coroa:

        // Gera um número aleatório: 0 para Cara e 1 para Coroa
//        Random random = new Random();
//        int resultado = random.Next(0, 2);
        
//        string resultadoMoeda = (resultado == 0) ? "cara" : "coroa";

//        Console.WriteLine($"\nResultado: {resultadoMoeda}");

        /*
            Solucao do curso:
            Random coin = new Random();
            Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");
        */

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")) {
    if (level > 55 )
        Console.WriteLine("Welcome, Super Admin user.");
    else if (level <= 55)
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager")){
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else if (level < 20)
        Console.WriteLine("You do not have sufficient privileges.");
}