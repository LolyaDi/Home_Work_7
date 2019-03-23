using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyClassLibrary.WorldOfTanks;

namespace Home_Work_7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT_TANK = 5;
            const int MAXIMUM_LEVEL = 101;
            const int MINIMUM_LEVEL = 0;

            int levelAmmunitionLoadTank;
            int levelArmorTank;
            int levelManeuverabilityTank;

            Random random = new Random();
            Tank[] firstTank = new Tank[COUNT_TANK];
            Tank[] secondTank = new Tank[COUNT_TANK];
            Tank[] checkTank = new Tank[COUNT_TANK];

            for (int i = 0; i < firstTank.Length; i++)
            {
                levelAmmunitionLoadTank = random.Next(MINIMUM_LEVEL, MAXIMUM_LEVEL);

                levelArmorTank = random.Next(MINIMUM_LEVEL, MAXIMUM_LEVEL);

                levelManeuverabilityTank = random.Next(MINIMUM_LEVEL, MAXIMUM_LEVEL);

                firstTank[i] = new Tank("T-34", levelAmmunitionLoadTank, levelArmorTank, levelManeuverabilityTank);
            }


            for (int i = 0; i < secondTank.Length; i++)
            {
                levelAmmunitionLoadTank = random.Next(MINIMUM_LEVEL, MAXIMUM_LEVEL);

                levelArmorTank = random.Next(MINIMUM_LEVEL, MAXIMUM_LEVEL);

                levelManeuverabilityTank = random.Next(MINIMUM_LEVEL, MAXIMUM_LEVEL);

                secondTank[i] = new Tank("Pantera", levelAmmunitionLoadTank, levelArmorTank, levelManeuverabilityTank);
            }


            for (int i = 0; i < checkTank.Length; i++)
            {
                checkTank[i] = new Tank();

                secondTank[i].СharacteristicsTank();
                Console.WriteLine("--------------------------------------");

                firstTank[i].СharacteristicsTank();
                checkTank[i] = firstTank[i] ^ secondTank[i];

                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                checkTank[i].WinnerTank();
                Console.WriteLine("--------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
