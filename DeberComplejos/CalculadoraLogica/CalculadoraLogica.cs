using System;

namespace CalculadoraLogica
{
    public class Calculadora
    {
        public Complejo Sumar(Complejo primeroNumero, Complejo segundoNumero)
        {
            var parteReal = primeroNumero.Real + segundoNumero.Real;
            var parteImaginaria = primeroNumero.Imaginaria + segundoNumero.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

        public Complejo Restar(Complejo primerNumero, Complejo segundoNumero)
        {
            var parteReal = primerNumero.Real - segundoNumero.Real;
            var parteImaginaria = primerNumero.Imaginaria - segundoNumero.Imaginaria;
            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

        public Complejo Multiplicar(Complejo primerNumero, Complejo segundoNumero)
        {
            var primerFactor = primerNumero.Real * segundoNumero.Real;
            var segundofactor = primerNumero.Real * segundoNumero.Imaginaria;
            var tercerFactor = primerNumero.Imaginaria * segundoNumero.Real;
            var cuartoFactor = primerNumero.Imaginaria * segundoNumero.Imaginaria;

            var cambioNegativo = cuartoFactor * -1;

            var parteReal = primerFactor + cambioNegativo;
            var parteImaginaria = segundofactor + tercerFactor;

            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

        public object Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new System.ArgumentException();
            }
            return dividendo / divisor;
        }


        public Complejo multiplicacionEscalar(double numero, Complejo primerNumero)
        {
            var parteReal = numero * primerNumero.Real;

            var parteImaginaria = numero * primerNumero.Imaginaria;

            var nuevoComplejo = new Complejo(parteReal, parteImaginaria);

            return nuevoComplejo;
        }

    }
}
