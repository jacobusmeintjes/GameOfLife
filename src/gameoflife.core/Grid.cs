﻿namespace gameoflife.core;

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
}