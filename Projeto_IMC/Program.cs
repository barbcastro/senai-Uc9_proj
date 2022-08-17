using Projeto_IMC;

Pessoa obj_pessoa = new Pessoa (88, 1.63);

//double imc = obj_pessoa.calcularIMC(obj_pessoa.peso, obj_pessoa.altura);
//string classificacao = obj_pessoa.classificarIMC(obj_pessoa.imc);
Console.WriteLine(obj_pessoa.imc);
Console.WriteLine(obj_pessoa.classificarIMC(obj_pessoa.imc));


