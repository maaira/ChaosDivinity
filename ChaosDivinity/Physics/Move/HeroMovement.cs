using ChaosDivinity.Char;
using System;
using System.Linq;
using System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace ChaosDivinity.Physics
{
    class HeroMovement : Movement
    {
        protected Hero Hero;
        protected double delta_move = 0.05;
        protected double delta_move_ = 0.05;
        protected dynamic Move_Object;
        protected dynamic Map;
        protected double m_tela_x, m_tela_y;
        BitmapImage bitmapImage = new BitmapImage();
        Thread Update;

        public HeroMovement(Canvas Tela,Hero hero)
        {

            this.Hero = hero;
            this.Move_Object = Tela;
            this.Map = Tela;
            TelaX = (double)this.Hero.Posi.X;
            TelaY = (double)this.Hero.Posi.Y;
            m_tela_x = (double)Tela.GetValue(Canvas.LeftProperty);
            m_tela_y = (double)Tela.GetValue(Canvas.TopProperty);
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
                
            }
            if (e.VirtualKey == Windows.System.VirtualKey.D )
            {
                Hero.IsMoving = true;
                right = true;
                
            }
            if (e.VirtualKey == Windows.System.VirtualKey.W  )
            {
                Hero.IsMoving = true;
                up = true;
               
            }
            if (e.VirtualKey == Windows.System.VirtualKey.S )
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
                    UpdateMove();
                });

            }

        }

        public override void UpdateMove()
        {
            if (left && Hero.InMoment.Left)
            {
                TelaX -= delta_move;
                m_tela_x += delta_move_;
                Move_Object.SetValue(Canvas.LeftProperty, m_tela_x);
                Hero.Container.SetValue(Canvas.LeftProperty, TelaX);
                Hero.SetPosition();
                Hero.OnCollision();
            }
            if (right && Hero.InMoment.Right)
            {
                TelaX += delta_move;
                m_tela_x -= delta_move_;
                Move_Object.SetValue(Canvas.LeftProperty, m_tela_x);
                Hero.Container.SetValue(Canvas.LeftProperty, TelaX);
                Hero.SetPosition();
                Hero.OnCollision();
            }
            if (up &&  Hero.InMoment.Up)
            {
                TelaY -= delta_move;
                m_tela_y += delta_move_;
                Move_Object.SetValue(Canvas.TopProperty, m_tela_y);
                Hero.Container.SetValue(Canvas.TopProperty, TelaY);
                Hero.Container.SetValue(Canvas.ZIndexProperty, Hero.Container.Margin.Top);
                Hero.SetPosition();
                Hero.OnCollision();
            }
            if (down && Hero.InMoment.Down)
            {
                TelaY += delta_move;
                m_tela_y -= delta_move_;
                Move_Object.SetValue(Canvas.TopProperty, m_tela_y);
                Hero.Container.SetValue(Canvas.TopProperty, TelaY);
                Hero.Container.SetValue(Canvas.ZIndexProperty, Hero.Container.Margin.Top);
                Hero.SetPosition();
                Hero.OnCollision();
            }
        }

        private void ImageSetWhileMove(string path)
        {
            var p = Hero.Container.Children;
            if (p != null && p.Count == 1)
            {
                Image bit = (Image)p.First();
                bitmapImage.UriSource = new Uri(path);
                if (bit.Source != bitmapImage) bit.Source = bitmapImage;
            }
        }
    }
}
