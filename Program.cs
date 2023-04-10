// See https://aka.ms/new-console-template for more information
using modul8_1302210070;
using System;

BankTransferConfig conf = new BankTransferConfig();

string message1 = (conf.config.lang == "en") ?
"Please insert the amount of money to transfer:" :
"Masukkan jumlah uang yang akan di-transfer:";
Console.WriteLine(message1);


