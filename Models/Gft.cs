namespace Desafio_MVC.Models
{
    public class Gft
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public bool Ativa {get; set; }
    }
}