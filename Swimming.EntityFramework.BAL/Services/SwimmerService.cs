﻿using Swimming.Abstractions.Attributes;
using Swimming.Abstractions.Interfaces;
using Swimming.Abstractions.Models;
using Swimming.EntityFramework.DAL.Repositories;
using System;

namespace Swimming.EntityFramework.BL.Services
{
    public class SwimmerService
    {
        public bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public void AddSwimmwer()
        {
            Console.Write("Enter Swimmer name:");
            string swimmerName = Console.ReadLine();

            while (!IsAllAlphabetic(swimmerName))
            {
                Console.WriteLine("Incorrect Name! Try again");
                swimmerName = Console.ReadLine();
            }

            Console.Write("Enter Swimmer surname:");
            string swimmerSurname = Console.ReadLine();

            while (!IsAllAlphabetic(swimmerSurname))
            {
                Console.WriteLine("Incorrect Surname! Try again");
                swimmerSurname = Console.ReadLine();
            }

            Console.Write("Enter Swimmer age:");
            string age = Console.ReadLine();
            int tryint;

            while ((!int.TryParse(age, out tryint)) || (!AgeValidationAttribute.IsValidSwimmerAge(Convert.ToInt32(age))))
            {
                Console.WriteLine("Incorrect Age! Try again ");
                age = Console.ReadLine();
            }

            Console.Write("Enter Coach Id:");
            string swimmerCoachId = Console.ReadLine();

            while (!int.TryParse(swimmerCoachId, out tryint))
            {
                Console.WriteLine("Incorrect Id! Try again ");
                swimmerCoachId = Console.ReadLine();
            }

            try
            {
                Swimmer swimmer = new Swimmer { FirstName = swimmerName, LastName = swimmerSurname, Age = Convert.ToInt32(age), CoachId = Convert.ToInt32(swimmerCoachId) };
                using (swimmingContext swimdb = new swimmingContext())
                {
                    ISwimmerManager<Swimmer> swimmerManager = new SwimmerRepository(swimdb);
                    swimmerManager.Add(swimmer);
                    Console.WriteLine("Swimmer is added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteSwimmer()
        {
            try
            {
                Console.WriteLine("Enter Swimmer id:");
                string id = Console.ReadLine();
                int tryint;

                while (!int.TryParse(id, out tryint))
                {
                    Console.WriteLine("Incorrect id! Try again ");
                    id = Console.ReadLine();
                }

                using (swimmingContext swimdb = new swimmingContext())
                {
                    ISwimmerManager<Swimmer> swimmerManager = new SwimmerRepository(swimdb);
                    swimmerManager.Delete(Convert.ToInt32(id));
                    Console.WriteLine("Swimmer is deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SelectSwimmers()
        {
            try
            {
                Console.Write("Swimmers:\n");
                Console.WriteLine("\t\tId \tFirstName \tSecondName\t\tAge");

                using (swimmingContext swimdb = new swimmingContext())
                {
                    ISwimmerManager<Swimmer> swimmerManager = new SwimmerRepository(swimdb);
                    var swimmers = swimmerManager.GetList();
                    foreach (Swimmer c in swimmers)
                    {
                        Console.WriteLine($"{c.Id,15}{c.FirstName,15} {c.LastName,17} {c.Age,15}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SelectSwimmersByAge()
        {
            Console.WriteLine("Enter age\n");
            string age = Console.ReadLine();
            int tryint;

            while (!int.TryParse(age, out tryint))
            {
                Console.WriteLine("Incorrect age! Try again ");
                age = Console.ReadLine();
            }

            try
            {
                Console.Write("Swimmers:\n");
                Console.WriteLine("\t\tId \tFirstName \tSecondName\t\tAge");

                using (swimmingContext swimdb = new swimmingContext())
                {
                    ISwimmerManager<Swimmer> swimmerManager = new SwimmerRepository(swimdb);
                    var swimmers = swimmerManager.GetListByAge(Convert.ToInt32(age));
                    foreach (Swimmer c in swimmers)
                    {
                        Console.WriteLine($"{c.Id,15}{c.FirstName,15} {c.LastName,17} {c.Age,15}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
