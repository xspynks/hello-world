// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\nToday is " + DateTime.Now.ToString("MMMM, dd, yyyy"));

// receives a integer from the user
Console.WriteLine("Digite um número:");
int age = Convert.ToInt32(Console.ReadLine());

// receives a string from the user and prints it
Console.WriteLine("Digite seu nome: ");
string name = Console.ReadLine();

Console.WriteLine("Olá, " + name + ". Sua idade é: " + age);
