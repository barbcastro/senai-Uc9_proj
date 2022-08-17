using Uc9_proj.classes;

Console.WriteLine(@$"
==============================================
|    Bem vindo ao sistema de cadastro de     |
|         Pessoas Físicas e Jurídicas        |
==============================================
");

/* Código comentado pois, foi criado um método estatico para evitarrepetição de código
  Console.BackgroundColor = ConsoleColor.DarkRed;
  Console.ForegroundColor = ConsoleColor.Red;
  Console.Write("Carregando");

  for (var contador = 0; contador < 36; contador ++){
      Console.Write(".");
      Thread.Sleep(100);
  }
  
  Console.ResetColor();
  */
BarraCarregamento ("Carregando", 100);

  string? opcao;
  do 
  {
    Console.Clear();
    Console.WriteLine(@$"
       ========================================
       |  Escolha uma das opções a seguir:    |
       |______________________________________|
       |        1- Pessoa Física              |
       |        2- Pessoa Jurídica            |
       |                                      |
       |        0 - Sair                      |
       ========================================
    ");

      opcao = Console.ReadLine();

        switch (opcao)
        {
          case "1":
                PessoaFisica novaPF = new PessoaFisica();
                Endereco novoEnd = new Endereco();
                PessoaFisica metodoPf = new PessoaFisica(); 
                novaPF.nome = "Barbara";
                novaPF.dataNascimento = "08/12/1996";
                novaPF.cpf = "12345678900";
                novaPF.rendimento = 2000.0f;
                novoEnd.logadouro = "Alameda Barão de Limeira";
                novoEnd.numero = 539;
                novoEnd.complemento = "Senai Informatica";
                novoEnd.endComercial = true;
                novaPF.endereco = novoEnd;
                Console.WriteLine(@$"
                    Nome: {novaPF.nome}
                    Endereço: {novaPF.endereco.logadouro}, {novaPF.endereco.numero}
                    Maior de idade: {(metodoPf.validarDataNascimento (novaPF.dataNascimento) ? "Sim": "Não")} 
                    Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPF.rendimento).ToString("c")};
                    ");
                Console.WriteLine($"Aperte 'Enter' pra continuar");
                Console.ReadLine();   
                break;
          case "2":
                PessoaJuridica metodoPj = new PessoaJuridica ();
                PessoaJuridica novaPj = new PessoaJuridica();
                Endereco novoEndPj = new Endereco();
                novaPj.nome = "NomePj";
                novaPj.cnpj = "00000000000000";
                novaPj.razaoSocial = "Razão Social Pj";
                novaPj.rendimento = 8000.50f;
                novoEndPj.logadouro = "Alameda Barão de Limeira";
                novoEndPj.numero = 539;
                novoEndPj.complemento = "Senai Informatica";
                novoEndPj.endComercial = true;
                novaPj.endereco = novoEndPj;
                Console.WriteLine(@$"
                    Nome: {novaPj.nome}
                    Razão Social: {novaPj.razaoSocial}
                    Cnpj: {novaPj.cnpj}
                    Cnpj é válido: {(metodoPj.ValidarCnpj(novaPj.cnpj)?"Sim":"Não")}
                    Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("c")};
                  ");
                    


                Console.WriteLine($"Aperte 'Enter' pra continuar");
                Console.ReadLine();   
                break;
          case "0":
                Console.Clear(); 
                Console.WriteLine("Obrigada por utilizar nosso sistema");

                /* Código comentado pois, foi criado um método estatico para evitarrepetição de código
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Finalizando");
                
                for (var contador = 0; contador < 36; contador ++)
                {
                    Console.Write(".");
                    Thread.Sleep(100);
                }     
                Console.ResetColor();
                */
                BarraCarregamento ("Finalizando", 200);
                break;
          default:
                Console.Clear();
                Console.WriteLine($"Opção inválida, por favor digite outra opção");
                Thread.Sleep(3000);
                break;   
        }
  } while (opcao != "0");      

  static void BarraCarregamento (string texto, int tempo){
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{texto}");
            
    for (var contador = 0; contador < 36; contador ++)
          {
           Console.Write(".");
           Thread.Sleep(tempo);
          }     
    Console.ResetColor();
}









