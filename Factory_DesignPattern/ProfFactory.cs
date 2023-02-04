using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DesignPattern
{
    public class ProfFactory
    {
        IProfession  profession = null;
        public IProfession GetProfession(string typeProf)
        {
            if(typeProf == null)
            {

                return null;
            }
            switch (typeProf)
            {
                case "Engineer":
                    return new Engineer();
                    break;
                case "Doctor":
                    return new Doctor();
                    break;

            }
            return null;
        }
        

    }
}
