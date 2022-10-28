using System;

namespace MAD4UFOS
{
    class Program
    {
        #region Predefined Code, DO NOT MODIFY
        const string HEADER = "MAD4UFOS Data Collection System";
        const string DASHER = "--------";
        static int index = 0;

        static readonly string[] menu = { 
            "Enter a Sighting", 
            "Display all sightings", 
            "Display sightings filtered by species", 
            "Display Record Count", 
            "Exit" 
        };

        static Alien[] aliens = new Alien[1000];
        #endregion

        static void Main(string[] args)
        {
            Console.Title = HEADER;

            #region STUDENT CODE HERE
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            DisplayHeader();

            /*
             * This while loop is controlled by the continueProgram bool variable
             * For exiting this loop, set the continueProgram variable to false as needed
             * 
             * You may optional use Environment.Exit(0)
             * */
            bool continueProgram = true;
            while (continueProgram)
            {
                /*
                 * Uncomment this method when you are ready to code for it
                 * Create the method in the Region STUDENT METHOD CODES HERE
                 * */
                DisplayMenu();

                switch (GetMenuSelection())
                {
                    case 1:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        EnterASighting();

                        break;
                    case 2:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        DisplayAllSightings();

                        break;
                    case 3:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        FilterBySpecies();

                        break;
                    case 4:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        DisplayRecordCount();

                        break;
                    case 5:
                        /*
                         * Uncomment this method when you are ready to code for it
                         * Create the method in the Region STUDENT METHOD CODES HERE
                         * */
                        continueProgram = !Exit();

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("==> Invalid choice");
                        Console.ResetColor();

                        break;
                }
            }
            #endregion
        }

        #region STUDENT METHOD CODES HERE
        //  Code for DisplayHeader() here
        public static void DisplayHeader()
        {
            Console.WriteLine(HEADER);
            Console.WriteLine(DateTime.Now.ToString());
        }
        //  Code for DisplayMenu() here
        public static void DisplayMenu()
        {
            Console.WriteLine("Main menu");
            Console.WriteLine(DASHER);

            for(int i = 1; i<=menu.Length; i++){
                Console.WriteLine($"{i}. {menu[i-1]}");
            }

            Console.Write($"Enter your selection (1-{menu.Length}):");
        }
        //  Code for EnterASighting() here
        public static void EnterASighting()
        {
            Console.Write("Enter the alien's name:");
            string name = Console.ReadLine();

            Console.Write("Enter the date:");
            string date = Console.ReadLine();

            Console.Write("Enter the location:");
            string location = Console.ReadLine();

            Alien alien  = new Alien(name, date, location);
            aliens[index] = alien;
            index++;
        }
        //  Code for DisplayAllSightings() here
        public static void DisplayAllSightings()
        {
            DisplaySightingsHeader();
            int count = 0;
            foreach(Alien alien in aliens){
                if(alien is not null){
                    Console.WriteLine(alien);
                    count++;
                }
                    
            }
            Console.WriteLine($"==> {count} record(s) displayed");
        }
        //  Code for FilterBySpecies() here
        public static void FilterBySpecies()
        {
            Console.Write("Enter the specie to search by:");
            string filter = Console.ReadLine();

            int count = 0;
            foreach(Alien alien in aliens)
            {
                if(alien is not null && filter==alien.Name)
                {
                    Console.WriteLine(alien);
                    count++;
                }
            }
            Console.WriteLine($"==> {count} record(s) displayed");
        }
        //  Code for DisplayRecordCount() here
        public static void DisplayRecordCount()
        {
            Console.WriteLine($"There are {index} alien(s) sighted");
        }
        //  Code for Exit() here
        public static bool Exit()
        {
            Console.Write("Are you super sure:");
            string checking = Console.ReadLine();

            if(checking.Substring(0).ToUpper() == "Y"){
                Console.WriteLine($"Thank you for using {HEADER}. Goodbye..not");
                return true;
            }

            return false;
        }
        
        #endregion

        #region PREDEFINED CODE, DO NOT MODIFY
        /// <summary>
        /// This method will validate that the menu choice is valid.
        /// </summary>
        /// <returns>Returns the int value for the menu selection made</returns>
        private static int GetMenuSelection()
        {
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= menu.Length)
                return choice;

            return -1;
        }

        /// <summary>
        /// This method takes care of increasing the array by 1 index so that any new Alien object can be added to the aliens Array
        /// </summary>
        /// <param name="aliens">Accepts a parameter of Aliens</param>
        private static void IncreaseAliensArraySize()
        {
            Array.Resize(ref aliens, aliens.Length + 1);
        }

        /// <summary>
        /// This method can be used when you want to display a header for all the Alien sightings before listing them
        /// </summary>
        private static void DisplaySightingsHeader()
        {
            Console.WriteLine($"{"Species", Alien.RIGHT_SPACER} {"Date", Alien.LEFT_SPACER} {"Location", Alien.RIGHT_SPACER}");
            Console.WriteLine($"{DASHER, Alien.RIGHT_SPACER} {DASHER, Alien.LEFT_SPACER} {DASHER, Alien.RIGHT_SPACER}");
        }
        #endregion
    }
}

