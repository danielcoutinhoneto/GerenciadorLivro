namespace GerenciadorLivro.API.Models
{
    public class CreateLoanInputModel
    {
        public int Id { get; set; }
        public IdUsuario Id   { get; set; }
        public Id  IdLivro { get; set; }
    }
}
