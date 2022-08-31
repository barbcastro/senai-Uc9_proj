using Uc9_proj.interfaces;

namespace Uc9_proj.classes;

public class PessoaFisica : Pessoa, IPessoaFisica  {
      public string ?cpf { get; set; }
      public string ?dataNascimento { get; set; }
      public string caminho { get; private set; } = "Database/PessoaFisica.csv";
                     
      
      public override float PagarImposto(float rendimento)
      {
                  /*
                  vamos utilizar a seguinte escala: 
                  até 1500 - isento
                  de 1500 a 3500 - 2% de impostos
                  de 3500 a a 6000 - 3,5% de impostos
                  acima de 6000 - 5% de impostos
                  */
                  
        if(rendimento <= 1500)
          {
              return 0;
          }
        else if (rendimento >1500 && rendimento <=3500)
          {
              return MathF.Round((rendimento * 0.02f), 2);
          }
        else if (rendimento >3500 && rendimento <=6000)
          {
              return  MathF.Round((rendimento * 0.035f),2);
          }
        else 
          {
              return  MathF.Round((rendimento * 0.05f),2);
          }
      }
      
      // validação básica, sem conversão        
      public bool ValidarDataNascimento(DateTime dataNasc)
      {
          DateTime dataAtual = DateTime.Today;
          double anos = (dataAtual - dataNasc).TotalDays / 365;

        if(anos >= 18)
           return true;

           return false;               
      }

      public bool ValidarDataNascimento(string dataNasc)
      {
        DateTime dataConvertida;
       //verificar se a string está em um formato válido  
          if(DateTime.TryParse(dataNasc, out dataConvertida))
          {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataConvertida).TotalDays / 365;

              if(anos >= 18)
                  return true;

              return false;  
          }     
          return false;       
      }  

      public  void Inserir(PessoaFisica pf)
      {
         VerificarPastaArquivo(caminho);
         string[] pfString = {$"{pf.nome}, {pf.cpf},{pf.dataNascimento}, {pf.rendimento}, {pf.endereco.logradouro}, {pf.endereco.numero}, {pf.endereco.complemento}, {pf.endereco.endComercial}"};

         File.AppendAllLines(caminho, pfString);        
      }

      public List<PessoaFisica> Ler()
      {
          VerificarPastaArquivo(caminho);

          List<PessoaFisica> listaPf = new List<PessoaFisica>();
          string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
              {
                string[] atributos = cadaLinha.Split(",");

                PessoaFisica cadaPf = new PessoaFisica();
                Endereco cadaEnd = new Endereco();

                  cadaPf.nome = atributos[0];
                  cadaPf.cpf = atributos[1];
                  cadaPf.dataNascimento = atributos[2];
                  cadaPf.rendimento = float.Parse(atributos[3]);
                  cadaEnd.logradouro = atributos[4];
                  cadaEnd.numero = int.Parse(atributos[5]);
                  cadaEnd.complemento = atributos[6];
                  cadaEnd.endComercial = bool.Parse(atributos[7]);
                  cadaPf.endereco = cadaEnd;
                  listaPf.Add(cadaPf);
              }
              return listaPf;        
      }

  public bool validarDataNascimento(string dataNasc)
  {
    throw new NotImplementedException();
  }
}
        