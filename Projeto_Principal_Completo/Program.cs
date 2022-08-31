using Uc9_proj.classes;

Console.WriteLine(@$"
=============================================
|  Bem vindo ao Sistema de Cadastro de      |       
|      Pessoas Físicas e Jurídicas          |
=============================================
");
BarraCarregamento("Carregando", 100);

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=========================================
|   Escolha uma das opções a seguir:    |
|_______________________________________|  
|         1- Pessoa Física              |
|         2- Pessoa Jurídica            |
|         0- Sair                       |
=========================================
");
  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      //menu pessoa física
      string? opcaoPF;
      do
      {
        Console.Clear();
        Console.WriteLine(@$"
        =========================================
        |   Escolha uma das opções a seguir:    |
        |_______________________________________|  
        |    1- Cadastrar Pessoa Física         |
        |    2- Mostrar Pessoa Física           |
        |    0- Retornar ao menu anterior       |
        =========================================
        ");
        opcaoPF = Console.ReadLine();

        PessoaFisica novaPf = new PessoaFisica();
        PessoaFisica metodoPf = new PessoaFisica();
        Endereco novoEndPf = new Endereco();

        switch (opcaoPF)
        {
          case "1":
            //case cadastrar pessoa física
            Console.Clear();

            Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
            novaPf.nome = Console.ReadLine();
            
            Console.WriteLine($"Digite o cpf");
            novaPf.cpf = Console.ReadLine();

            bool dataValida;
            do
            {
              Console.WriteLine($"Digite a Data de Nascimento (Ex: DD/MM/AAA:) ");
              string dataNasc = Console.ReadLine();
              dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                if (dataValida)
                  {
                    novaPf.dataNascimento = dataNasc;
                  }
                else
                  {     
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Data digitada é inválida. Não é possível cadastrar Menores de 18 anos. Por favor, digite uma data válida");
                    Console.ResetColor();
                  }
            } while (dataValida == false);
    
                Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                novaPf.rendimento = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o logradouro");
                novoEndPf.logradouro = Console.ReadLine();

                Console.WriteLine($"Digite o número");
                novoEndPf.numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                novoEndPf.complemento = Console.ReadLine();

                Console.WriteLine($"Este endereço é comercial? S ou N");
                string endCom = Console.ReadLine().ToUpper();
                  if (endCom == "S")
                    {
                      novoEndPf.endComercial = true;
                    }
                  else
                    {
                      novoEndPf.endComercial = false;
                    }
                novaPf.endereco =novoEndPf;
                metodoPf.Inserir(novaPf);  
            break;
          case "2":
            //case mostrar pessoa física
            Console.Clear();
            List<PessoaFisica> listaPf = metodoPf.Ler();

              foreach (PessoaFisica cadaItem in listaPf)
                {
                  Console.Clear();
                  Console.WriteLine(@$"
                    Nome: {cadaItem.nome}
                    CPF: {cadaItem.cpf} 
                    Data Nascimento: {cadaItem.dataNascimento}
                    Rendimento: {cadaItem.rendimento}
                    Imposto: {metodoPf.PagarImposto(cadaItem.rendimento).ToString("C")}
                    Logradouro: {cadaItem.endereco.logradouro}
                    Número: {cadaItem.endereco.numero}
                    Complemento: {cadaItem.endereco.complemento}
                    Endereço comercial?: {((cadaItem.endereco.endComercial)? "Sim":"Não")}   
                  ");                                      
                 Console.WriteLine($"Aperte 'Enter' para continuar");
                 Console.ReadLine();
                }
            break;
          case "0":
            //essa opção retorna para o menu anterior.
            break;
          default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(1500);
            break;
        }      
      } while (opcaoPF != "0");
      break;
    case "2":
       //menu pessoa jurídica
      string? opcaoPj;
      do
      {
        Console.Clear();
        Console.WriteLine(@$"
        =========================================
        |   Escolha uma das opções a seguir:    |
        |_______________________________________|  
        |    1- Cadastrar Pessoa Jurídica       |
        |    2- Mostrar Pessoa Jurídica         |
        |    0- Retornar ao menu anterior       |
        =========================================
        ");
        opcaoPj = Console.ReadLine();

        PessoaJuridica novaPj = new PessoaJuridica();
        PessoaJuridica metodoPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        switch (opcaoPj)
        {
          case "1":
            //case cadastrar pessoa jurídica
            Console.Clear();
            Console.WriteLine($"Digite o nome da pessoa jurídica que deseja cadastrar");
            novaPj.nome = Console.ReadLine();

            bool cnpjValido;
              do 
              {
                Console.WriteLine($"Digite o CNPJ, Ex: 00.000.000/0001-00 ou 00000000000000 ");
                string cnpj = Console.ReadLine();

                cnpjValido = metodoPj.ValidarCnpj(cnpj);
                if (cnpjValido)
                  {
                    novaPj.cnpj = cnpj;
                  }
                else
                  {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Cnpj inválido, por favor digite um cnpj válido");
                    Console.ResetColor();                    
                  }                        
              } while (cnpjValido == false);

                Console.WriteLine($"Digite a razão social");
                string CNPJ = Console.ReadLine();

                Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                novaPj.rendimento = float.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o logradouro");
                novoEndPj.logradouro = Console.ReadLine();

                Console.WriteLine($"Digite o número");
                novoEndPj.numero = int.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                novoEndPj.complemento = Console.ReadLine();

                Console.WriteLine($"Este endereço é comercial? S ou N");
                string endCom = Console.ReadLine().ToUpper();
                  if (endCom == "S")
                    {
                      novoEndPj.endComercial = true;
                    }
                  else
                    {
                      novoEndPj.endComercial = false;
                    }
                novaPj.endereco =novoEndPj;
                metodoPj.Inserir(novaPj);  
            break;
          case "2":
            //case mostrar pessoa jurídica
            Console.Clear();
            List<PessoaJuridica> listaPj = metodoPj.Ler();

              foreach (PessoaJuridica cadaItem in listaPj)
                {
                  Console.Clear();
                  Console.WriteLine(@$"
                    Nome: {cadaItem.nome}
                    CNPJ: {cadaItem.cnpj} 
                    Razão Social: {cadaItem.razaoSocial}
                    Rendimento: {cadaItem.rendimento}
                    Imposto: {metodoPj.PagarImposto(cadaItem.rendimento).ToString("C")}
                    Logradouro: {cadaItem.endereco.logradouro}
                    Número: {cadaItem.endereco.numero}
                    Complemento: {cadaItem.endereco.complemento}
                    Endereço comercial?: {((cadaItem.endereco.endComercial)? "Sim":"Não")}   
                  ");                                      
                 Console.WriteLine($"Aperte 'Enter' para continuar");
                 Console.ReadLine();
                }
            break;
          case "0":
            //essa opção retorna para o menu anterior.
            break;
          default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(1500);
            break;
        }      
      } while (opcaoPj != "0");
      break;
    case "0":
      BarraCarregamento("Finalizando", 100);
      break;
    default:
      Console.Clear();
      Console.WriteLine($"Opção inválida, por favor digite outra opção");
      Thread.Sleep(1500);
      break;
  }
}while(opcao !="0");




static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkGray;
    //Console.ForegroundColor = ConsoleColor.DarkRed;

    Console.Write($"{texto} ");
      for (var contador = 0; contador < 25; contador++)
       {
          Console.Write(". ");
          Thread.Sleep(tempo);
       }
    Console.ResetColor();
}
