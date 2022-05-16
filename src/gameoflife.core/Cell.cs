namespace gameoflife.core;
public class Cell
{
    public CellState State { get; private set; }
    
    public Cell(CellState state)
    {
        State = state;
    }
}