using FluentAssertions;
using Xunit;

namespace gameoflife.core.tests;

public class CellShould
{
    [Fact]
    public void BeInTheStateItWasInitializedWith()
    {
        var aliveCell = new Cell(CellState.Alive);
        aliveCell.State.Should().Be(CellState.Alive);
        
        var deadCell = new Cell(CellState.Dead);
        deadCell.State.Should().Be(CellState.Dead);        
    }

    [Fact]
    public void DieFromUnderPopulationIfTheCellHasFewerThanTwoLiveNeighbours()
    {
        var aliveCellWithZeroNeighbours = new Cell(CellState.Alive);
        aliveCellWithZeroNeighbours.NextState(0).Should().Be(CellState.Dead);
        
        var aliveCellWithOneNeighbour = new Cell(CellState.Alive);
        aliveCellWithOneNeighbour.NextState(1).Should().Be(CellState.Dead);
    }
    
    
    [Fact]
    public void DieFromOvercrowdingIfMoreThanThreeLiveNeighbours()
    {
        var aliveCellWithThreeNeighbours = new Cell(CellState.Alive);
        aliveCellWithThreeNeighbours.NextState(4).Should().Be(CellState.Dead);
    }
}