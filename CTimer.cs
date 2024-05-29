using System;
using System.Timers;

namespace TimeTrackerConsoleProto
{
    public class CTimer
    {
        public System.Timers.Timer timer;
        public string Name;




        public CTimer(string name)
        {
            Name = name;
        }


        public void Start()
        {
            timer.Start();
        }

        public void Stop() 
        {
            timer.Stop(); 
        }



        /*public bool setTime()
        {
            // set a specific time to the time object
        }*/


























    }    
}
