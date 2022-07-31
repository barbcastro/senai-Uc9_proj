using Uc9_proj.interfaces;

namespace Uc9_proj.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }
                   
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool validarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
        
    }
}