﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //AN ABSTRACT CLASS CAN NEVER BE TURNED INTO AN OBJECT; IT IS ONLY MEANT TO BE INHERITED BY OTHER CLASSES
    public abstract class Game //*NOTE: MAKE INHERITED CLASSES AS GENERIC AS POSSIBLE FUTURE INHERITING CLASSES
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } } //THIS IS THE OLD WAY TO DO '{ get; set; }'.... '{ get { return _players; } set { _players = value; } }'
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play(); //ABSTRACT METHODS CAN ONLY EXIST IN AN ABSTRACT CLASS; AN ABSTRACT METHOD ALSO CONTAINS NO IMPLEMENTATION. (I.E. ANY CLASS INHERITING THIS 'Game' CLASS MUST IMPLEMENT THIS METHOD.
        
        public virtual void ListPlayers() //A VIRTUAL METHOD ONLY EXISTS INSIDE AN ABSTRACT CLASS; IT MEANS THAT THIS METHOD GETS INHERITED BY AN INHERITING CLASS BUT IT HAS THE ABILITY TO OVERRIDE IT (I.E.VIRTUAL METHODS HAVE IMPLEMENTATION BUT THEY CAN BE OVERWRITTEN).
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }   
        }
    }
}

//***RULES ON ABSTRACT CLASSES:
//      1) ABSTRACT CLASSES: NEVER CREATE AN OBJECT FROM THE CLASS ITSELF; THE CLASS IS ONLY MEANT TO BE INHERITED
//      2) ABSTRACT METHODS: IN AN ABSTRACT CLASS YOU CAN HAVE ABSTRACT METHODS WHICH DON'T HAVE IMPLEMENTATION; THEY JUST STATE THAT ANY CLASS INHERITING IT MUST IMPLEMENT THAT METHOD
//      3) VIRTUAL METHODS: IN A VIRTUAL METHOD (INSIDE AN ABSTRACT CLASS) THERE IS IMPLEMENTATION; YOU CAN PUT IN DEFAULT IMPLEMENTATION BUT IT CAN BE PARTIALLY OR COMPLETELY OVERRIDDEN IN THE INHERITING CLASS
