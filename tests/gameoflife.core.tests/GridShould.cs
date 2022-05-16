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
    }
}