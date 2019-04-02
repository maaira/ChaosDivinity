﻿using ChaosDivinity.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaosDivinity.Item
{
    public class DBItem
    {
        static private Dictionary<string, InventorySlot> p;
        static private string[] person = { "Guerreiro", "Ladino", "Mago", "All" };
        private static string[] type = { "Arma", "Acessorio", "Coleção", "Armadura" };
        private static string[] categoryType = { "", "Espada", "Adaga", "Cajado", "Acessorio", "Escudo" };


        public static Dictionary<string, InventorySlot> DBItens()
        {
            p = new Dictionary<string, InventorySlot>();
            p.Add("0001", new InventorySlot(new Equipment("Espada dos Mil Relampagos", "", 10, 10, 10, 10, 10, false, person[0], 100, 100, type[0], 1, "0001")));
            p.Add("0002", new InventorySlot(new Equipment("Espada de Pandora", "", 10, 10, 10, 10, 10, false, person[0], 10, 500, type[0], 1, "0002")));
            p.Add("0003", new InventorySlot(new Equipment("Arco de Artemis", "", 10, 10, 10, 10, 10, false, person[1], 100, 100, type[0], 1, "0003")));
            p.Add("0004", new InventorySlot(new Equipment("Sombras das Noites", "", 10, 10, 10, 10, 10, false, person[1], 100, 100, type[1], 1, "0004")));
            p.Add("0005", new InventorySlot(new Equipment("Cajado de Demetris", "", 10, 10, 10, 10, 10, false, person[2], 100, 100, type[0], 1, "0005")));
            p.Add("0006", new InventorySlot(new Equipment("Raio de Zeus", "", 10, 10, 10, 10, 10, false, person[2], 100, 100, type[1], 1, "0006")));
            p.Add("0007", new InventorySlot(new Consumable("Nectar", "", 50, 50, 10, 0, 1, "0007")));
            p.Add("0008", new InventorySlot(new Consumable("Ambrosia", "", 10, 10, 0, 10, 1, "0008")));
            p.Add("0009", new InventorySlot(new ItemGame("Toque de Ouro", "", 10, 10, 1, "0009")));
            p.Add("0010", new InventorySlot(new ItemGame("Oraculo  de Delfus", "", 10, 10, 1, "0010")));

            return p;
        }



    }
}