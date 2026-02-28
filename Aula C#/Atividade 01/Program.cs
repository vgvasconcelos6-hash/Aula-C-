Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();
Console.WriteLine("Qual a sua idade?");
int idade = int.Parse(Console.ReadLine());
int anoN = DateTime.Now.Year - idade;
Console.WriteLine($"Olá, {nome}, sua idade é {idade} então você provavelmente nasceu em {anoN}.");
