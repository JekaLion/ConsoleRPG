﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern
{
    public class Helmet : Armor
    {
        public Helmet(int id, string name, Rarity rarity, int price, string desc, int protection) : base(id, name, rarity, price, desc, protection)
        {
        }
    }
}
