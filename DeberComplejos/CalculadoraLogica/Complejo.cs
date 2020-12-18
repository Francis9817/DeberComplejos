namespace CalculadoraLogica
{
    public class Complejo
    {
        private double real;
        private double imaginario;

        public Complejo(double real, double imaginario)
        {
            this.real = real;
            this.imaginario = imaginario;
        }

        public int Real { get; set; }

        public int Imaginaria { get; set; }
    }
}