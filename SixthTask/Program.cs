using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store Store = new Store();
            Store.Input();
            Console.WriteLine(Store);
            Console.WriteLine("Enter New Address: ");
            Store.ChangeDescription(Console.ReadLine());
            Console.WriteLine(Store);
        }

        class Store
        {
            private string Name { get; set; }
            private string Address { get; set; }
            private string Description { get; set; }
            private string Number { get; set; }
            private string Email { get; set; }

            public Store()
            {
                Name = "";
                Address = "";
                Description = "";
                Number = "";
                Email = "";
            }
            public Store(string Name, string Address, string Description, string Number, string Email)
            {
                this.Name = Name;
                this.Address = Address;
                this.Description = Description;
                this.Number = Number;
                this.Email = Email;
            }
            public void Input()
            {
                Console.WriteLine("Enter Name: ");
                this.Name = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                this.Address = Console.ReadLine();
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
            public void ChangeAddress(string Address)
            {
                this.Address = Address;
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
                    $"\nAddress: {Address}" +
                    $"\nDescription: {Description}" +
                    $"\nNumber: {Number}" +
                    $"\nEmail: {Email}"
                    );
            }
        }
    }
}
