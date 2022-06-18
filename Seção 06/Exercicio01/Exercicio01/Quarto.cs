
namespace Exercicio01
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NroQuarto { get; set; }

        public override string ToString()
        {
            return $"{NroQuarto}: {Nome}, {Email}";
        }
    }
}
