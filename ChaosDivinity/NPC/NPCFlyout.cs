﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.NPC
{
    class NPCFlyout
    {
        public DependencyObject FavoritesBar { get; private set; }

        private void Folder2_Click(object sender, RoutedEventArgs e)
        {
            Flyout flyout = new Flyout();
            flyout.OverlayInputPassThroughElement = FavoritesBar;
            //
            flyout.ShowAt(sender as FrameworkElement);
            {

            }
        }
    }
}
