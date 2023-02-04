using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    public class Doctor : IProfession
    {
        public void print()
        {
            Console.WriteLine("I am a doctor");
        }
    }
}
