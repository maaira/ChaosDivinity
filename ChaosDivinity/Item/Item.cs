using ChaosDivinity.Physics;

namespace ChaosDivinity.Item
{
    public class ItemGame : PhysicObject 
    {
        /*  ---------- Objetos para instanciar ----------- */
        public string Name { get; set; }
        public string Description { get; set; }
        public int MarketValue { get; set; }
        public int SellValue { get; set; }
        public int Level { get; set; }
        public string ID { get; set; }
        public string Path { get; set; }

    }
}
