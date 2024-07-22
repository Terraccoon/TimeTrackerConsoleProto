using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerConsoleProto
{
    public class Logic // Singelton
    {
        private static Logic _instance;

        private Logic() 
        { 
        
        }

        public static Logic Instance => _instance ??= new Logic();
        
        // Maybe a Catigory carries a list of Topics and i just make a List of Catigorys
        //public List<CTimer> TimerList = new List<CTimer>();

        public List<CCatigory> Cats = new List<CCatigory>();

        public void addNewCat(string Name)
        {
            Cats.Add()


        }
        










    }
}
