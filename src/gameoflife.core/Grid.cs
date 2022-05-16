namespace gameoflife.core;

public class Grid
{
    public int Rows { get;  }
    public int Columns { get; }
    public Cell[,] Cells { get; }
    public Grid(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;

        Cells = new Cell[Rows, Columns];
    }
}