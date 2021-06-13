using FinalProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Domain
{
    class ManagerMethods
    {
        public ManagerMethods()
        {

        }

        public static List<Author> authors = new List<Author>() { 
            new Author() { Name = "gio", Lastname = "gagnidze", Birthdate = "22/06/1968", City = "Tbilisi", Country = "Georgia", Email = "exmaple@gmail.com", Phonenumber= "577112211", Privatenumber = "010040566"},
            new Author() { Name = "gio", Lastname = "gagnidze", Birthdate = "15/11/1972", City = "Tbilisi", Country = "Georgia", Email = "exm@gmail.com", Phonenumber= "599223366", Privatenumber = "010040567"}
        };

        public static List<Book> books = new List<Book>();

        public static void AddAuthor(Author author)
        {
            authors.Add(author);
        }
    }
}
