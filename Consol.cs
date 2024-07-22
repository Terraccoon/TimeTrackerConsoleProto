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
            loadTimerData();

            userAction(showMainMenu());


            // Program start
            //Logic.Instance.fillList();
            //SaveData.SaveInFile();

            //loadTimerData();
            //logicMenu();

        }
        
        private static void loadTimerData()
        {
            //SaveData.load
            #region LoadUX
            Console.WriteLine("Load Data. Please wait.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Load Data. Please wait..");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Load Data. Please wait...");
            Thread.Sleep(500);
            Console.Clear();
            #endregion
        }

        static int showMainMenu()
        {
            string UserInput;
            int Userchoice = 0;

            Console.Clear();
            Console.WriteLine("Welcome to the main menu \n\n");
            Console.WriteLine("Please choose an option\n");
            Console.WriteLine("1. Open a Catigorys");
            Console.WriteLine("2. Delete a Catigory");
            Console.WriteLine("3. Edit a Catigory");
            Console.WriteLine("4. Close App");

            try
            {
                UserInput = Console.ReadLine();
                if ((UserInput.Length == 1) && (UserInput != null))
                {
                    Userchoice = Convert.ToInt32(UserInput);
                }
                else
                {
                    throw new Exception("Input needs to be one valid Number.");
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                
                Console.WriteLine($"Input couldnt be read{e.Message} \n");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();

                showMainMenu();
            }

            return Userchoice;
        }

        static void userAction(int userchoice)
        {
            Logic logic = Logic.Instance;
            switch (userchoice)
            {
                case 1:
                    // Open Cat
                    if(logic.Cats.Count != 0)
                    {
                        Console.Clear();
                        foreach (CCatigory cat in logic.Cats)
                        {
                            Console.WriteLine(cat. cat.Name.ToString());
                        }
                    }
                    
                    break;

                case 2:
                    break;

                case 3:

                    break;

                case 4:
                    break;
            
            }
        }
    }
}