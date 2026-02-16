using PessoaAPI.Models;

namespace PessoaAPI.Rotas
{
    public static class PessoaRotas
    {
       
        public static List<Pessoa> Pessoas = new()
        {
            new Pessoa(Guid.NewGuid(), "Paulo"),
            new Pessoa(Guid.NewGuid(), "Vitor"),
        };

        public static void MapPessoasRotas(this WebApplication app)
        {
            var pessoasRouter = app.MapGroup("/pessoas");

            pessoasRouter.MapGet("/", GetAllPessoas);
            pessoasRouter.MapGet("/{id}", GetPessoa);
            pessoasRouter.MapPost("/", CreatePessoa);
            pessoasRouter.MapPut("/{id}", UpdatePessoa);
            pessoasRouter.MapDelete("/{id}", DeletePessoa);
        }

       
        static IResult GetAllPessoas()
        {
            return Results.Ok(Pessoas);
        }

       
        static IResult GetPessoa(Guid id)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Id == id);

            return pessoa is not null
                ? Results.Ok(pessoa)
                : Results.NotFound();
        }

        
        static IResult CreatePessoa(Pessoa pessoa)
        {
            
            pessoa.Id = Guid.NewGuid();

            Pessoas.Add(pessoa);

            return Results.Created($"/pessoas/{pessoa.Id}", pessoa);
        }

        
        static IResult UpdatePessoa(Guid id, Pessoa inputPessoa)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Id == id);

            if (pessoa is null)
                return Results.NotFound();

            pessoa.Nome = inputPessoa.Nome;

            return Results.NoContent();
        }

       
        static IResult DeletePessoa(Guid id)
        {
            var pessoa = Pessoas.FirstOrDefault(x => x.Id == id);

            if (pessoa is null)
                return Results.NotFound();

            Pessoas.Remove(pessoa);

            return Results.NoContent();
        }
    }
}
//testando
