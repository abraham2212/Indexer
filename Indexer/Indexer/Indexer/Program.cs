// See https://aka.ms/new-console-template for more information
using Indexer.Models;

Book book1 = new Book() { Id = 1, Name = "XOSROV" };
Book book2 = new Book() { Id = 2, Name = " 7 GOZEL" };

Library library=new Library();
library[0] = book1;
library[2] = book2;

Console.WriteLine(library[0].Name);
Console.WriteLine(library[1].Name);