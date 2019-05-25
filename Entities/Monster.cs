﻿using System;
using Microsoft.Xna.Framework;

namespace Trul.Entities
{
    //A generic monster capable of
    //combat and interaction
    //yields treasure upon death
    public class Monster : Actor
    {
        public Monster(Color foreground, Color background) : base(foreground, background, 'M')
        {
            Random rndNum = new Random();

            //number of loot to spawn for monster
            int lootNum = rndNum.Next(1, 4);

            for (int i = 0; i < lootNum; i++)
            {
                // monsters are made out of spork, obvs.
                Item newLoot = new Item(Color.HotPink, Color.Transparent, "spork", 'L', 2);
                newLoot.Components.Add(new SadConsole.Components.EntityViewSyncComponent());
                Inventory.Add(newLoot);
            }
        }
    }
}
