using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestWar
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {
        public static Menu MissionIntro = new Menu()
        {
            MenuName = "MissionIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, AdventurerAction>()
                    {
                        { ' ', AdventurerAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, AdventurerAction>()
                {
                    { '1', AdventurerAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, AdventurerAction>()
                {
                    { '1', AdventurerAction.AdventurerInfo },
                    { '2', AdventurerAction.LookAround },
                    { '3', AdventurerAction.Travel },
                    { '4', AdventurerAction.AdventurerLocationsVisited },
                    { '5', AdventurerAction.ListWorldLocationDestinations },
                    {'6', AdventurerAction.Exit }
                    
                }
        };

        //public static Menu ManageAdventurer = new Menu()
        //{
        //    MenuName = "ManageAdventurer",
        //    MenuTitle = "Manage Adventurer",
        //    MenuChoices = new Dictionary<char, AdventurerAction>()
        //            {
        //                AdventurerAction.MissionSetup,
        //                AdventurerAction.AdventurerInfo,
        //                AdventurerAction.Exit
        //            }
        //};
    }
}
