using ChaosDivinity.Assets;
using ChaosDivinity.Char;
using ChaosDivinity.Managers;
using ChaosDivinity.NPCNamespace;
using ChaosDivinity.VisualGame.Menu;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;


namespace ChaosDivinity.VisualGame.Maps
{
    public sealed partial class City : Page
    {
        private Hero hero;
        private MediaPlayer song = new MediaPlayer();
        public City()
        {
            this.InitializeComponent();
            QuestList.LoadQuestList();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            Window.Current.CoreWindow.KeyDown += SkillAsync;
            song.Source = MediaSource.CreateFromUri(new System.Uri("ms-appx:///Assets/Musicas/City.mp3"));
            song.Play();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is Hero)
            {

                hero = e.Parameter as Hero;
                Debug.WriteLine(hero.Nome);
            }

            base.OnNavigatedTo(e);
        }

        private void Init(FrameworkElement sender, object args)
        {
            MapManager m = new MapManager();
            UpdateUpBar();
            UpdateSkillBar();
            m.Map(hero, Background, Perso, MOB, MOB2, MOB3);
        }

        private void SlotShop(object sender, PointerRoutedEventArgs e)
        {
            Debug.WriteLine("Imagem clicada : " + ((Image)sender).Name);
        }

        private void UpdateUpBar()
        {
            if (hero == null) return;
            Hero_img.Children.Add(ImageView.ImageSet(hero.Path));
            XP.Text = "Experiencia: " + hero.Xp_atual + " | " + hero.Xp_total;
            Name.Text = hero.Nome.ToUpper();
            Life.Text = "Life : " + hero.Hp_atual + " | " + hero.Hp_total;
            Inteligencia.Text = "Inteligencia : " + hero.Intelligence;
            Agilidade.Text = "Agilidade" + hero.Agility;
            Força.Text = "Força : " + hero.Power;
            Vitalidade.Text = "Vitalidade : " + hero.Vitality;
            Sorte.Text = "Sorte : " + hero.Sort;
            Lv.Text = "Nivel : " + hero.Lvl;
            if (hero.MinimumObjectInteractive == null) return;
            //Debug.WriteLine(hero.MinimumObjectInteractive);
            Enemie_img.Children.Add(ImageView.ImageSet(hero.MinimumObjectInteractive.Path));
            Life2.Text = "Life : " + ((Enemies)hero.MinimumObjectInteractive).Hp_atual + " | " + ((Enemies)hero.MinimumObjectInteractive).Hp_total;
            Lv2.Text = "Nivel : " + ((Enemies)hero.MinimumObjectInteractive).Lvl;
            Warning.Text = "Atenção, lute com o inimigo para poder prosseguir!!! Boa sorte guerreiro.";
            
        }

        public void SkillAsync(CoreWindow sender, KeyEventArgs e)
        {
            if (e.VirtualKey == Windows.System.VirtualKey.Number1 || e.VirtualKey == Windows.System.VirtualKey.Number2 || e.VirtualKey == Windows.System.VirtualKey.Number3)
            {
                if (hero.ListofSkill[e.VirtualKey] == null || hero.MinimumObjectInteractive == null) return;

                ((Enemies)hero.MinimumObjectInteractive).Hp_atual -= hero.ListofSkill[e.VirtualKey].Executar();                
                UpdateUpBar();
                if (((Enemies)hero.MinimumObjectInteractive).Hp_atual <= 0)
                {
                    hero.MinimumObjectInteractive.EndExistence();
                    hero.MinimumObjectInteractive = null;
                    Warning.Text = "Voce ganhou!!!Derretou o inimigo!!!";
                    hero.InMoment.RevertMoment();
                }

                if (hero.MinimumObjectInteractive == null) return;

                Random rnd = new Random();
                int id_random = rnd.Next(1, 3);
                hero.Hp_atual -= ((Enemies)hero.MinimumObjectInteractive).ListofSkill[id_random].Executar();
                
                UpdateUpBar();
                if (hero.Hp_atual <= 0)
                {
                    Warning.Text = "Voce perdeu, o jogo reiniciara...";
                    this.Frame.GoBack();                    

                }
               
            }
            
        }

        private void UpdateSkillBar()
        {
            if (hero == null) return;
            n1.Text = hero.ListofSkill[Windows.System.VirtualKey.Number1].Skill_name.ToUpper();
            Custo_mp.Text = "Custo Mana : " + hero.ListofSkill[Windows.System.VirtualKey.Number1].Custo_mp;
            Lv_requerido.Text = "Level : " + hero.ListofSkill[Windows.System.VirtualKey.Number1].Lv_requerido;
            Hp_up.Text = "Aumento de Vida : " + hero.ListofSkill[Windows.System.VirtualKey.Number1].Hp_up;
            Mp_up.Text = "Aumento de Mana : " + hero.ListofSkill[Windows.System.VirtualKey.Number1].Mp_up;
            Skill_dmg.Text = "Dano : " + hero.ListofSkill[Windows.System.VirtualKey.Number1].Skill_dmg;

            n2.Text = hero.ListofSkill[Windows.System.VirtualKey.Number2].Skill_name.ToUpper();
            Custo_mp2.Text = "Custo Mana : " + hero.ListofSkill[Windows.System.VirtualKey.Number2].Custo_mp;
            Lv_requerido2.Text = "Level : " + hero.ListofSkill[Windows.System.VirtualKey.Number2].Lv_requerido;
            Hp_up2.Text = "Aumento de Vida : " + hero.ListofSkill[Windows.System.VirtualKey.Number2].Hp_up;
            Mp_up2.Text = "Aumento de Mana : " + hero.ListofSkill[Windows.System.VirtualKey.Number2].Mp_up;
            Skill_dmg2.Text = "Dano : " + hero.ListofSkill[Windows.System.VirtualKey.Number2].Skill_dmg;

            n3.Text = hero.ListofSkill[Windows.System.VirtualKey.Number3].Skill_name.ToUpper();
            Custo_mp3.Text = "Custo Mana : " + hero.ListofSkill[Windows.System.VirtualKey.Number3].Custo_mp;
            Lv_requerido3.Text = "Level : " + hero.ListofSkill[Windows.System.VirtualKey.Number3].Lv_requerido;
            Hp_up3.Text = "Aumento de Vida : " + hero.ListofSkill[Windows.System.VirtualKey.Number3].Hp_up;
            Mp_up3.Text = "Aumento de Mana : " + hero.ListofSkill[Windows.System.VirtualKey.Number3].Mp_up;
            Skill_dmg3.Text = "Dano : " + hero.ListofSkill[Windows.System.VirtualKey.Number3].Skill_dmg;

        }

    }
}