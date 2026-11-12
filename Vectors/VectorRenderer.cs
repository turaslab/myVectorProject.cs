using Raylib_cs;
using RaylibGame;

public class VectorRenderer
{
    private int startX = Variables.width / 2;
    private int startY = Variables.height / 2;

    public void Update(ref Vector vector)
    {
        int grid = Variables.gridSize;
        if (Raylib.IsMouseButtonDown(MouseButton.Right))
        {


            startX = (int)MathF.Round(Raylib.GetMouseX() / (float)grid) * grid;

            startY = (int)MathF.Round(Raylib.GetMouseY() / (float)grid) * grid;
        }

        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            vector.XComponent = (int)MathF.Round((Raylib.GetMouseX() - startX) / (float)grid) * grid;

            vector.YComponent = (int)MathF.Round((startY - Raylib.GetMouseY()) / (float)grid) * grid;
        }


    }

    public void RenderVector(Vector vector)
    {
        int endX = startX + (int)vector.XComponent;
        int endY = startY - (int)vector.YComponent;

        Raylib.DrawLineEx(
            new System.Numerics.Vector2(startX, startY),
            new System.Numerics.Vector2(endX, endY),
            3f,
            Color.Green
        );
    }
}