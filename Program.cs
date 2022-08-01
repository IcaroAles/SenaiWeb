using SenaiWeb.Model;

Usuario usuario = new Usuario();
usuario.Nome = "Ander Guebs";
usuario.Senha = "lalala123";

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();
