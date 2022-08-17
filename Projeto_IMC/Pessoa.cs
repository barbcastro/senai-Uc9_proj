namespace Projeto_IMC
{
  public class Pessoa
    {
        public double peso { get; set; }
        public double altura { get; set; }
        public double imc { get; set; }

        public Pessoa(double argPeso, double argAltura)
            {
                this.peso = argPeso;
                this.altura = argAltura;
                this.imc = calcularIMC(this.peso, this.altura);
            }

        public double calcularIMC (double argPeso, double argAltura)
            {
                double resultado = argPeso / (argAltura * argAltura);
                return resultado;
            }

        public string classificarIMC(double argIMC)
         {
              string classificacao;
                if (argIMC < 18.5)
                    {
                        classificacao = "abaixo do peso";
                    }
                else if (argIMC >= 18.5 && argIMC < 25)
                    {   
                        classificacao = "Peso normal";
                    }
                else if (argIMC >= 25 && argIMC <30)
                    {
                        classificacao = "Sobrepeso";
                    }
                else if (argIMC >= 30 && argIMC < 35)
                    {
                        classificacao = "Obesidade I";
                    }
                else if (argIMC >= 35 && argIMC < 40)
                    {
                        classificacao = "Obesidade II";
                    }
                else 
                    {
                        classificacao = "Obesidade III";
                    }
               
                return classificacao;
        }
    }
}




                /*
                tabela verdade do E (&&)
                v && v = v
                V && F = F
                F && V = F
                F && F = F
                Na tabela verdado do E, terei verdadeiro apenas quando as duas propordições forem verdadeiras.

                tabela verdade do OU (||)
                V || V = V
                V || F = V
                F || V = V
                F || F = F
                Na tabela verdade do OU, terei resultado falso apenas qdo as duas proposições forem falsas. 
                */