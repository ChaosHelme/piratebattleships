namespace Battleships.GameObjects
{
    /// <summary>
    /// This is the base ship class.
    /// A base ship is known as a boat, is 2pixel in size and is the smallest ship in the game.
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// Indicates if the front of the ship is hit.
        /// </summary>
        public bool IsFrontHit { get; set; }
        public bool IsHeckHit { get; set; }
        public bool IsShipDestroyed { get; set; }
        public int PosFrontX { get; set; }
        public int PosFrontY { get; set; }
        public int PosHeckX { get; set; }
        public int PosHeckY { get; set; }
        public string Name { get; set; }
        public bool Horizontal { get; set; }
    }
}