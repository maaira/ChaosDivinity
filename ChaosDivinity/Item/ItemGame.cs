using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ChaosDivinity.Item
{
    class ItemGame
    {
        /* ---------- Objetos da classe ------------- */
        private String name, description; //nome do item/equipamento/consumívle
        private int def; //defesa que o equip dá
        private int dmg; //dano
        private bool equipped; //"retorna" se está equipado ou não
        private string classGroup; //qual profissão poder usar o item
        private string type; //arma, armadura, acessório, consumível, outros
        private string category; //espada, adaga, cajado
        //transformar type e category para enum (ou em último caso um dicionário) <------
        private int marketValueDraquima; //valor no NPC
        private int marketValueCash ; // 
        private Image sprite; //Imagem

        /*  ---------- Objetos para instaciar ----------- */
        public string Name { get => name; set => name = value; }
        public string Description { get => description; }
        public int Def { get => def;  }
        public int Dmg { get => dmg;  }
        public bool Equipped { get => equipped; set => equipped = value;}
        public string ClassGroup { get => classGroup;  }
        public string Typo { get => type;}
        public string Category { get => category;  }
        public int MarketValueD { get => marketValueDraquima; }
        public int MarketValueC { get => marketValueCash; }
        public Image Sprite { get => sprite; set => sprite = value; }
        


        public ItemGame(string name, string description, int def, int dmg, bool equipped, string classGroup , string typo , string category , int draqui, int cash )
        {
            this.name = name;
            this.description = description;
            this.def = def;
            this.dmg = dmg;
            this.equipped = equipped;
            this.classGroup = classGroup;
            this.type = typo;
            this.category = category;
            this.marketValueCash = cash;
            this.marketValueDraquima = draqui;

        }
    }
}
