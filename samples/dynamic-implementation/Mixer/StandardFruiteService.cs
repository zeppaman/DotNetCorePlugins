﻿using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mixer
{
    public class StandardFruiteService : IFruitService
    {
        public List<Fruit> GetFruits()
        {
            return new List<Fruit>()
            {
                new Fruit(){ Name="Banana"},
                new Fruit(){ Name="Apple"},
                new Fruit(){ Name="Carrot"},
            };
        }
    }
}
