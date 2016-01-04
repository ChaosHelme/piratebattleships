namespace Battleships.GameObjects
{
    /// <summary>
    /// A battleship is a special kind of a ship.
    /// It is 5pixel in size and the biggest ship in the game.
    /// </summary>
    public class Battleship : Ship
    {
        public bool IsMiddle1Hit { get; set; }
        public bool IsMiddle2Hit { get; set; }
        public bool IsMiddle3Hit { get; set; }

        public int PosMiddle1X { get; set; }
        public int PosMiddle1Y { get; set; }
        public int PosMiddle2X { get; set; }
        public int PosMiddle2Y { get; set; }
        public int PosMiddle3X { get; set; }
        public int PosMiddle3Y { get; set; }
    }
}