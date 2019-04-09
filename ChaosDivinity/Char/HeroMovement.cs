using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ChaosDivinity.Char
{
    class HeroMovement
    {
        protected Canvas Perso;
        protected Canvas Tela;
        public double TelaY = 0;
        public double TelaX = 0;
        public bool up, down, right, left;
        Thread UpdateMovement;

        public HeroMovement(Canvas Perso, Canvas Tela)
        {
            this.Perso = Perso;
            this.Tela = Tela;
            Window.Current.CoreWindow.KeyDown += EventFunc;
            Window.Current.CoreWindow.KeyUp += EventFuncOff;
            UpdateMovement = new Thread(UpdateMovementeFunc);
            UpdateMovement.Start();
        }

        public void EventFunc(CoreWindow sender, KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.A)
            {
                left = true;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D)
            {
                right = true;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.W)
            {
                up = true;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S)
            {
                down = true;
            }

        }

        public void EventFuncOff(CoreWindow sender, KeyEventArgs e)
        {

            if (e.VirtualKey == Windows.System.VirtualKey.A)
            {
                left = false;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D)
            {
                right = false;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.W)
            {
                up = false;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S)
            {
                down = false;
            }
        }

        public async void UpdateMovementeFunc()
        {
            while (true)
            {
                await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (left)
                    {
                        TelaX += 0.035;
                        Tela.SetValue(Canvas.LeftProperty, TelaX);
                    }
                    if (right)
                    {
                        TelaX -= 0.035;
                        Tela.SetValue(Canvas.LeftProperty, TelaX);
                    }
                    if (up)
                    {
                        TelaY += 0.035;
                        Tela.SetValue(Canvas.TopProperty, TelaY);
                    }
                    if (down)
                    {
                        TelaY -= 0.035;
                        Tela.SetValue(Canvas.TopProperty, TelaY);
                    }
                });

            }

        }

    }
}
