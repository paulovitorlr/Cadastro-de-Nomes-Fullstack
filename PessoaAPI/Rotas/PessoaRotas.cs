using PessoaAPI.Models;

namespace PessoaAPI.Rotas
{
    public static class PessoaRotas
    {
        public static List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa(Guid.NewGuid(), nome:"Paulo"),
            new Pessoa(Guid.NewGuid(), nome:"Vitor"),
        };
        public static void MapPessoasRotas(this WebApplication app)
        {
            app.MapGet("/pessoas", handler:() => Pessoas);

            app.MapGet("pessoas/{nome}",
                handler: (string nome) => Pessoas.Find(x => x.Nome == nome));

            app.MapPost("pessoas",
                (Pessoa pessoa) =>
                {
                    Pessoas.Add(pessoa);
                    return pessoa;
                });

            app.MapPut("/pessoas/{id}", (Guid id, Pessoa pessoa) =>
            {
                var encontrado = Pessoas.Find(x => x.Id == id);

                if (encontrado == null)
                    return Results.NotFound();

                encontrado.Nome = pessoa.Nome;

                return Results.Ok();

            });

            app.MapDelete("/pessoas/{id}", (Guid id) =>
            {
                var pessoa = Pessoas.FirstOrDefault(x => x.Id == id);

                if (pessoa == null)
                    return Results.NotFound();

                Pessoas.Remove(pessoa);

                return Results.NoContent();
            });
        }
    }
}
