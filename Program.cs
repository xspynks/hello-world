// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!\n" + DateTime.Now.ToString("MMMM, dd, yyyy"));

Console.WriteLine("Digite um número:");
int age = Convert.ToInt32(Console.ReadLine());

// receives input from the user
Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Olá, " + name + ". Sua idade é: " + age);
