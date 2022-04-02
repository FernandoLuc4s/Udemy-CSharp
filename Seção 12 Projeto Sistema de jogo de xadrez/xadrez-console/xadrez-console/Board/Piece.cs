namespace Board
{
    class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QuantityMovement { get; protected set; }
        public GameBoard Board { get; protected set; }

        public Piece(Position position, Color color, GameBoard board)
        {
            Position = position;
            Color = color;
            Board = board;
            QuantityMovement = 0;
        }
    }
}
