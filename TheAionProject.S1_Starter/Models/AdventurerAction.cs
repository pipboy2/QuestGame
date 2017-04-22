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
    public enum AdventurerAction
    {
        None,
        MissionSetup,
        LookAround,
        LookAt,
        PickUpItem,
        PickUpTreasure,
        PutDownItem,
        PutDownTreasure,
        Travel,
        AdventurerInfo,
        AdventurerInventory,
        AdventurerTreasure,
        AdventurerLocationsVisited,
        ListWorldLocationDestinations,
        ListItems,
        ListTreasures,
        Exit
    }
}
