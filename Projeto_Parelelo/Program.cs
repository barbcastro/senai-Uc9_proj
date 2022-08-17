
using projeto_paralelo;

  Console.WriteLine(@$"
**********************************************************
**********************************************************
*                                                        *
*   Seja bem vindo ao Sistema de Controle Financeiro     *
*                                                        *
**********************************************************
**********************************************************
");
  List<Corrente> listaCC = new List<Corrente>();
    List<Poupanca> listaCP = new List<Poupanca>();
  
  barraCarregamento("Carregando", 200);
  Console.Clear();

string? opcao;
  do
    {
      Console.Clear();
      Console.WriteLine(@$"
***********************************************************
***********************************************************
*                                                         *
*           Escolha uma das opções a seguir:              *
*               1 - Conta Corrente                        *
*               2 - Conta Poupança                        * 
*               0 - Sair                                  *
*                                                         *
***********************************************************
***********************************************************
  ");

    opcao = Console.ReadLine();
  switch (opcao)
    {
        case "1":
          string? opcaoCC;
  do
    {     
      Console.Clear();
      Console.WriteLine(@$"
***********************************************************
***********************************************************
*                                                         *
*        Escolha uma das opções a seguir:                 *
*         1 - Cadastrar Conta Corrente                    *
*         2 - Mostrar Conta Corrente                      * 
*         0 - Voltar ao Menu Anterior                     *
*                                                         *
***********************************************************
***********************************************************
");
     opcaoCC = Console.ReadLine();

  switch (opcaoCC)
    {
        case "1":
            Console.WriteLine($"Digte o número da conta corrente: ");
            string numero = Console.ReadLine();

            Console.WriteLine($"Digte o número da agência: ");
            string agencia = Console.ReadLine();

            Console.WriteLine($"Digte o limite: ");
            double limite = double.Parse(Console.ReadLine());

            Corrente obj_cc = new Corrente(numero, agencia, limite);

            listaCC.Add(obj_cc);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastro realizado com sucesso!");
            Console.ResetColor();

            Console.WriteLine($"Aperte 'Enter' pra continuar");
            Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            if (listaCC.Count > 0)
              {
                foreach(Corrente cadaCC in listaCC)
                  {
                    Console.Clear();
                    Console.WriteLine($"{cadaCC.ToString()}");
                    Console.WriteLine($"Aperte 'Enter' para continuar");
                    Console.ReadLine();                                     
                  }
              }
            else
              {
                Console.WriteLine($"A lista esta vazia!");
                Thread.Sleep(3000);                
              }
            break;
        case "0":
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção.");
            Thread.Sleep(3000);
            break;
          }
    } while (opcaoCC != "0");
            break;
      case "2":
        //conta poupança
  string? opcaoCP;
  do
    {     
      Console.Clear();
      Console.WriteLine(@$"
***********************************************************
***********************************************************
*                                                         *
*        Escolha uma das opções a seguir:                 *
*         1 - Cadastrar Conta Poupança                    *
*         2 - Mostrar Conta Poupança                      * 
*         0 - Voltar ao Menu Anterior                     *
*                                                         *
***********************************************************
***********************************************************
");
     opcaoCP = Console.ReadLine();

  switch (opcaoCP)
    {
        case "1":
            Console.WriteLine($"Digte o número da conta poupança: ");
            string numero = Console.ReadLine();

            Console.WriteLine($"Digte o número da agência: ");
            string agencia = Console.ReadLine();

            Console.WriteLine($"Digte o aniversario: ");
            int aniversario = Int32.Parse(Console.ReadLine());

            Poupanca obj_cp = new Poupanca(numero, agencia, aniversario);

            listaCP.Add(obj_cp);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastro realizado com sucesso!");
            Console.ResetColor();

            Console.WriteLine($"Aperte 'Enter' pra continuar");
            Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            if (listaCP.Count > 0)
              {
                foreach(Poupanca cadaCP in listaCP)
                  {
                    Console.Clear();
                    Console.WriteLine($"{cadaCP.ToString()}");
                    Console.WriteLine($"Aperte 'Enter' para continuar");
                    Console.ReadLine();                                     
                  }
              }
            else
              {
                Console.WriteLine($"A lista esta vazia!");
                Thread.Sleep(3000);                
              }
            break;
        case "0":
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção.");
            Thread.Sleep(3000);
            break;
          }
    }   while (opcaoCP != "0");
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigada por utilizar nosso sistema");
            barraCarregamento("Finalizando", 200);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(2000);
            Console.Clear();
            break;
          }
    }   while (opcao != "0");


  static void barraCarregamento(string texto, int tempo)
  {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("{texto}");

    for (var contador = 0; contador < 10; contador ++)
      {
        Console.Write(".");
        Thread.Sleep(500); 
      }  
    Console.ResetColor();
  }