using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class BallControl
{
    public const int MoveTypeTop = 1;
    public const int MoveTypeRight = 2;
    public const int MoveTypeBottom = 4;
    public const int MoveTypeLeft = 8;

    public abstract void SetMaze();
    public abstract int GetMove(float x, float y);
}

public class ManualBallControl : BallControl
{
    public override void SetMaze()
    {

    }

    public override int GetMove(float x, float y)
    {
        var move = 0;
        if (Input.GetKey("d"))
            move |= MoveTypeRight;
        if (Input.GetKey("s"))
            move |= MoveTypeBottom;
        if (Input.GetKey("a"))
            move |= MoveTypeLeft;
        if (Input.GetKey("w"))
            move |= MoveTypeTop;
        return move;
    }
}

public class AutoBallControl : BallControl
{
    public override void SetMaze()
    {
        // Use MazeDescription static members for initialize your maze.
        // Switch off RollerBall.UseManualBallController for using this class.
        throw new NotImplementedException();
    }

    public override int GetMove(float x, float y)
    {
        throw new NotImplementedException();
    }
}
