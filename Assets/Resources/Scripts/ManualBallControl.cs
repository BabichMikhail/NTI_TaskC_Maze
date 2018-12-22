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
