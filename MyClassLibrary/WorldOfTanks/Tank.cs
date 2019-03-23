using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyClassLibrary.WorldOfTanks
{
    public class Tank
    {
        private string TankName { get; set; }

        private int LevelAmmunitionLoadTank { get; set; }

        private int LevelArmorTank { get; set; }

        private int LevelManeuverabilityTank { get; set; }

        public Tank()
        {

        }

        public Tank(string nameTank, int levelAmmunitionLoadTank, int levelArmorTank, int levelManeuverabilityTank)
        {
            TankName = nameTank;
            LevelAmmunitionLoadTank = levelAmmunitionLoadTank;
            LevelArmorTank = levelArmorTank;
            LevelManeuverabilityTank = levelManeuverabilityTank;
        }

        public void СharacteristicsTank()
        {
            Console.WriteLine($"Название танка: \"{TankName}\"");
            Console.WriteLine($"Уровень боекомлекта -  {LevelAmmunitionLoadTank} %");
            Console.WriteLine($"Уровень брони - {LevelArmorTank} %");
            Console.WriteLine($"Уровень маневрености - {LevelManeuverabilityTank} %");
        }

        public static Tank operator ^(Tank firstTank, Tank secondTank)
        {
            if (firstTank.LevelAmmunitionLoadTank > secondTank.LevelAmmunitionLoadTank && firstTank.LevelArmorTank > secondTank.LevelArmorTank)
            {
                return firstTank;
            }

            if (firstTank.LevelAmmunitionLoadTank > secondTank.LevelAmmunitionLoadTank && firstTank.LevelManeuverabilityTank > secondTank.LevelManeuverabilityTank)
            {
                return firstTank;
            }

            if (firstTank.LevelArmorTank > secondTank.LevelArmorTank && firstTank.LevelManeuverabilityTank > secondTank.LevelManeuverabilityTank)
            {
                return firstTank;
            }

            else
            {
                return secondTank;
            }
        }

        public void WinnerTank()
        {
            Console.WriteLine($"Победил в сражении танк: {TankName}");
        }
    }
}
