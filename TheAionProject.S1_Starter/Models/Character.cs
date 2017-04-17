using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestWar
{
    /// <summary>
    /// base class for the player and all game characters
    /// </summary>
    public class Character
    {
        #region ENUMERABLES

        public enum RaceType
        {
            None,
            Human,
            Elf,
            Dwarf,
            Orc
        }
        public enum ClassType
        {
            Warrior,
            Mage,
            Thief,
            None
        }

        #endregion

        #region FIELDS

        private string _name;
        private int _worldLocationID;
        private int _age;
        private RaceType _race;
        private ClassType _charClass;

        #endregion

        #region PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int WorldLocationID
        {
            get { return _worldLocationID; }
            set { _worldLocationID = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public RaceType Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public ClassType Class
        {
            get { return _charClass; }
            set { _charClass = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Character()
        {

        }

        public Character(string name, RaceType race, ClassType charClass, int worldLocationID)
        {
            _name = name;
            _race = race;
            _charClass = charClass;
            _worldLocationID = worldLocationID;
        }

        #endregion

        #region METHODS



        #endregion
    }
}
