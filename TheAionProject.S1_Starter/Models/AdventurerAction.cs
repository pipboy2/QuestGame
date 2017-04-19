using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestWar
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum TravelerAction
    {
        None,
        MissionSetup,
        LookAround,
        LookAt,
        PickUpItem,
        PickUpTreasure,
        PutDownItem,
        PutDownTreasure,
        Adventurer,
        AdventurerInfo,
        AdventurerInventory,
        AdventurerTreasure,
        ListTARDISDestinations,
        ListItems,
        ListTreasures,
        Exit
    }
}
