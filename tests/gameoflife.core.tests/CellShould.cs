using FluentAssertions;
using Xunit;

namespace gameoflife.core.tests;

public class CellShould
{
    [Fact]
    public void HaveTheStateItWasInitializedWith()
    {
        var aliveCell = new Cell(CellState.Alive);
        aliveCell.State.Should().Be(CellState.Alive);
        
        var deadCell = new Cell(CellState.Dead);
        deadCell.State.Should().Be(CellState.Dead);        
    }
}