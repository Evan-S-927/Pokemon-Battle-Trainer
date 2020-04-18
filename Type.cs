using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleApp
{
    class Type
    {
        private string Name;
        private string[] AtkGood;
        private string[] AtkBad;
        private string[] DefGood;
        private string[] DefBad;
        private string[] DefImmune;

        public Type()
        {
            Name = "No Type Specified.";
            AtkGood[0] = "No Super Effective Matchups Specified";
            AtkBad[0] = "No Not Very Effective Matchups Specified";
            DefGood[0] = "No Resistances Specified";
            DefBad[0] = "No Weaknesses Specified";
            DefImmune[0] = "No Immunities Specified";
        }

        public Type(string name, 
            string[] atkGood, 
            string[] atkBad, 
            string[] defGood, 
            string[] defBad, 
            string[] defImmune)
        {
            Name = name;
            AtkGood = atkGood;
            AtkBad = atkBad;
            DefGood = defGood;
            DefBad = defBad;
            DefImmune = defImmune;
        }

        //This will return a different integer based on how this type defends against a type.
        // -1 is Neutral, 0 is Immune, 1 is Resisted, 2 is a Weakness.
        public int MatchupCheck(string atkType)
        {
            int result = -1;

            foreach(string type in DefImmune)
            {
                if(type == atkType) result = 0;
            }

            foreach(string type in DefGood)
            {
                if(type == atkType) result = 1;
            }

            foreach(string type in DefBad)
            {
                if (type == atkType) result = 2;
            }

            return result;
        }
    }
}
