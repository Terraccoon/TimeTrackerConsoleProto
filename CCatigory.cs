using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimeTrackerConsoleProto
{
    internal class CCatigory
    {
        public string Name;
        public int Id;

        public System.Timers.Timer CatTimer;

        public List<CTopic> TopicList;

        public CCatigory(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public void addTopic()
        {
            string newTopicName = "NEW";
            int newTopicID = (TopicList.Count -1);

            CTopic newTopic = new CTopic(newTopicName, newTopicID);
            TopicList.Add(newTopic);
        }

        public void totalTimerAddUp()
        {
            foreach (CTopic topic in TopicList)
            {
                //  CatTimer.TimeStamp += topic.Timestamp;
            }

            // Show CatTimer.TimeStamp
        }

        
        // TopicTimer ToTotalTopicTime






    }
}
