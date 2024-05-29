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

        private Logic() { }

        public static Logic Instance => _instance ??= new Logic();
        

        public List<CTimer> TimerList = new List<CTimer>();


        public void fillList()
        {
            CTimer Time1 = new CTimer("TestTimer1");
            CTimer Time2 = new CTimer("TestTimer2");
            TimerList.Add(Time1);
            TimerList.Add(Time2);
        }










    }
}
