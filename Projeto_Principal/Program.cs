﻿using Uc9_proj.classes;
/*
PessoaFisica novaPF = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPf = new PessoaFisica(); 

novaPF.nome = "Barbara";
novaPF.dataNascimento = "08/12/1996";
novaPF.cpf = "12345678900";
novaPF.rendimento = 600.0f;

novoEnd.logadouro = "Alameda Barão de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai Informatica";
novoEnd.endComercial = true;

novaPF.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPF.nome}
Endereço: {novaPF.endereco.logadouro}, {novaPF.endereco.numero}
Maior de idade: {metodoPf.validarDataNascimento (novaPF.dataNascimento)} 
");
*/



/*
novaPF.nome = "barbara";
Console.WriteLine(novaPF.nome);
Console.WriteLine("Nome: " + novaPF.nome);
Console.WriteLine($"Nome: {novaPF.nome}");
*/

//Console.WriteLine(novaPF.validarDataNascimento(new DateTime(2000,01,01)));
//Console.WriteLine(novaPF.validarDataNascimento("01-01-2000"));


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
  Cnpj é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)};
");