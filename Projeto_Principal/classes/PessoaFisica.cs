using Uc9_proj.interfaces;

namespace Uc9_proj.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public string ?dataNascimento { get; set; }
                   
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
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