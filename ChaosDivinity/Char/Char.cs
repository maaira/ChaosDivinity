using ChaosDivinity.Physics;

namespace ChaosDivinity.Char
{
    public abstract class Character : PhysicObject
    {                        
        public string Nome { get; set ; }
        public int Hp_atual { get ; set; }
        public int Hp_total { get ; set ; }
        public int Mp_atual { get ; set ; }
        public int Mp_total { get ; set; }
        public int Damage { get ; set ; }
        public int Lvl { get ; set; }
                
        public Character(string nomeChar, int hp_atual, int hp_total, int mp_atual, int mp_total, int lvl) : base()
        {
            this.Nome = nomeChar;
            this.Hp_atual = hp_atual;
            this.Hp_total = hp_total;
            this.Mp_atual = mp_atual;
            this.Mp_total = mp_total;
            this.Lvl = lvl;

        }

        public void Action(){
            
        }



    }
}