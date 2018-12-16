using System.Collections.Generic;
using UnityEngine;

public abstract class MazeDescription
{
    public static int SeedValue;
    public static int Rows;
    public static int Cols;
    public static int Coins;
    public static int BallEnergy;

    public const int CellWidth = 4;
    public const int CellHeight = 4;

    public static GameObject PillarPrefab;
    public static GameObject WallPrefab;
    public static GameObject CoinPrefab;
    public static GameObject FloorPrefab;

    public static List<MazeDescriptionCell> Cells;

    private const bool AppRunningFromConsole = false;

    public static bool IsConsoleRun()
    {
        return AppRunningFromConsole;
    }
}

public class MazeDescriptionCell
{
    public int Row, Column;
    public bool CanMoveRight, CanMoveLeft, CanMoveForward, CanMoveBackward;
    public bool HasCoin;
}
