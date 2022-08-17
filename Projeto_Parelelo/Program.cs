
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
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Red;

 Console.Write("carregando");

for(var contador = 0; contador < 10; contador ++){
  Console.Write(".");
  Thread.Sleep(500); 
}
Console.ResetColor();
Console.Clear();

string? opcao;
do
{
    Console.WriteLine(@$"
  ***********************************************************
  ***********************************************************
  *                                                         *
  *           Escolha uma das opções a seguir:              *
  *               1 -  Conta Corrente                       *
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
        Corrente obj_cc = new Corrente("3030-0","1988",101);
        Console.WriteLine($"{obj_cc.ToString()}");
        Console.WriteLine($"Aperte 'Enter' pra continuar");
        Console.ReadLine();
        Console.Clear();
        
        break;
      case "2":
        Corrente obj_cpp = new Corrente("1010-0","1978",3);
        Console.WriteLine($"{obj_cpp.ToString()}");
        Console.WriteLine($"Aperte 'Enter' pra continuar");
        Console.ReadLine();
        Console.Clear();
        break;
      case "0":
        Console.WriteLine($"Você entrou na opção 0");
        break;
      default:
      Console.Clear();
      Console.WriteLine($"Opção inválida, por favor digite outra opção");
      Thread.Sleep(2000);
      Console.Clear();
        break;
  }
} while (opcao != "0");





/*
Conta obj_conta = new Conta("7800-8","8898");
//obj_conta.numero = "7800-8";
//obj_conta.setNumero("7800-8");
//obj_conta.agencia = "8898";
//obj_conta.saldo = 1000;
//obj_conta.setSaldo(1000);
Console.WriteLine($"Agencia: {obj_conta.agencia}"); 
Console.WriteLine($"Numero: {obj_conta.numero}");
Console.WriteLine($"Saldo: {obj_conta.getSaldo()}");



string ret;
ret = obj_cc.Tostring();
consoleWriteline($"{ret}");

Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"****************");

//obj_cc.Depositar(100);
Console.WriteLine($"{obj_cc.Depositar(100)}");
Console.WriteLine($"{obj_cc.ToString()}");
Console.WriteLine($"****************");

Console.WriteLine($"{obj_cc.Sacar(300)}");
Console.WriteLine($"{obj_cc.ToString()}");
*/
