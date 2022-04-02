
namespace Board
{
    class GameBoard
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        public Piece[,] piece; // criando matriz

        public GameBoard(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;

            piece = new Piece[lines, columns];
        }
    }
}
