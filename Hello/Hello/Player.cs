﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {
        public string name = "rakin";
        private int health = 49;

        public int getHealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            this.health = h;
        }

    }
}
