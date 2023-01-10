// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Xml;



using System;
using System.Linq;
using System.Collections.Generic;
using GatasdaManu.Repository.Interface;
using GatasdaManu.Domain;
using MongoDB.Driver;

Console.WriteLine("Olá, Mundo!");
IBandRepository bandRepository= new BandRepository();
try
{
    Console.WriteLine("Escolha o ano da sua banda: ");
    var year = Console.ReadLine();
    //Console.ReadKey();

    var banda = await bandRepository.GetBandByYear(int.Parse(year));
    if (banda.Any()) {
        Console.WriteLine(banda.FirstOrDefault().Year + " - " + banda.FirstOrDefault().Name);
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("NOT FOUND");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}










