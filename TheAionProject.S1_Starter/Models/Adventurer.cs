using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestWar
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Adventurer : Character
    {
        #region ENUMERABLES


        #endregion
            
        #region FIELDS

        private string _hairColor;
        private double _gold;
        private bool _gender;
        private static ClassType charClass;






        #endregion


        #region PROPERTIES

        public string HairColor
        {
            get { return _hairColor; }
            set { _hairColor = value; }
        }
        public double Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
        public bool Injured
        {
            get { return _gender; }
            set { _gender = value; }
        }
        #endregion


        #region CONSTRUCTORS

        public Adventurer()
        {

        }

        public Adventurer(string name, RaceType race, int spaceTimeLocationID) : base(name, race, charClass, spaceTimeLocationID)
        {

        }

        #endregion


        #region METHODS
        

        #endregion
    }
}
