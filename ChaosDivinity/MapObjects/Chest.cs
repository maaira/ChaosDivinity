using ChaosDivinity.Inventory;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;

namespace ChaosDivinity.MapObjects
{
    public class Chest : PhysicObject
    {
        
        public static InventorySlot RandomPremium(Dictionary<int, InventorySlot> p)
        { 
            int max = 10, mim = 1;
            Random rnd = new Random();
            int id_random = rnd.Next(mim, max);  
            if ( p[id_random] == null) return p[1];
            else return p[id_random];
        }
    }
 }
