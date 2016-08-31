using ConsoleApp.Display;
using ConsoleApp.Helper;
using Entiry.Entities;
using System.Threading.Tasks;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            getMessage().Wait();
 
        }
        static async Task getMessage()
        {
            Message message = await Api.callApi("api/message");
            new MyConsole().Write(message);
            new Database().Write(message);
        }
    }
}
