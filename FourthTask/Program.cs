using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite Server = new WebSite();
            Console.WriteLine(Server);
            Server.Input();
            Console.WriteLine(Server);
            Console.WriteLine("Enter New URL: ");
            Server.ChangeUrl(Console.ReadLine());
            Console.WriteLine(Server);
        }

        class WebSite
        {
            private string port { get; set; }
            private string URL { get; set; }
            private string ip { get; set; }

            public WebSite()
            {
                port = "8888";
                URL = $"https:\\localhost:{port}";
                ip = "127.0.0.1";
            }

            public WebSite(string URL, string Port, string Ip)
            {
                this.URL = URL;
                this.port = Port;
                this.ip = Ip;
            }

            public void ChangePort(string Port)
            {
                this.port = Port;
            }

            public void ChangeUrl(string URL)
            {
                this.URL = URL;
            }
            public void ChangeIp(string Ip)
            {
                this.ip = Ip;
            }
            public void Input()
            {
                Console.WriteLine("Enter URL: ");
                URL = Console.ReadLine();
                Console.WriteLine("Enter Port:  ");
                port = Console.ReadLine();
                Console.WriteLine("Enter Ip: ");
                ip = Console.ReadLine();
            }

            public override string ToString()
            {
                return string.Format
                    (
                    $"\nURL: {URL}" +
                    $"\nPort: {port}" +
                    $"\nIp: {ip}\n"
                    );
            }
        }
    }
}
