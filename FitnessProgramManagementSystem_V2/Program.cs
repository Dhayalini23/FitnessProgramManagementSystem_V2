using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgramRepository repository = new FitnessProgramRepository();

            bool exit=false;
            while (!exit) 
            {
                Console.Clear();
                Console.WriteLine("FitnessProgram Management System:");
                Console.WriteLine("1. Add a FitnessProgram");
                Console.WriteLine("2. View All FitnessPrograms");
                Console.WriteLine("3. Update a FitnessProgram");
                Console.WriteLine("4. Delete a FitnessProgram");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option: ");
                string option= Console.ReadLine();
            }

            switch (repository)
            {
                case "1":
                    Console.WriteLine("Add a FitnessProgram");
                    CreateFitnessProgram(repository);
                    break;
                case "2":
                    Console.WriteLine(" View All FitnessProgram");
                    ReadFitnessPrograms(repository);
                    break;
                case "3":
                    Console.WriteLine("Update a FitnessProgram");
                    UpdateFitnessProgram(repository);
                    break;
                case "4":
                    Console.WriteLine("Delete a FitnessProgram\"");
                    DeleteFitnessProgram(repository);
                    break;
                case "5":
                    Console.WriteLine(" Exit");
                   exit = true;
                    break;
            }
            if(!exit){
                Console.WriteLine("Choose an option: 1");

            }

        }

        private static void CreateFitnessProgram(FitnessProgramRepository repository)
        {
            Console.WriteLine("Enter FitnessProgram ID");
            string ID = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Title");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Duration");
            string Duration = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Price");
            string Price = Console.ReadLine();

            Console.WriteLine("FitnessProgram added successfully.");

            //manager.CreateFitnessProgram(ID, Title, Duration, Price);
        }
        private static void UpdateFitnessProgram(FitnessProgramRepository repository)
        {
            Console.WriteLine("Enter FitnessProgram ID to update");
            string ID = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Title");
            string Title = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Duration");
            string Duration = Console.ReadLine();

            Console.WriteLine("Enter FitnessProgram Price");
            string Price = Console.ReadLine();

            Console.WriteLine("FitnessProgram Updated successfully.");

            repository.UpdateFitnessProgram(ID, Title, Duration, Price);
        }

        private static void DeleteFitnessProgram(FitnessProgramRepository repository)
        {
            Console.WriteLine("Enter FitnessProgram ID to deleted");
            string ID = Console.ReadLine();

   

            Console.WriteLine("FitnessProgram deleted successfully.");

            repository.DeleteFitnessProgram(ID);
        }
    }

        }
    

