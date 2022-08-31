## Sistema de Cadastro de Pessoas 👨‍💻️
Projeto feito durante os encontros remotos, referente a UC9, juntamente com o auxilio do professor **Luiz Carlos Machi Lozano**,
onde se foi desenvolvido um Sistema que registra o cadastro de Pessoas Físicas e jurídicas conforme desafio da UC9. 
<hr/>

## Funcionalidades
Armazenamento de cadastro de **Pessoa Físicas**, com as seguintes informações:

- Nome; 
-  CPF;
- Data de nascimento; 
- Rendimento (calcula o imposto, baseado no valor do rendimento informado);
- Endereço (onde terá que indicar se o mesmo é comercial ou não);
- Sistema armazena registros em arquivos .txt.

Armazenamento de cadastro de **Pessoa Jurídica**, com as seguintes informações:

- Nome; 
- CNPJ;
- Razão social;
- Rendimento (calcula o imposto, baseado no valor do rendimento informado);
- Endereço (onde terá que indicar se o mesmo é comercial ou não);
- Sistema armazena registros em arquivos .csv.

## Tecnologias utilizadas

- *[.NET](https://docs.microsoft.com/pt-br/dotnet/)*
- *[C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)*

## Sistema
Programa se inicia com a seguinte tela de Boas Vindas: 
````
---------------------------------------
- Bem vindo ao Sistema de Cadastro de -
-   Pessoas Físicas e Jurídicas       -   
- -------------------------------------
````

<hr/>

 Após carregamento ira abrir o menu principal
 ````
 ------------------------------------
- Escolha uma das opções a seguir: -
------------------------------------
-       1- Pessoa Física           -
-       2- Pessoa Jurídica         -
-       0- Sair                    -
- ----------------------------------
````

Após selecionar a opção desejada, irá abrir um submenu, caso a opção seja 0, após carregamento o sistema finaliza e se encerra.
<hr/>

**Opção 1 - Menu Pessoa Física:**
````
-------------------------------------
- Escolha uma das opções a seguir:  -
-------------------------------------
-     1- Cadastrar Pessoa Física    - 
-     2- Mostrar Pessoa Física      -
-     0- Sair                       -
-------------------------------------
````

**Opção 1:** *Após  preencher todos os dados solicitados para cadastramento de **Pessoa Física**, o sistema gera um arquivo **.txt** armazenando as informações inseridas.* 
<br/>
**Opção 2:** *Se houver Pessoa Física cadastrada no arquivo **.txt** o sistema retorna o mesmo com todas as informações armazenadas.*
<br/>
**Opção 0:** *Retorna ao menu anterior.*
<hr/>

**Opção 2 - Menu Pessoa Jurídica:**
````
-------------------------------------
- Escolha uma das opções a seguir:  -
-------------------------------------
-     1- Cadastrar Pessoa Jurídica  - 
-     2- Mostrar Pessoa Jurídica    -
-     0- Sair                       -
-------------------------------------
````

**Opção 1:** *Após  preencher todos os dados solicitados para cadastramento de **Pessoa Jurídica**, o sistema gera um arquivo **.csv** armazenando as informações inseridas.* 
<br/>
**Opção 2:** *Se houver Pessoa Jurídica cadastrada no arquivo **.csv** o sistema retorna o mesmo com todas as informações armazenadas.*
<br/>
**Opção 0:** *Retorna ao menu anterior.*
<hr/>

## *Como rodar o Sistema*
````
> Clone o repositório com:
 https://github.com/barbcastro/senai-Uc9_proj.git
 ````
<hr/>

## *Principais erros:*
- Só será aceito o cadastro de **Pessoa Física** se o mesmo for maior de idade (18 anos);
- Ao digitar o CNPJ ele terá que ser no seguinte formato:  "xxxxxxxx0001xx" ou xx,xxx,xxx/0001-xx;
- **Endereço Comercial** só irá aceitar as seguintes respostas: 'SIM" ou  "S", "NÃO" ou "N";

*Se ambos parâmetros citados acima não forem preenchido corretamente, o sistema irá retornar uma mensagem de erro*   
<hr/>

**Contribuidores:**
*Luiz Carlos Machi Lozano*
<hr/>
