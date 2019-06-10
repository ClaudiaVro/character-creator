using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BuildCharacter
    {
        public int age;
        public string name;
        public char gender;
        string[] lines;
        public int[] checkArray;
        

        public void ConstructCharacter()
        {
            string str1 = "Name: " + name.ToUpper() + ", Age: " + age + ", Gender: " + gender + "";
            string str2 = "Strength: " + StaticMethods.statsArray[0] + " Perception: " + StaticMethods.statsArray[1] +
                " Endurance: " + StaticMethods.statsArray[2] + " Charisma: " + StaticMethods.statsArray[3] + " Intelligence: " + StaticMethods.statsArray[4]
                + " Agility: " + StaticMethods.statsArray[5] + " Luck: " + StaticMethods.statsArray[6];
            string space = "";
            string str3 = "Skills:";
            string str4 = "Big Guns: " + StaticMethods.bigGuns + "               Lockpick:" + StaticMethods.lockpick;
            string str5 = "Small Guns: " + StaticMethods.smallGuns + "           Repair:" + StaticMethods.repair;
            string str6 = "Energy Weapons " + StaticMethods.energyWeapons + "    Outdoorsman:" + StaticMethods.outdoorsman;
            string str7 = "Throwing: " + StaticMethods.throwing + "              Speech:" + StaticMethods.speech;
            string str8 = "Traps: " + StaticMethods.traps + "                    Gambling:" + StaticMethods.gambling;
            string str9 = "Melee Weapons: " + StaticMethods.meleeWeapons + "     Barter:" + StaticMethods.barter;
            string str10 = "Unarmed: " + StaticMethods.unarmed + "               Steal:" + StaticMethods.steal;
            string str11 = "Doctor: " + StaticMethods.doctor + "                 Sneak:" + StaticMethods.sneak;
            string str12 = "First Aid: " + StaticMethods.firstAid + "            Science:" + StaticMethods.science;
            string str14 = "Derived Stats";
            string str15 = "Hitpoints: " + StaticMethods.hitpoints;
            string str16 = "Critical Chance: " + StaticMethods.criticalChance + "             Carry Weight: " + StaticMethods.carryWeight + "             Poison Resist: " + StaticMethods.poisonResist;
            string str17 = "Armor Class: " + StaticMethods.armorClass + "             Melee Damage: " + StaticMethods.meleeDamage + "             Radiation Resist: " + StaticMethods.radiationResist;
            string str18 = "Action Points: " + StaticMethods.actionPoints + "             Damage Resistance: " + StaticMethods.damageResist + "             Healing Rate " + StaticMethods.healingRate;
            string str19 = "Optional Traits";
            string str20 = "";
            if (StaticMethods.checkBoxes[0] == true) str20 = str20 + "Fast Metabolism             ";
            if (StaticMethods.checkBoxes[1] == true) str20 = str20 + " Bruiser                ";
            if (StaticMethods.checkBoxes[2] == true) str20 = str20 + "Small Frame             ";
            if (StaticMethods.checkBoxes[3] == true) str20 = str20 + "Good Natured            ";
            if (StaticMethods.checkBoxes[4] == true) str20 = str20 + "Kamikaze           ";

            lines = new string[] { str1, str2, space, str3, space, str4, str5, str6, str7, str8,
                str9, str10, str11, str12, space, str14, space, str15, str16,
                str17, str18, space , str19, space, str20 };

            System.IO.File.WriteAllLines(@"C:\Users\Public\Test Folder\WriteText.txt", lines);
        }
    }
}
