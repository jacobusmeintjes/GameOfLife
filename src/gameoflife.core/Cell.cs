namespace gameoflife.core;
public class Cell
{
    public CellState State { get; private set; }
    
    public Cell(CellState state)
    {
        State = state;
    }

    public CellState NextState(int neighbours)
    {
        if (State == CellState.Alive)
        {
            if (neighbours == 2 || neighbours == 3)
            {
                return CellState.Alive;
            }
        }
        return CellState.Dead;
    }
}