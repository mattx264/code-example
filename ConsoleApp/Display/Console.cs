using Entiry.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Display
{
    public class MyConsole : Display
    {
        public MyConsole():base("console")
        {
        }
        public void Write(Message message)
        {
            if (isWrite == true)
            {
                Console.WriteLine(message.Msg);
                Console.ReadKey();
            }
        }
    }
}
