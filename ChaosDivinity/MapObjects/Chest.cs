using ChaosDivinity.Inventory;
using ChaosDivinity.Item;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;

namespace ChaosDivinity.MapObjects
{
    public class Chest : PhysicObject
    {
        public InventorySlot RandomPremium(Dictionary<string, InventorySlot> p)
        { 
            int max = 10, mim = 1;
            string key;            
            Random rnd = new Random();
            int id_random = rnd.Next(mim, max);
            if (id_random < 10)
            {
                key = "000" + id_random;
            }
            if(id_random >=10 && id_random <= 99)
            {
                key = "00" + id_random;
            }
            else
            {
                key = "0" + id_random;
            }

            if ( p[key] == null) return p["0001"];
            else return p[key];
        }
    }
 }
