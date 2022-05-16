using System.Diagnostics;
using FluentAssertions;
using Xunit;

namespace gameoflife.core.tests;

public class GridShould
{
    [Fact]
    public void BeInitializedWithRowsAndColumns()
    {
        var grid = new Grid(4, 8);

        grid.Rows.Should().Be(4);
        grid.Columns.Should().Be(8);

        grid.Cells.Length.Should().Be(32);
    }
    
    [Fact]
    public void BeInitializedWithRowsAndColumnsAndRandomizeCellState()
    {
        var grid = new Grid(4, 8);

        grid.Rows.Should().Be(4);
        grid.Columns.Should().Be(8);

        foreach (var cell in grid.Cells)
        {
            cell.Should().NotBeNull();
        }

        var currentState = grid.Cells[0, 0].State;
        for (var row = 0; row < grid.Rows; row++)
        {
            for (var column = 0; column < grid.Columns; column++)
            {
                if (currentState != grid.Cells[row, column].State)
                {
                    currentState = grid.Cells[row, column].State;
                    break;
                }
            }
        }

        currentState.Should().NotBe(grid.Cells[0, 0].State);
    }
}