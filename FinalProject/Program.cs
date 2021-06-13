using FinalProject.Domain;
using FinalProject.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            User manager = new User() { Name = "giorgi", Lastname = "gagnidze", Username = "gagno2003", Password = "ragaca", Role = Roles.Manager.ToString() };

            User manager2 = new User() { Name = "avto", Lastname = "mammulashvili", Username = "givi2004", Password = "ragaca3", Role = Roles.Manager.ToString() };

            List<User> Users = new List<User>() { manager, manager2 };



            Console.WriteLine("---Login---");
            Console.Write("Username:");
            string Username = Console.ReadLine();

            Console.Write("Password:");
            string Password = Console.ReadLine();

            Validations.LoginValidation(Users, Username, Password);

            if (Validations.isLoggedIn)
            {
                Console.WriteLine("---Add Products---");
                Console.WriteLine("1.Add Author");
                Console.WriteLine("2.Delete Author");
                Console.WriteLine("3.Authors' Information");
                Console.WriteLine("4.Edit Author");

                int productNumber = Convert.ToInt32(Console.ReadLine());

                if (productNumber == 1)
                {
                    Console.Write("Name: ");
                    string AName = Console.ReadLine();

                    Console.Write("Lastname: ");
                    string ALastname = Console.ReadLine();

                    Console.Write("Private Number: ");
                    string APrivateNumber = Console.ReadLine();

                    Console.Write("BirthDate: ");
                    string ABirthDate = Console.ReadLine();

                    Console.Write("Country: ");
                    string ACountry = Console.ReadLine();

                    Console.Write("City: ");
                    string ACity = Console.ReadLine();

                    Console.Write("Phone Number: ");
                    string APhoneNumber = Console.ReadLine();

                    Console.Write("Email: ");
                    string AEmail = Console.ReadLine();

                    Author author = new Author() { Name = AName, Lastname = ALastname, Privatenumber = APrivateNumber, Birthdate = ABirthDate, 
                                                   Country = ACountry, City = ACity, Email = AEmail, Phonenumber = APhoneNumber };

                    ManagerMethods.AddAuthor(author);
                }
                else if(productNumber == 2)
                {
                   
                    foreach (var author in ManagerMethods.authors)
                    {
                     
                        Console.WriteLine(author.Email);
                    }

                    Console.Write("Email: ");
                    string AEmail = Console.ReadLine();

                    //ManagerMethods.authors.RemoveAll(author => author.Email == AEmail);
                    var result = ManagerMethods.authors.Remove(ManagerMethods.authors.SingleOrDefault(author => author.Email == AEmail));
                    if (result)
                    {
                        Console.WriteLine("Author remove successefully!");
                    }
                    else
                    {
                        Console.WriteLine("Author cannot find!");
                    }
                }
                else if(productNumber == 3)
                {

                    for (int i = 0; i < ManagerMethods.authors.Count; i++)
                    {
                        var listnumber = i + 1;
                        Console.WriteLine(listnumber + "." + ManagerMethods.authors[i].Email);
                    }

                    Console.Write("Number: ");

                    int SelectedNumber = Convert.ToInt32(Console.ReadLine());

                    var author = ManagerMethods.authors[SelectedNumber - 1];

                    Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Email}, {author.Privatenumber}, {author.Phonenumber}]");

                }
                else if(productNumber == 4)
                {
                    for (int i = 0; i < ManagerMethods.authors.Count; i++)
                    {
                        var listnumber = i + 1;
                        Console.WriteLine(listnumber + "." + ManagerMethods.authors[i].Email);
                    }

                    Console.Write("Number: ");

                    int SelectedNumber = Convert.ToInt32(Console.ReadLine());

                    var author = ManagerMethods.authors[SelectedNumber - 1];

                    Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Email}, {author.Privatenumber}, {author.Phonenumber}]");

                    Console.WriteLine("1.Name");
                    Console.WriteLine("2.Lastname");
                    Console.WriteLine("3.Privatenumber");
                    Console.WriteLine("4.Birthdate");
                    Console.WriteLine("5.Country");
                    Console.WriteLine("6.City");
                    Console.WriteLine("7.Email");
                    Console.WriteLine("8.Phonenumber");

                    Console.Write("Select Parameter:");
                    int SelectedParameterNumber = Convert.ToInt32(Console.ReadLine());

                    if (SelectedParameterNumber == 1)
                    {
                        Console.Write("Select new value for Name:");
                        string NewParameter = Console.ReadLine();
                        author.Name = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Name = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");

                    }
                    else if(SelectedParameterNumber == 2)
                    {
                        Console.Write("Select new value for Lame:");
                        string NewParameter = Console.ReadLine();
                        author.Lastname = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Lastname = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                    else if (SelectedParameterNumber == 3)
                    {
                        Console.Write("Select new value for Privatenumber:");
                        string NewParameter = Console.ReadLine();
                        author.Privatenumber = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Privatenumber = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                    else if (SelectedParameterNumber == 4)
                    {
                        Console.Write("Select new value for Birthdate:");
                        string NewParameter = Console.ReadLine();
                        author.Birthdate = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Birthdate = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                    else if(SelectedParameterNumber == 5)
                    {
                        Console.Write("Select new value for Country:");
                        string NewParameter = Console.ReadLine();
                        author.Country = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Country = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                    else if (SelectedParameterNumber == 6)
                    {
                        Console.Write("Select new value for City:");
                        string NewParameter = Console.ReadLine();
                        author.City = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].City = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                    else if (SelectedParameterNumber == 7)
                    {
                        Console.Write("Select new value for Email:");
                        string NewParameter = Console.ReadLine();
                        author.Email = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Email = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                    else if (SelectedParameterNumber == 8)
                    {
                        Console.Write("Select new value for Phonenumber:");
                        string NewParameter = Console.ReadLine();
                        author.Phonenumber = NewParameter;
                        ManagerMethods.authors[SelectedNumber - 1].Phonenumber = NewParameter;
                        Console.WriteLine($"[{author.Name}, {author.Lastname}, {author.Privatenumber}, {author.Birthdate}, " +
                                          $"{author.Country}, {author.City}, {author.Email}, {author.Phonenumber}]");
                    }
                }

               

                Console.Read();
            }
        }     
    }
}
