namespace Battleships.GameObjects
{
    /// <summary>
    /// A galley is a special kind of a ship.
    /// It is 4pixel in size
    /// </summary>
    public class Galley : Ship
    {
        public bool IsMiddle1Hit { get; set; }
        public bool IsMiddle2Hit { get; set; }

        public int PosMiddle1X { get; set; }
        public int PosMiddle1Y { get; set; }
        public int PosMiddle2X { get; set; }
        public int PosMiddle2Y { get; set; }
    }
}