using System;
using System.Windows.Forms;

namespace YapDailyDoseCashierSystem
{
    class YapDailyDoseCashierSystem
    {
        public static void Main()
        {
            // First Menu to show up         
            Console.Title = "Yap Daily Dose Cashier System";
            Banner();
            Menu();
            
            Console.Write("\nSelect an option: ");
            ConsoleKeyInfo option = Console.ReadKey();
            char menuOption = option.KeyChar;

            switch (menuOption)
            {
                case '7':
                    
                    return;
            }
            
            
        }

        static void Menu()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Daily Dose YAP, How can I help you?");

            string[] menuItems = new[]
            {
                "1. Order Cheeseburger",
                "2. Order Grilled Chicken Sandwich",
                "3. Order Caesar Salad",
                "4. Order Fries ",
                "5. Order Chocolate Milkshake",
                "6. Print Receipt",
                "7. Exit Program",
            };

            foreach (string menuItem in menuItems)
            {
                Console.WriteLine(menuItem);
            }
            
            

        }

        static void Banner()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
 __   __           ___       _ _        ___             
 \ \ / __ _ _ __  |   \ __ _(_| |_  _  |   \ ___ ______ 
  \ V / _` | '_ \ | |) / _` | | | || | | |) / _ (_-/ -_)
   |_|\__,_| .__/ |___/\__,_|_|_|\_, | |___/\___/__\___|
           |_|                   |__/                   

                                    made by: @frankieed_
_______________________________________________________________
");
        }

        
    }
}