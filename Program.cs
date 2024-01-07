﻿﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - IMPLEMENTADO

Console.WriteLine("");
Console.WriteLine("Inicializando testes no Nokia");
Console.WriteLine("");

Nokia celular1  = new Nokia("987654321");
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("You tube");

Console.WriteLine("");
Console.WriteLine("Inicializando testes no Iphone");
Console.WriteLine("");

Iphone celular2 = new Iphone("192837465");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Telegram");
Console.WriteLine("");