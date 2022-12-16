using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Linq;
using System.Reflection;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TesteOperador(string leitura)
        {
            if (!string.IsNullOrWhiteSpace(leitura))
            {
                var listaOperacoes = new char[] { '-', '+', '*', '|','/' };

                if (listaOperacoes.Contains(leitura[leitura.Length - 1]))
                    return false;
            }
            else
                return false;
            return true;

        }

        private double Calculo(string leituraTopo, string leituraBaixo)
        {
            double valorUm = Convert.ToDouble(leituraTopo.Substring(0, leituraTopo.Length -1));
            char operador = leituraTopo[leituraTopo.Length - 1];
            double valorDois = Convert.ToDouble(leituraBaixo);
            
            
            switch (operador)
            {
                case '+': return Soma(valorUm, valorDois);
                case '-': return Subtracao(valorUm, valorDois);
                case '*': return Multiplicacao(valorUm, valorDois);
                case '/': return Divisao(valorUm, valorDois);
                case '|': return Raiz(valorUm);
                default: return 0.0; 

            }

        }
        private double Soma(double v1, double v2) => v1 + v2;
        private double Subtracao(double v1, double v2) => v1 - v2;
        private double Divisao(double v1, double v2) => v1 / v2;
        private double Multiplicacao(double v1, double v2) => v1 * v2;
        private double Raiz(double v1) => Math.Sqrt(v1);
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "1";

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "2";

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "3";

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "6";

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "7";

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "8";

        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (painelTopo.Text.IndexOf("=") != -1)
            {
                painelTopo.Text = "";
                painelBaixo.Text = "";
            }
            painelBaixo.Text += "9";

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (TesteOperador(painelBaixo.Text))
            {

                if (painelTopo.Text != "")
                {
                    if (painelTopo.Text.IndexOf("=") != -1)
                    {
                        painelTopo.Text = "";
                        painelBaixo.Text = "";
                    }  
                }
                else
                {
                    painelTopo.Text = painelBaixo.Text;
                    painelTopo.Text += "|";
                    painelBaixo.Text = Convert.ToString(Calculo(painelTopo.Text, "0"));
                    
                }

            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (TesteOperador(painelBaixo.Text))
            {
                
                if (painelTopo.Text != "")
                {
                    if (painelTopo.Text.IndexOf("=") != -1)
                    {
                        painelTopo.Text = painelBaixo.Text;
                        painelTopo.Text += "/";
                        painelBaixo.Text = "";
                    }
                    if (painelBaixo.Text != "")
                    {
                        painelTopo.Text = Convert.ToString(Calculo(painelTopo.Text, painelBaixo.Text));
                        painelTopo.Text += "/";
                        painelBaixo.Text = "";

                    }
                }
                else
                {
                    painelTopo.Text = painelBaixo.Text;
                    painelTopo.Text += "/";
                    painelBaixo.Text = "";
                }

            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            if (TesteOperador(painelBaixo.Text))
            {
               

                if (painelTopo.Text != "")
                {
                    if (painelTopo.Text.IndexOf("=") != -1)
                    {
                        painelTopo.Text = painelBaixo.Text;
                        painelTopo.Text += "*";
                        painelBaixo.Text = "";
                    }
                    if (painelBaixo.Text != "")
                    {
                        painelTopo.Text = Convert.ToString(Calculo(painelTopo.Text, painelBaixo.Text));
                        painelTopo.Text += "*";
                        painelBaixo.Text = "";

                    }
                }
                else
                {
                    painelTopo.Text = painelBaixo.Text;
                    painelTopo.Text += "*";
                    painelBaixo.Text = "";
                }

            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (TesteOperador(painelBaixo.Text))
            {
               

                if (painelTopo.Text != "")
                {
                    if (painelTopo.Text.IndexOf("=") != -1)
                    {
                        painelTopo.Text = painelBaixo.Text;
                        painelTopo.Text += "-";
                        painelBaixo.Text = "";
                    }
                    if (painelBaixo.Text != "")
                    {
                        painelTopo.Text = Convert.ToString(Calculo(painelTopo.Text, painelBaixo.Text));
                        painelTopo.Text += "-";
                        painelBaixo.Text = "";

                    }
                }
                else
                {
                    painelTopo.Text = painelBaixo.Text;
                    painelTopo.Text += "-";
                    painelBaixo.Text = "";
                }

            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (TesteOperador(painelBaixo.Text))
            {
               

                if (painelTopo.Text != "")
                {
                    if (painelTopo.Text.IndexOf("=") != -1)
                    {
                        painelTopo.Text = painelBaixo.Text;
                        painelTopo.Text += "+";
                        painelBaixo.Text = "";
                    }

                    if (painelBaixo.Text != "")
                    {
         

                        painelTopo.Text = Convert.ToString(Calculo(painelTopo.Text, painelBaixo.Text));
                        painelTopo.Text += "+";
                        painelBaixo.Text = "";

                    }
                }
                else
                {
                    painelTopo.Text = painelBaixo.Text;
                    painelTopo.Text += "+";
                    painelBaixo.Text = "";
                }
                

            }

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            painelBaixo.Text += ",";
        }

        private void btnLimpaC_Click_1(object sender, EventArgs e)
        {
            painelBaixo.Text = "";
        }
        private void btnLimpaCE_Click(object sender, EventArgs e)
        {
            painelBaixo.Text = "";
            painelTopo.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (TesteOperador(painelBaixo.Text))
            {
                if (painelTopo.Text.IndexOf("=") != -1)
                {
                    painelTopo.Text = "";
                    painelBaixo.Text = "";
                }
                if (painelTopo.Text != "")
                {
                    if (painelBaixo.Text != "")
                    {
                        string resultado = Convert.ToString(Calculo(painelTopo.Text, painelBaixo.Text));
                        painelTopo.Text += painelBaixo.Text;
                        painelTopo.Text += "=";

                        painelTopo.Text += resultado;

                        painelBaixo.Text = resultado;

                    }
                }
               


            }

        }

       
    }
}