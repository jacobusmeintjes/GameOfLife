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
    }
}