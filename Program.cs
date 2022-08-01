using SenaiWeb.Model;

Usuario usuario = new Usuario();
usuario.Nome = "Rogerinho Fumaça";
usuario.Senha = "senhaforte";

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();

