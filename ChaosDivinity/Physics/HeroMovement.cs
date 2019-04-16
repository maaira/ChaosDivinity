using ChaosDivinity.Char;
using ChaosDivinity.Physics;
using System;
using System.Diagnostics;
using System.Linq;
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
        protected Canvas Tela;
        protected Hero Hero;
        protected dynamic Move_Object;
        protected Thread UpdateMovement;
        protected bool control_move;
        BitmapImage bitmapImage = new BitmapImage();


        public HeroMovement(Canvas Perso, Canvas Tela, Hero hero)
        {
            this.Hero = hero;
            this.Perso = Perso;
            this.Tela = Tela;
            this.Move_Object = Tela;
            TelaX = (double)this.Tela.GetValue(Canvas.LeftProperty);
            TelaY = (double)this.Tela.GetValue(Canvas.TopProperty);
            Window.Current.CoreWindow.KeyDown += EventFunc;
            Window.Current.CoreWindow.KeyUp += EventFuncOff;
            UpdateMovement = new Thread(UpdateMovementeFunc);
            UpdateMovement.Start();
        }

        public void SetImage(CoreWindow sender, KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.A && e.VirtualKey == Windows.System.VirtualKey.W)
            {
                ImageSetWhileMove(Hero.MoveToLeft);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.A && e.VirtualKey == Windows.System.VirtualKey.S)
            {
                ImageSetWhileMove(Hero.MoveToLeft);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D && e.VirtualKey == Windows.System.VirtualKey.W)
            {
                ImageSetWhileMove(Hero.MoveToRight);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D && e.VirtualKey == Windows.System.VirtualKey.S)
            {
                ImageSetWhileMove(Hero.MoveToRight);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.A && Hero.MovingToLeft == false)
            {
                ImageSetWhileMove(Hero.MoveToLeft);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D && Hero.MovingToRight == false)
            {
                ImageSetWhileMove(Hero.MoveToRight);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.W && Hero.MovingToUp == false)
            {
                ImageSetWhileMove(Hero.MoveToLeft);
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S && Hero.MovingToDown == false)
            {
                ImageSetWhileMove(Hero.MoveToRight);
            }
        }

        public void EventFunc(CoreWindow sender, KeyEventArgs e)
        {

            if (e.VirtualKey == Windows.System.VirtualKey.A)
            {
                ImageSetWhileMove(Hero.MoveToLeft);
                Debug.WriteLine(e.VirtualKey);
                Hero.MovingToLeft = true;
                Hero.IsMoving = true;
                left = true;

            }
            if (e.VirtualKey == Windows.System.VirtualKey.D)
            {
                ImageSetWhileMove(Hero.MoveToRight);
                Debug.WriteLine(e.VirtualKey);
                Hero.MovingToRight = true;
                Hero.IsMoving = true;
                right = true;

            }
            if (e.VirtualKey == Windows.System.VirtualKey.W)
            {
                ImageSetWhileMove(Hero.MoveToLeft);
                Hero.MovingToUp = true;
                Hero.IsMoving = true;
                control_move = true;
                up = true;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S)
            {

                ImageSetWhileMove(Hero.MoveToRight);
                Hero.MovingToDown = true;
                Hero.IsMoving = true;
                control_move = true;
                down = true;
            }

        }

        public void EventFuncOff(CoreWindow sender, KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.A)
            {
                ImageSetWhileMove(Hero.StopLeft);
                Hero.MovingToLeft = false;
                Hero.IsMoving = false;
                left = false;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D)
            {
                ImageSetWhileMove(Hero.StopRight);
                Hero.MovingToRight = false;
                Hero.IsMoving = false;
                right = false;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.W)
            {
                ImageSetWhileMove(Hero.StopRight);
                Hero.MovingToUp = false;
                Hero.IsMoving = false;
                up = false;
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S)
            {
                ImageSetWhileMove(Hero.StopRight);
                Hero.MovingToDown = false;
                Hero.IsMoving = false;
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
                        Move_Object.SetValue(Canvas.LeftProperty, TelaX);
                    }
                    if (right)
                    {
                        TelaX -= 0.035;
                        Move_Object.SetValue(Canvas.LeftProperty, TelaX);
                    }
                    if (up)
                    {
                        TelaY += 0.035;
                        Move_Object.SetValue(Canvas.TopProperty, TelaY);
                    }
                    if (down)
                    {
                        TelaY -= 0.035;
                        Move_Object.SetValue(Canvas.TopProperty, TelaY);
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
