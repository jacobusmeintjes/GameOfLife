using System.Text;

namespace gameoflife.core;

public class Grid
{
    public int Rows { get; }
    public int Columns { get; }
    public Cell[,] Cells { get; }

    public Grid(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;

        Cells = new Cell[Rows, Columns];

        InitializeGridStates();
    }

    private void InitializeGridStates()
    {
        for (var row = 0; row < Rows; row++)
        {
            for (var column = 0; column < Columns; column++)
            {
                var cellState = CellState.Dead;
                var state = new Random().Next(100);
                if (state > 50)
                {
                    cellState = CellState.Alive;
                }
                
                Cells[row, column] = new Cell(cellState);
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (var row = 0; row < Rows; row++)
        {
            for (var column = 0; column < Columns; column++)
            {
                sb.Append(Cells[row, column].State == CellState.Alive ? "*" : ".");
            }

            sb.Append(Environment.NewLine);
        }

        return sb.ToString();
    }

    public void ExecuteNextState()
    {
        for (var row = 0; row < Rows; row++)
        {
            for (var column = 0; column < Columns; column++)
            {
                var currentCell = Cells[row, column];
                
                //Find neighbours of cell
                var liveNeighbourCount = FindLiveNeighbourCells(row, column);

                var newState = currentCell.NextState(liveNeighbourCount);

                currentCell.SetNextState(newState);
            }
        }
    }

    private int FindLiveNeighbourCount(List<Position> positions)
    {
        var result = 0;
        foreach (var position in positions)
        {
            if (Cells[position.Row, position.Column].State == CellState.Alive)
            {
                result++;
            }
        }

        return result;
    }

    private int FindLiveNeighbourCells(int row, int column)
    {
        var result = 0;

        for (var irow = row-1; irow <= row+1; irow++)
        {
            for (var icolumn = column - 1; icolumn <= column + 1; icolumn++)
            {
                if (irow == row && icolumn == column) continue;
                if (irow < 0 || icolumn < 0) continue;
                if (irow >= Rows || icolumn >= Columns) continue;
                
                if (Cells[irow, icolumn].State == CellState.Alive)
                {
                    result++;
                }
            }
        }
        
        return result;
    }
}

public record Position(int Row, int Column);
