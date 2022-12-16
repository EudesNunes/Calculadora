namespace Operacoes
{
    public class Calcular
    {
        public double Resposta { get; private set; }
        public void Soma(double valorUm, double valorDois) => this.Resposta = valorUm + valorDois;
        public void Subtracao(double valorUm, double valorDois) => this.Resposta = valorUm - valorDois;
        public void Divisao(double valorUm, double valorDois) => this.Resposta = valorUm / valorDois;
        public void Multiplicacao(double valorUm, double valorDois) => this.Resposta = valorUm * valorDois;
        public void Raiz(double valorUm) => this.Resposta = Math.Sqrt(valorUm);
        public void Modulo(double valorUm) 
        {
            this.Resposta = valorUm;
            if (valorUm < 0) 
                this.Resposta = valorUm * -1;
        }
        public void Potencia(double valorUm, double valorDois) => this.Resposta = Math.Pow(valorUm, valorDois);

    }
}