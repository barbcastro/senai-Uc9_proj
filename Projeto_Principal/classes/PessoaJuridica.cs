using Uc9_proj.interfaces;

namespace Uc9_proj.classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; } 
        public string ?razaoSocial { get; set; }
        
                        
        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}