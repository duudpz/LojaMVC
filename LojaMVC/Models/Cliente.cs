namespace LojaMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }

        public bool Validado()
        {
            return Idade >= 18 && !string.IsNullOrWhiteSpace(Nome) && Email.Contains('@') || !string.IsNullOrWhiteSpace(Email);
        }

        public bool EstaValidado() { 
            return Ativo && Idade>=18;
        }

        public bool SemDadosPessoais()
        {
            return Idade == 0 && !string.IsNullOrWhiteSpace(Nome) && Email.Contains('@') && !string.IsNullOrWhiteSpace(Email);
        }
    }
}
