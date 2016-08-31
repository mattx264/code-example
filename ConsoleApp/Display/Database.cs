using Entiry.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Display
{
    class Database : Display
    {
        public Database() : base("database")
        {
        }
        public void Write(Message message)
        {
            if (isWrite == true)
            {
               //save in db
            }
        }
    }
}
