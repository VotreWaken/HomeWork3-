using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine Magazine = new Magazine();
            Magazine.Input();
            Console.WriteLine(Magazine);
            Console.WriteLine("Enter New Description: ");
            Magazine.ChangeDescription(Console.ReadLine());
            Console.WriteLine(Magazine);
        }

        class Magazine
        {
            private string Name { get; set; }
            private string FoundationYear { get; set; }
            private string Description { get; set; }
            private string Number { get; set; }
            private string Email { get; set; }

            public Magazine()
            {
                Name = "";
                FoundationYear = "";
                Description = "";
                Number = "";
                Email = "";
            }
            public Magazine(string Name, string Year, string Description, string Number, string Email)
            {
                this.Name = Name;
                this.FoundationYear = Year;
                this.Description = Description;
                this.Number = Number;
                this.Email = Email;
            }
            public void Input()
            {
                Console.WriteLine("Enter Name: ");
                this.Name = Console.ReadLine();
                Console.WriteLine("Enter Foundation Year: ");
                this.FoundationYear = Console.ReadLine();
                Console.WriteLine("Enter Description: ");
                this.Description = Console.ReadLine();
                Console.WriteLine("Enter Number: ");
                this.Number = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                this.Email = Console.ReadLine();
            }
            public void ChangeName(string Name)
            {
                this.Name = Name;
            }
            public void ChangeYear(string Year)
            {
                this.FoundationYear = Year;
            }
            public void ChangeDescription(string Description)
            {
                this.Description = Description;
            }
            public void ChangeNumber(string Number)
            {
                this.Number = Number;
            }
            public void ChangeEmail(string Email)
            {
                this.Email = Email;
            }
            public override string ToString()
            {
                return string.Format
                    (
                    $"\nName: {Name}" +
                    $"\nyear: {FoundationYear}" +
                    $"\nDescription: {Description}" +
                    $"\nNumber: {Number}" +
                    $"\nEmail: {Email}"
                    );
            }
        }
    }
}
