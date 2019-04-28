using ChaosDivinity.Char;
using ChaosDivinity.Physics;
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;

namespace ChaosDivinity.Physics
{
    class HeroMovement : Movement
    {
        protected Canvas Perso;
        protected Hero Hero;
        protected double delta_move = 0.0915;
        protected dynamic Move_Object;
        protected Thread UpdateMovement;
        BitmapImage bitmapImage = new BitmapImage();
        
        public HeroMovement(Canvas Tela,Hero hero)
        {

            this.Hero = hero;
            this.Perso = hero.Container;
            this.Move_Object = Tela;
            TelaX = (double)this.Move_Object.GetValue(Canvas.LeftProperty);
            TelaY = (double)this.Move_Object.GetValue(Canvas.TopProperty);
            Window.Current.CoreWindow.KeyDown += EventFunc;
            Window.Current.CoreWindow.KeyUp += EventFuncOff;
            UpdateMovement = new Thread(UpdateMovementeFunc);
            UpdateMovement.Start();

        }


        public void EventFunc(CoreWindow sender, KeyEventArgs e)
        {

            if (e.VirtualKey == Windows.System.VirtualKey.A && Hero.InMoment.Left == true)
            {
                Hero.IsMoving = true;
                left = true;

            }
            if (e.VirtualKey == Windows.System.VirtualKey.D && Hero.InMoment.Right == true)
            {
                Hero.IsMoving = true;
                right = true;

            }
            if (e.VirtualKey == Windows.System.VirtualKey.W && Hero.InMoment.Up == true)
            {
                Hero.IsMoving = true;
                up = true;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S && Hero.InMoment.Down == true)
            {
                Hero.IsMoving = true;
                down = true;
            }

        }

        public void EventFuncOff(CoreWindow sender, KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.A)
            {

                ImageSetWhileMove(Hero.StopLeft);
                Hero.IsMoving = false;
                left = false;
                
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D)
            {

                ImageSetWhileMove(Hero.StopRight);
                Hero.IsMoving = false;
                right = false;

            }
            if (e.VirtualKey == Windows.System.VirtualKey.W)
            {

                ImageSetWhileMove(Hero.StopRight);
                Hero.IsMoving = false;
                up = false;

            }
            if (e.VirtualKey == Windows.System.VirtualKey.S)
            {

                ImageSetWhileMove(Hero.StopRight);
                Hero.IsMoving = false;
                down = false;

            }
        }

        public async void UpdateMovementeFunc()
        {
            while (true)
            {
                await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                {
                    if (left)
                    {
                        TelaX -= delta_move;
                        Move_Object.SetValue(Canvas.LeftProperty, TelaX);
                        Hero.SetPosition();
                    }
                    if (right)
                    {
                        TelaX += delta_move;
                        Move_Object.SetValue(Canvas.LeftProperty, TelaX);
                        Hero.SetPosition();
                    }
                    if (up)
                    {
                        TelaY -= delta_move;
                        Move_Object.SetValue(Canvas.TopProperty, TelaY);
                        Hero.SetPosition();
                    }
                    if (down)
                    {
                        TelaY += delta_move;
                        Move_Object.SetValue(Canvas.TopProperty, TelaY);
                        Hero.SetPosition();
                    }
                });

            }

        }

        private void ImageSetWhileMove(string path)
        {
            var p = Perso.Children;
            if (p != null && p.Count == 1)
            {
                Image bit = (Image)p.First();
                bitmapImage.UriSource = new Uri(path);
                if (bit.Source != bitmapImage) bit.Source = bitmapImage;
            }
        }
    }
}
