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
        protected double delta_move = 0.015;
        protected dynamic Move_Object;
        BitmapImage bitmapImage = new BitmapImage();
        Thread Update;
        public HeroMovement(Canvas Tela,Hero hero)
        {

            this.Hero = hero;
            this.Perso = hero.Container;
            this.Move_Object = Tela;
            TelaX = (double)this.Hero.Posi.X;
            TelaY = (double)this.Hero.Posi.Y;
            Window.Current.CoreWindow.KeyDown += EventFunc;
            Window.Current.CoreWindow.KeyUp += EventFuncOff;
            Update = new Thread(UpdateMovementeFunc);
            Update.Start();

        }


        public void EventFunc(CoreWindow sender, KeyEventArgs e)
        {

            if (e.VirtualKey == Windows.System.VirtualKey.A )
            {
                Hero.IsMoving = true;
                left = true;
                Hero.OnCollision();

            }
            if (e.VirtualKey == Windows.System.VirtualKey.D )
            {
                Hero.IsMoving = true;
                right = true;
                Hero.OnCollision();
            }
            if (e.VirtualKey == Windows.System.VirtualKey.W  )
            {
                Hero.IsMoving = true;
                up = true;
                Hero.OnCollision();
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S )
            {
                Hero.IsMoving = true;
                down = true;
                Hero.OnCollision();
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
                    UpdateMove();
                });

            }

        }

        public override void UpdateMove()
        {
            if (left && Hero.InMoment.Left)
            {
                TelaX -= delta_move;
                Move_Object.SetValue(Canvas.LeftProperty, TelaX);
                Hero.SetPosition();
            }
            if (right && Hero.InMoment.Right)
            {
                TelaX += delta_move;
                Move_Object.SetValue(Canvas.LeftProperty, TelaX);
                Hero.SetPosition();
            }
            if (up &&  Hero.InMoment.Up)
            {
                TelaY -= delta_move;
                Move_Object.SetValue(Canvas.TopProperty, TelaY);
                Hero.SetPosition();
            }
            if (down && Hero.InMoment.Down)
            {
                TelaY += delta_move;
                Move_Object.SetValue(Canvas.TopProperty, TelaY);
                Hero.SetPosition();
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
