namespace ViniAPI_1_Exemplo.Model
{
    public class Amigo
    {
        public int Id { get; set; }
        public string? PrimeiroNome { get; set; }
        public string? SobreNome { get; set; }
        public int Idade { get; set; }
        public string? OqueEmprestei { get; set; }

        public Amigo()
        {

        }

        public Amigo(int id ,string primeiroNome, string sobreNome, int idade, string oqueEmprestei)
        {
            Id = id;
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Idade = idade;
            OqueEmprestei = oqueEmprestei;
        }
    }
}
