/*
* ******************************************
* EXAMPLE:                                 *
*          Simple app for calculation of   *
*          material spent for installing   *
*          apartment or house windows      *
*                                          *
* VERSION: 1_1                             *
*                                          *
********************************************
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myThirdProj
{
    class BOMForApartmentWindows_1_1
    {
        static void Main()
        {
            double height, width, glassArea, woodLength;
            string heightString, widthString;
            const double MIN_HEIGHT = 0.75;
            const double MAX_HEIGHT = 3.5;
            const double MIN_WIDTH = 0.25;
            const double MAX_WIDTH = 1.0;

            do
            {
                Console.WriteLine("Give the height of the window beetween " + MIN_HEIGHT + " and " + MAX_HEIGHT + ": ");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            do
            {
                Console.WriteLine("Give the width of the window beetween " + MIN_WIDTH + " and " + MAX_WIDTH + ": ");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);

            woodLength = 2 * (height + width) * 3.25;
            glassArea = 2 * (height * width);

            Console.WriteLine("The length od the wood is " + woodLength + " feet.");
            Console.WriteLine("The glass area of the window is " + glassArea + " meters.");
        }

    }
}
