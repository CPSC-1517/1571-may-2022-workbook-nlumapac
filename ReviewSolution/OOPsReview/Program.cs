// See https://aka.ms/new-console-template for more information
using OOPsReview.Data;

Console.WriteLine("Hello, World!");

Employment employment = new Employment("Level 5 Programmer",SupervisoryLevel.Supervisor, -15.9);
Console.WriteLine(employment.ToString());