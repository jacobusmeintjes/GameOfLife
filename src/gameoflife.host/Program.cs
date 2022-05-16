// See https://aka.ms/new-console-template for more information

using gameoflife.core;

Console.WriteLine("Hello, World!");

int defaultRows = 4, defaultColumns = 4;

if (args.Length == 2 && !string.IsNullOrEmpty(args[0]) && !string.IsNullOrEmpty(args[1]))
{
    if (int.TryParse(args[0], out var rows) && int.TryParse(args[1], out var cols))
    {
        defaultRows = rows;
        defaultColumns = cols;
    }
}

var grid = new Grid(defaultRows, defaultColumns);
var current = grid.ToString();
while (true)
{   
    
    grid.ExecuteNextState();
    Console.Clear();
    if (current == grid.ToString())
    {
        break;
    }

    current = grid.ToString();
    Console.Write(current);
    Thread.Sleep(300);
}