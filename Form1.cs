using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeValues();
           

        }

        private void InputName_Click(object sender, EventArgs e)
        {

            if (StaticMethods.DispProp != 0) {
                MessageBox.Show("Stat assigning not finished yet.");
                return;
            }
            BuildCharacter newchar = new BuildCharacter();
            newchar.name = NameInput.Text;
            newchar.age = (int) numericUpDown1.Value;
            newchar.gender = radioButton1.Checked ? 'F' : 'M';
            newchar.ConstructCharacter();
        }

        public void InitializeValues()
        {
            MeleeWeapons.Text = StaticMethods.meleeWeapons.ToString();
            BigGuns.Text = StaticMethods.bigGuns.ToString();
            SmallGuns.Text = StaticMethods.smallGuns.ToString();
            Unarmed.Text = StaticMethods.unarmed.ToString();
            Doctor.Text = StaticMethods.doctor.ToString();
            FirstAid.Text = StaticMethods.firstAid.ToString();
            Lockpick.Text = StaticMethods.lockpick.ToString();
            Traps.Text = StaticMethods.traps.ToString();
            Outdoorsman.Text = StaticMethods.outdoorsman.ToString();
            Barter.Text = StaticMethods.barter.ToString();
            Speech.Text = StaticMethods.speech.ToString();
            Repair.Text = StaticMethods.repair.ToString();
            Science.Text = StaticMethods.science.ToString();
            EnergyWeapons.Text = StaticMethods.energyWeapons.ToString();
            Sneak.Text = StaticMethods.sneak.ToString();
            Steal.Text = StaticMethods.steal.ToString();
            Throwing.Text = StaticMethods.throwing.ToString();
            Gambling.Text = StaticMethods.gambling.ToString();

            Hitpoints.Text = StaticMethods.hitpoints.ToString();
            ArmorClass.Text = StaticMethods.armorClass.ToString();
            ActionPoints.Text = StaticMethods.actionPoints.ToString();
            CriticalChance.Text = StaticMethods.criticalChance.ToString();
            CarryWeight.Text = StaticMethods.carryWeight.ToString();
            MeleeDamage.Text = StaticMethods.meleeDamage.ToString();
            DamageResist.Text = StaticMethods.damageResist.ToString();
            RadiationResist.Text = StaticMethods.radiationResist.ToString();
            PoisonResist.Text = StaticMethods.poisonResist.ToString();
            HealingRate.Text = StaticMethods.healingRate.ToString();
        }

        public void ModifyStats()
        {
            int[] numericUpDownArray = { (int)numericUpDown2.Value, (int)numericUpDown3.Value,
                    (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown6.Value,
                (int)numericUpDown7.Value, (int)numericUpDown8.Value};
            int i = 0;
            foreach(int var in numericUpDownArray)
            {
                StaticMethods.statsArray[i] = var;           
                i++;
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int j = Int32.Parse(numericUpDown2.Text);
            //MessageBox.Show(j.ToString());
            int i = (int)numericUpDown2.Value;
            // MessageBox.Show(i.ToString());
            textBox1.Text = StaticMethods.ModifyDisp(i, j, out int f).ToString();
            // if disp is 0 then set stat to its previous value
            if (f > 0) numericUpDown2.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsStr();
                ModifyDerivedSkills();
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int f;
            int j = Int32.Parse(numericUpDown3.Text);
            int i = (int)numericUpDown3.Value;
            textBox1.Text = StaticMethods.ModifyDisp(i, j, out f).ToString();
            if (f > 0) numericUpDown3.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsPer();
                ModifyDerivedSkills();
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            int f;
            int j = Int32.Parse(numericUpDown4.Text);
            int i = (int)numericUpDown4.Value;
            textBox1.Text = StaticMethods.ModifyDisp(i, j, out f).ToString();
            if (f > 0) numericUpDown4.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsEnd();
                ModifyDerivedSkills();
            }
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            int f;
            int j = Int32.Parse(numericUpDown5.Text);
            int i = (int)numericUpDown5.Value;
            textBox1.Text = StaticMethods.ModifyDisp(i, j, out f).ToString();
            if (f > 0) numericUpDown5.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsCh();
                ModifyDerivedSkills();
            }
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            int f;
            int j = Int32.Parse(numericUpDown6.Text);
            int i = (int)numericUpDown6.Value;
            textBox1.Text = StaticMethods.ModifyDisp(i, j,out f).ToString();
            if (f > 0) numericUpDown6.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsInt();
                ModifyDerivedSkills();
            }
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            int f;
            int j = Int32.Parse(numericUpDown7.Text);
            int i = (int)numericUpDown7.Value;
            textBox1.Text = StaticMethods.ModifyDisp(i, j, out f).ToString();
            if (f > 0) numericUpDown7.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsAgi();
                ModifyDerivedSkills();
            }
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            int f;
            int j = Int32.Parse(numericUpDown8.Text);
            int i = (int)numericUpDown8.Value;
            textBox1.Text = StaticMethods.ModifyDisp(i, j, out f).ToString();
            if (f > 0) numericUpDown8.Value = f;
            else
            {
                ModifyStats();
                ModifySkillsLk();
                ModifyDerivedSkills();
            }
        }

        public void ModifySkillsStr()
        {
            StaticMethods.meleeWeapons = 25 + (StaticMethods.statsArray[0] +
                StaticMethods.statsArray[5]) * 2;
            MeleeWeapons.Text = StaticMethods.meleeWeapons.ToString();
            StaticMethods.unarmed = 30 + (StaticMethods.statsArray[0]
                + StaticMethods.statsArray[5]) * 2;
            Unarmed.Text = StaticMethods.unarmed.ToString();
        }

        public void ModifySkillsPer()
        {
            if (GoodNatured.CheckState != CheckState.Checked)
            {
                StaticMethods.doctor = 5 + (StaticMethods.statsArray[1]
                + StaticMethods.statsArray[4]) / 2;
                StaticMethods.firstAid = (StaticMethods.statsArray[1]
                   + StaticMethods.statsArray[4]) * 2;
            } else
            {
                StaticMethods.doctor = 15 + (StaticMethods.statsArray[1]
               + StaticMethods.statsArray[4]) / 2;
                StaticMethods.firstAid = 10 +((StaticMethods.statsArray[1]
                   + StaticMethods.statsArray[4]) * 2);
            }
            StaticMethods.lockpick = 10 + (StaticMethods.statsArray[1] +
                StaticMethods.statsArray[5]);
             StaticMethods.traps = 20 + (StaticMethods.statsArray[1] / 2
                + StaticMethods.statsArray[5] / 2);
            Doctor.Text = StaticMethods.doctor.ToString();
            FirstAid.Text = StaticMethods.firstAid.ToString();
            Lockpick.Text = StaticMethods.lockpick.ToString();
            Traps.Text = StaticMethods.traps.ToString();
        }

        public void ModifySkillsEnd()
        {
            StaticMethods.outdoorsman = 2 * StaticMethods.statsArray[2] 
                + 2 * StaticMethods.statsArray[4];
            Outdoorsman.Text = StaticMethods.outdoorsman.ToString();
        }

        public void ModifySkillsCh()
        {
            if (GoodNatured.CheckState != CheckState.Checked)
            {
                StaticMethods.barter = 4 * StaticMethods.statsArray[3];
                StaticMethods.speech = 5 * StaticMethods.statsArray[3];
            } else
            {
                StaticMethods.barter = 4 * StaticMethods.statsArray[3] +15;
                StaticMethods.speech = 5 * StaticMethods.statsArray[3] + 15;
            }
            Barter.Text = StaticMethods.barter.ToString();
            Speech.Text = StaticMethods.speech.ToString();
        }

        public void ModifySkillsInt()
        {
            StaticMethods.repair = 20 + StaticMethods.statsArray[4];
            StaticMethods.science = (25 + 2 * StaticMethods.statsArray[4]);
            Repair.Text = StaticMethods.repair.ToString();
            Science.Text = StaticMethods.science.ToString();
            StaticMethods.doctor = 5 + (StaticMethods.statsArray[1]
                + StaticMethods.statsArray[4]) / 2;
            StaticMethods.firstAid = (StaticMethods.statsArray[1]
               + StaticMethods.statsArray[4]) * 2;
            Doctor.Text = StaticMethods.doctor.ToString();
            FirstAid.Text = StaticMethods.firstAid.ToString();
            ModifySkillsEnd();
        }

        public void ModifySkillsAgi()
        {
            StaticMethods.bigGuns = 2 * StaticMethods.statsArray[5];
            StaticMethods.smallGuns = 5 + (4 * StaticMethods.statsArray[5]);
            StaticMethods.energyWeapons = 2 * StaticMethods.statsArray[5];
            StaticMethods.sneak = 5 + (3 * StaticMethods.statsArray[5]);
            StaticMethods.steal = 20 + StaticMethods.statsArray[5];
            StaticMethods.throwing = 4 * StaticMethods.statsArray[5];
            StaticMethods.lockpick = 10 + (StaticMethods.statsArray[1]
                + StaticMethods.statsArray[5]);
            StaticMethods.traps = 20 + (StaticMethods.statsArray[1] / 2
               + StaticMethods.statsArray[5] / 2);
            ModifySkillsStr();
            Lockpick.Text = StaticMethods.lockpick.ToString();
            Traps.Text = StaticMethods.traps.ToString();
            BigGuns.Text = StaticMethods.bigGuns.ToString();
            SmallGuns.Text = StaticMethods.smallGuns.ToString();
            EnergyWeapons.Text = StaticMethods.energyWeapons.ToString();
            Sneak.Text = StaticMethods.sneak.ToString();
            Steal.Text = StaticMethods.steal.ToString();
            Throwing.Text = StaticMethods.throwing.ToString();

        }
        public void ModifySkillsLk()
        {
            StaticMethods.gambling = 20 + (3 * StaticMethods.statsArray[5]);
            Gambling.Text = StaticMethods.gambling.ToString();
        }

        public void ModifyDerivedSkills()
        {
            StaticMethods.hitpoints = 15 + StaticMethods.statsArray[0] + StaticMethods.statsArray[2] * 2;
            

            if (Kamikaze.CheckState != CheckState.Checked)
            {
                StaticMethods.actionPoints = 5 + StaticMethods.statsArray[5] / 2;
                StaticMethods.armorClass = StaticMethods.statsArray[5];
            } else
            {
                StaticMethods.actionPoints = 10 + StaticMethods.statsArray[5] / 2;
                StaticMethods.armorClass = StaticMethods.statsArray[5] - 2;
            }

            StaticMethods.criticalChance = StaticMethods.statsArray[6];

            if (SmallFrame.CheckState != CheckState.Checked)
                StaticMethods.carryWeight = 25 + (StaticMethods.statsArray[0] * 25);
            else StaticMethods.carryWeight = 25 + (StaticMethods.statsArray[0] * 15);

            if (Bruiser.CheckState != CheckState.Checked)
                StaticMethods.meleeDamage = StaticMethods.statsArray[0] ;
            else StaticMethods.meleeDamage = StaticMethods.statsArray[0] + 2;
            StaticMethods.criticalChance = StaticMethods.statsArray[6];
            
            if (FastMetabolism.CheckState != CheckState.Checked)
            {
                StaticMethods.radiationResist = StaticMethods.statsArray[2] * 2;
                StaticMethods.poisonResist = StaticMethods.statsArray[2] * 5;
                StaticMethods.healingRate = StaticMethods.statsArray[2] +2;
            }
            else
            {
                StaticMethods.healingRate = StaticMethods.statsArray[2] + 4;
                StaticMethods.poisonResist = 0;
                StaticMethods.radiationResist = 0;
            } 

            StaticMethods.damageResist = 0;
            Hitpoints.Text = StaticMethods.hitpoints.ToString();
            ArmorClass.Text = StaticMethods.armorClass.ToString();
            ActionPoints.Text = StaticMethods.actionPoints.ToString();
            CriticalChance.Text = StaticMethods.criticalChance.ToString();
            CarryWeight.Text = StaticMethods.carryWeight.ToString();
            MeleeDamage.Text = StaticMethods.meleeDamage.ToString();
            DamageResist.Text = StaticMethods.damageResist.ToString();
            RadiationResist.Text = StaticMethods.radiationResist.ToString();
            PoisonResist.Text = StaticMethods.poisonResist.ToString();
            HealingRate.Text = StaticMethods.healingRate.ToString();
        }
        private void FastMetabolism_Click(object sender, EventArgs e)
        {
            ModifyDerivedSkills();
            if (FastMetabolism.CheckState == CheckState.Checked)
                StaticMethods.checkBoxes[0] = true;
            else StaticMethods.checkBoxes[0] = false;
        }

        private void Bruiser_Click(object sender, EventArgs e)
        {
            ModifyDerivedSkills();
            if (Bruiser.CheckState == CheckState.Checked)
                StaticMethods.checkBoxes[1] = true;
            else StaticMethods.checkBoxes[1] = false;
        }

        private void SmallFrame_Click(object sender, EventArgs e)
        {
            ModifyDerivedSkills();
            if (SmallFrame.CheckState == CheckState.Checked)
                StaticMethods.checkBoxes[2] = true;
            else StaticMethods.checkBoxes[2] = false;
        }

        private void Kamikaze_Click(object sender, EventArgs e)
        {
            ModifyDerivedSkills();
            if (Kamikaze.CheckState == CheckState.Checked)
                StaticMethods.checkBoxes[4] = true;
            else StaticMethods.checkBoxes[4] = false;
        }

        private void GoodNatured_Click(object sender, EventArgs e)
        {
            ModifySkillsCh();
            ModifySkillsPer();
            if (GoodNatured.CheckState == CheckState.Checked)
                StaticMethods.checkBoxes[3] = true;
            else StaticMethods.checkBoxes[3] = false;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {          
            Description.Text = "Raw physical strength. A high Strength is  good for physical characters.";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The ability to see, hear, taste and notice unusual things. A high Perception is important for a sharpshooter.";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Stamina and physical toughness.A character with a high Endurance will survive where others may not.";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "A combination of appearance and charm. A high Charisma is important for characters that want to influence people with words.";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Knowledge, wisdom and the ability to think quickly. A high Intelligence is important for any character.";
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Coordination and the ability to move well. A high Agility is important for any active character.";
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Fate. Karma. An extremely high or low Luck will affect the character - somehow. Events and situations will be changed by how lucky (or unlucky) your character is.";
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label32_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "How much damage your character can take before dying.If you reach 0 HP or less, you are dead.";
        }

        private void label32_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label41_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The chance to cause a critical hit in combat is increased by this amount";
        }

        private void label41_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label33_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Modifies the chance to hit this particular character.";
        }

        private void label33_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label34_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The number of actions that the character can take during one combat turn.";
        }

        private void label34_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label35_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The maximum amount of equipment your character can carry, in pounds.";
        }

        private void label35_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label36_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The amount of bonus damage your character does in hand-to-hand combat.";
        }

        private void label36_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label37_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Any damage taken is reduced by this amount. Damage Resistance can be increased by wearing armor.";
        }

        private void label37_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label38_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Reduces poison damage by this amount.";
        }

        private void label38_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label39_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The amount of radiation you are exposed to is reduced by this percentage. Radiation Resistance can be modified by the type of armor worn, and anti-radiation chems.";
        }

        private void label39_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label40_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "At the end of each day, your character will heal 1 HP for each point of Healing Rate. When you rest, you heal every six hours.";
        }

        private void label40_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The operation and maintenance of really big guns - miniguns, rocket launchers, flamethrowers and such.";
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The use, care and general knowledge of small firearms - pistols, SMGs and rifles.";
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The care and feeding of energy-based weapons. How to arm and operate weapons that use laser or plasma technology.";
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The skill of muscle-propelled ranged weapons, such as throwing knives, spears and grenades.";
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The finding and removal of traps. Also the setting of explosives for demolition purposes.";
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Using non-ranged weapons in hand-to-hand or melee combat - knives, sledgehammers, spears, clubs and so on.";
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "A combination of martial arts, boxing and other hand-to-hand martial arts. Combat with your hands and feet.";
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The healing of major wounds and crippled limbs. Without this skill, it will take a much longer period of time to restore crippled limbs to use.";
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "General healing skill. Used to heal small cuts, abrasions and other minor ills. In game terms, the use of first aid can heal more hit points over time than just rest.";
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The skill of opening locks without the proper key. The use of lockpicks or electronic lockpicks will greatly enhance this skill.";
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The practical application of the Science skill, for fixing of broken equipment, machinery and electronics.";
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label26_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Practical knowledge of the outdoors, and the ability to live off the land. The knowledge of plants and animals.";
        }

        private void label26_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The ability to communicate in a practical and efficient manner. The skill of convincing others that your position is correct. The ability to lie and not get caught.";
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label24_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The knowledge and practical skills related to wagering. The skill at cards, dice and other games.";
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label23_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Trading and trade-related tasks. The ability to get better prices for items you sell, and lower prices for items you buy.";
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label22_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "The ability to make things of others your own. Can be used to steal from people or places.";
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label21_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Quiet movement, and the ability to remain unnoticed. If successful, you will be much harder to locate. You cannot run and sneak at the same time.";
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Covers a variety of high-technology skills, such as computers, biology, physics, and geology.";
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void FastMetabolism_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "Your metabolic rate is twice normal. This means that you are much less resistant to radiation and poison, but your body heals faster.";
        }

        private void FastMetabolism_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void Bruiser_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "A little slower, but a little bigger. You may not hit as often, but they will feel it when you do! Your total action points are lowered, but your Strength is increased.";
        }

        private void Bruiser_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void SmallFrame_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "You are not quite as big as other people, but that never slowed you down. You can't carry as much, but you are more agile.";
        }

        private void SmallFrame_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void GoodNatured_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "You studied less-combative skills as you were growing up. Your combat skills start at a lower level, but other skills are substantially improved.";
        }

        private void GoodNatured_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void Kamikaze_MouseHover(object sender, EventArgs e)
        {
            Description.Text = "By not paying attention to any threats, you can act a lot faster in a turn. This lowers your Armor Class to just what you are wearing, but you sequence much faster in a combat turn.";
        }

        private void Kamikaze_MouseLeave(object sender, EventArgs e)
        {
            Description.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (StaticMethods.increment == 0) 
                pictureBox1.Load(@"C:\Users\Public\Pics for C#\1.jpg");

            if (StaticMethods.increment == 1)
                pictureBox1.Load(@"C:\Users\Public\Pics for C#\2.png");  
            
            if (StaticMethods.increment == 2)
                pictureBox1.Load(@"C:\Users\Public\Pics for C#\3.png");

            if (StaticMethods.increment == 3)
                pictureBox1.Load(@"C:\Users\Public\Pics for C#\4a.jpg");

            if (StaticMethods.increment == 4)
            {
                pictureBox1.Load(@"C:\Users\Public\Pics for C#\5a.jpg");
                StaticMethods.increment = -1;
            }
            StaticMethods.increment++;
        }
    }
}
