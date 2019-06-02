﻿using ChaosDivinity.Char;
using ChaosDivinity.Inventory;
using ChaosDivinity.Physics;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace ChaosDivinity.MapObjects
{
    public class Chest : PhysicObject
    {
        public Flyout Fl { get; set; }
        public InventorySlot Item;

        public Chest()
        {

        }
        public InventorySlot RandomPremium(Dictionary<int, InventorySlot> p)
        { 
            int max = 10, mim = 1;
            Random rnd = new Random();
            int id_random = rnd.Next(mim, max);  
            if ( p[id_random] == null) return p[1];
            else return p[id_random];
        }

        public void ShowFlyout()
        {
            

        }

        public void HideFlyout()
        {

        }
        public override void CollisionEvent(PhysicObject sender, EventArgs p)
        {
            if(sender is Hero)
            {

                ShowFlyout();
            }
            if (sender == null)
            {

            }
        }
    }
 }
