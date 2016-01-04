namespace Battleships.GameObjects
{
    /// <summary>
    /// A cruiser is a special kind of a ship.
    /// It is 3pixel in size
    /// </summary>
    public class Cruiser : Ship
    {
        public bool IsMiddleHit { get; set; }
        public int PosMiddleX { get; set; }
        public int PosMiddleY { get; set; }
    }
}