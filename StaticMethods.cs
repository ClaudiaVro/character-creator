using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class StaticMethods
    {
        static int disp = 5; // disposable points used to set 7 main stats
        //str, per, end, ch, _int, ag, lk  - order in statsArray
        public static int[] statsArray = { 5, 5, 5, 5, 5, 5, 5 };
        public static int meleeWeapons = 25 + (statsArray[0] + statsArray[5]) * 2;
        public static int unarmed = 30 + (statsArray[0] + statsArray[5]) * 2;
        public static int doctor = 5 + (statsArray[1] + statsArray[4]) / 2;
        public static int firstAid = (statsArray[1] + statsArray[4]) * 2;
        public static int lockpick = 10 + (statsArray[1] + statsArray[5]);
        public static int traps = 20 + (statsArray[1] / 2 + statsArray[5] / 2);
        public static int outdoorsman = 2 * statsArray[2] + 2 * statsArray[4];
        public static int barter = 4 * statsArray[3];
        public static int speech = 5 * statsArray[3];
        public static int repair = 20 + statsArray[4];
        public static int science = (25 + 2 * statsArray[4]);
        public static int bigGuns = 2 * statsArray[5];
        public static int smallGuns = 5 + (4 * statsArray[5]);
        public static int energyWeapons = 2 * statsArray[5];
        public static int sneak = 5 + (3 * statsArray[5]);
        public static int steal = 20 + statsArray[5];
        public static int throwing = 4 * statsArray[5];
        public static int gambling = 20 + (3 * statsArray[6]);

        public static int hitpoints = 15 + statsArray[0] + statsArray[2]*2;
        public static int armorClass = statsArray[5];
        public static int actionPoints = 5 + statsArray[5] / 2;
        public static int criticalChance = statsArray[6];
        public static int carryWeight = 25 + (statsArray[0]*25);
        public static int meleeDamage = statsArray[0];
        public static int damageResist = 0;
        public static int radiationResist = statsArray[2] * 2;
        public static int poisonResist = statsArray[2] * 5;
        public static int healingRate = statsArray[2];

        public static bool[] checkBoxes = new bool[5];

        public static int increment = 1;

            public static int DispProp
        {
            get { return disp; }
            set { if (value > 0) disp = value;
                else disp = 0;
            } 
        }

        public static int ModifyDisp(int currentStat, int savedStat, out int setStat)
        {
            setStat = 0;
            if (currentStat > savedStat) { 
                if (DispProp == 0)  setStat = savedStat;
                DispProp--;
            }
            else if (currentStat < savedStat) DispProp++;
            return DispProp;
        }

    }
}

