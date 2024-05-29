using System.ComponentModel.Design;
using System.Net;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;

namespace TimeTrackerConsoleProto
{
    internal class Consol
    {
        static void Main(string[] args)
        {
            // Program start
            Logic.Instance.fillList();
            SaveData.SaveInFile();

            //loadTimerData();
            //logicMenu();

        }
        

        private static void loadTimerData()
        {
            //SaveData.load
            #region LoadUX
            Console.WriteLine("Load Data. Please wait.");
            Thread.Sleep(1_000);
            Console.Clear();
            Console.WriteLine("Load Data. Please wait..");
            Thread.Sleep(1_000);
            Console.Clear();
            Console.WriteLine("Load Data. Please wait...");
            Thread.Sleep(1_000);
            Console.Clear();
            #endregion
        }

        static void logicMenu()
        {
            switch (showMainMenu())
            {
                case 1: //Open Timer

                    break;

                case 2: //Create Timer

                    break;

                case 3: //Delete Timer

                    break;

                case 4: //Edit Timer

                    break;

                case 5: // Close App

                    break;

                default:
                    Console.WriteLine("Wrong Input! Try Again.");
                    Console.ReadKey();
                    logicMenu();
                    break;
            }
        }

        static int showMainMenu()
        {
            string UserInput;
            int Userchoice = 0;

            Console.Clear();
            Console.WriteLine("Welcome to the main menu");
            Console.WriteLine("Please choose an option");
            // Open Timer
            // Create Timer
            // Delete timer
            // close

            try
            {
                UserInput = Console.ReadLine();
                if ((UserInput.Length == 1) && (UserInput != null))    
                {
                    Userchoice = Convert.ToInt32(UserInput);
                }
                else
                {
                    throw new Exception("Input needs to be one valid Char.");
                }                
            }
            catch (ArgumentException e)
            {
                Console.Clear();
                Console.WriteLine($"Input couldnt be read{e.Message}");
                Console.ReadKey();
            }
            finally
            {
                showMainMenu();
            }
            
            return Userchoice;
        }

        void showTimer()
        {
            // cw Show Timer name
            // Show the time
            // ask start / back ("Start Timer? :1" /n "Back to Menu :0")
            // Start Time => Show name, show time, ask for stop (every second)
            // Back to menu => show menu
        }

        void openTimer(int SelectedTimer)
        {
           
        }

        void createTimer()
        {

        }

        void closeTimer()
        {

        }


    }
}