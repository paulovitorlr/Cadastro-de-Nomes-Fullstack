namespace PessoaAPI.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Pessoa(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        internal static object Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
