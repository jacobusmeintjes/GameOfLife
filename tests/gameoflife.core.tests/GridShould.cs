using System.Diagnostics;
using Xunit;

namespace gameoflife.core.tests;

public class GridShould
{
    [Fact]
    public void BeInitializedWithRowsAndColumns()
    {
        var grid = new Grid(4, 8);
    }
}