﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class PrimaryAttribute
    {
        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public PrimaryAttribute(int vitality, int strength, int dexterity, int intelligence)
        {
            Vitality = vitality;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;

        }
    }
}