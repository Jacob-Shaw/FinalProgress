using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class SpecialEffects
    {
        public bool BlinkOn = true;

        public SpecialEffects()
        {
           
        }

        public async void Blink(string message)
        {
            // public bool BlinkOn = true;

            while (BlinkOn == true)
            {
                Console.WriteLine(message);
                Console.BackgroundColor = Console.BackgroundColor == ConsoleColor.Red ? ConsoleColor.Black : ConsoleColor.Red;
                await Task.Delay(1000);
                
            }
        }
    }
}
