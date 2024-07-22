using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TimeTrackerConsoleProto
{
    internal class CTopic
    {
        public string Name;

        public int Id;

        public System.Timers.Timer Timer;

        public CTopic(string name, int ID)
        {
            Name = name;
            Id = ID;
        }

        public void ChangeName(string newName)
        {
            if (newName == null)
            {
                Name = newName;
            }
        }

        public void startTimer()
        {
            Timer.Start();
        }

        public void stopTimer()
        {
            Timer.Stop();
        }

        public string addTimeToTimer(int minutes)
        {

            return "add *** to self.name Timer";
        }

        public string changeTimerTime(int newTime)
        {

            return "self.name Timer was set to ***";
        }


    }
}
