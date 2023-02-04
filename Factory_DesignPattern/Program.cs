using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProfFactory profFactory = new ProfFactory();

            IProfession doctor = profFactory.GetProfession("Doctor");
            doctor.print();

            IProfession engineer = profFactory.GetProfession("Engineer");
            engineer.print();   

        }
    }
}
