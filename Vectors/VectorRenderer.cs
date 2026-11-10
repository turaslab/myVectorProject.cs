
using Raylib_cs;
using RaylibGame;

public class VectorRenderer

{
    int originX = Variables.width / 2;
    int originY = Variables.height / 2;
    public void RenderVector(Vector vector)
    {

        int endX = originX + (int)(vector.XComponent * Variables.gridSize);
        int endY = originY - (int)(vector.YComponent * Variables.gridSize);

        Raylib.DrawLineEx(
        new System.Numerics.Vector2(originX, originY),
        new System.Numerics.Vector2(endX, endY),
        3f,
        Color.Green
        );

    }
}