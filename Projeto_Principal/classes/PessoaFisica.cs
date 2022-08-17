using Uc9_proj.interfaces;

namespace Uc9_proj.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
                   
        
        public override float PagarImposto(float rendimento)
        {
            /* Vamos uitiliar a seguinte escala
            Até 1500 (considerando 1500) - isento
            De 1500 a 3500 (considerando 3500) - 2% de impostos
            De 3500 a 6000 (considerando 6000) - 3,5% de impostoos
            acima de 6000 - 5% de impostos
            */
            if (rendimento > 1500)
                {
                    return 0;
                }
            else if (rendimento > 1500 && rendimento <= 3500)
                {
                    return (rendimento / 100) * 2; // return rendimento * 0.02;
                }
            else if (rendimento > 3500 && rendimento <= 6000)
                {
                        return (rendimento / 100) * 3.5f;
                }
            else
                {
                    return (rendimento / 100) * 5;
                }    
        }

        
        public bool validarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual;
            dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays /365;
            if (anos >=18)
                return true;
            
            return false;
        }
        

        public bool validarDataNascimento(string dataNasc)
        {
            DateTime dataConvertida;
            //verificar se a string esta em um formato valido
            //tryparse tenta converter e coloca na saida out
            if(DateTime.TryParse (dataNasc, out dataConvertida)){
                //Console.WriteLine($"{dataConvertida}");
                DateTime dataAtual = DateTime.Today; 
                 double anos = (dataAtual - dataConvertida).TotalDays /365;
                  if (anos >=18){
                      return true;
                  }           
                  return false;
            }
            return false;       
        }
        
    }
}