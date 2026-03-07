Console.WriteLine("---CUBANK---");
Console.WriteLine("Por favor, informe o ano do seu nascimento:");
int anoN = int.Parse(Console.ReadLine());
int idade = DateTime.Now.Year - anoN;
Console.WriteLine("Agora informe sua renda mensal:");
double renda = double.Parse(Console.ReadLine());
Console.WriteLine("Possui alguma divida ou pendencia em seu nome?");
Console.WriteLine("Digite '1' para 'sim' e '2' para 'não'");
int serasa = int.Parse(Console.ReadLine());

if (idade < 18)
{
    Console.Write("Infelizmente você não possui idade para aprovarmos o emprestimo!");
}
else if (renda >= 2500.00 && serasa == 2)
{
    Console.Write("---EMPRESTIMO APROVADO!---");
}
else
{
    Console.Write("---EMPRESTIMO NEGADO!!!---");
}