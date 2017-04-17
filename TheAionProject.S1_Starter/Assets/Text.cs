using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestWar
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "Quest War" };
        public static List<string> FooterText = new List<string>() { "UltraPip Studios, 2017" };

        #region INTITIAL GAME SETUP

        public static string AdventureIntro()
        {
            string messageBoxText =
            "You are an adventurer that just woke up an the dark damp ground, " +
            "you look around to see if you can find anything and the only " +
            "thing you can see is a small table with a candle and a mirror " +
            "you get up and walk over to the mirror. What do you see?\n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your adventure begins now.\n" +
            " \n" +
            "\tYour first task will be to descrive what you see in the mirror.\n" +
            " \n" +
            "\tPress any key to start your character creation.\n";

            return messageBoxText;
        }

        public static string CurrrentLocationInfo()
        {
            string messageBoxText =
            "As you look at yourself in the mirror memories of who you were start rushing " +
            "back. As you start to come back to your senses you relized that things are not " +
            "right. You relize that you are in a jail cell as the shadows of the candle light " +
            "flicker across the room.\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Adventure Text

        public static string InitializeAdventureIntro()
        {
            string messageBoxText =
                "Before you begin your adventure we must gather your base data.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeAdventureGetAdventurerName()
        {
            string messageBoxText =
                "Enter your name Adventurer.\n" +
                " \n" +
                "Please use the name you wish to be referred during your adventure.";

            return messageBoxText;
        }

        public static string InitializeAdventureGetAdventurerHairColor()
        {
            string messageBoxText =
                "Enter your hair color Adventurer.\n" +
                " \n" +
                "Please use your natural hair color.";

            return messageBoxText;
        }

        public static string InitializeAdventureGetAdventurerAge(string name)
        {
            string messageBoxText =
                $"Very good then, we will call you {name}.\n" +
                " \n" +
                "Enter your age below.";

            return messageBoxText;
        }

        public static string InitializeAdventureGetAdventurerRace(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"{gameAdventurer.Name}, it will be important for us to know your race on your adventure.\n" +
                " \n" +
                "Enter your race below.\n" +
                " \n" +
                "Please use the universal race classifications below." +
                " \n";

            string raceList = null;

            foreach (Character.RaceType race in Enum.GetValues(typeof(Character.RaceType)))
            {
                if (race != Character.RaceType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }
        public static string InitializeAdventureGetAdventurerClass(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"{gameAdventurer.Name}, it will be important for us to know your characters class.\n" +
                " \n" +
                "Enter your class below.\n" +
                " \n" +
                "Please use the universal class classifications below." +
                " \n";

            string classList = null;

            foreach (Character.ClassType race in Enum.GetValues(typeof(Character.ClassType)))
            {
                if (race != Character.ClassType.None)
                {
                    classList += $"\t{classList}\n";
                }
            }

            messageBoxText += classList;

            return messageBoxText;
        }

        public static string InitializeAdventureGetAdventurerGold()
        {
            string messageBoxText =
                "Enter your gold.\n" +
                " \n";

            return messageBoxText;
        }

        public static string InitializeAdventureEchoAdventurerInfo(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"Very good then {gameAdventurer.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your adventure. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tAdventurer Name: {gameAdventurer.Name}\n" +
                $"\tAdventurer Age: {gameAdventurer.Age}\n" +
                $"\tAdventurer Race: {gameAdventurer.Race}\n" +
                $"\tAdventurer Class: {gameAdventurer.Class}\n" +
                $"\tAdventurer Hair Color: {gameAdventurer.HairColor}\n" +
                $"\tAdventurer Gold: {gameAdventurer.Gold}\n" +
                " \n" +
                "Press any key to begin your Adventure.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string AdventurerInfo(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"\tAdventurer Name: {gameAdventurer.Name}\n" +
                $"\tAdventurer Age: {gameAdventurer.Age}\n" +
                $"\tAdventurer Race: {gameAdventurer.Race}\n" +
                $"\tAdventurer Class: {gameAdventurer.Class}\n" +
                $"\tAdventurer Hair Color: {gameAdventurer.HairColor}\n" +
                $"\tAdventurer Gold: {gameAdventurer.Gold}\n" +
                " \n";

            return messageBoxText;
        }

        //public static string Travel(int currentSpaceTimeLocationId, List<SpaceTimeLocation> spaceTimeLocations)
        //{
        //    string messageBoxText =
        //        $"{gameAdventurer.Name}, Aion Base will need to know the name of the new location.\n" +
        //        " \n" +
        //        "Enter the ID number of your desired location from the table below.\n" +
        //        " \n";


        //    string spaceTimeLocationList = null;

        //    foreach (SpaceTimeLocation spaceTimeLocation in spaceTimeLocations)
        //    {
        //        if (race != Character.RaceType.None)
        //        {
        //            raceList += $"\t{race}\n";
        //        }
        //    }

        //    messageBoxText += raceList;

        //    return messageBoxText;
        //}

        #endregion
    }
}
