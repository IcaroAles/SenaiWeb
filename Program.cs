using SenaiWeb.Model;

ExemploSenaiContext context = new ExemploSenaiContext();

while(true)
{
    Console.WriteLine("O que deseja fazer? 1 - Logar" + "2 - Registrar ou 3 - Sair");
     string num = Console.ReadLine();
     if (num == "1")
     {
         Console.Clear();
         Console.WriteLine("Digite seu login e senha, separados por enter.");

     }
     else if (num == "2")
     {
         Console.Clear();
     }
     else if (num == "3")
     {
         break;
     }
     else
     {
         Console.WriteLine("Erro, tente novamente");
     }