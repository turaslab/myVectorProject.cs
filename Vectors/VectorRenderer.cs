
using Raylib_cs;
using RaylibGame;

public class VectorRenderer

{

    int startX = Raylib.GetMouseX();
    int startY = Raylib.GetMouseY();
    public void RenderVector(Vector vector)
    {

        if (Raylib.IsMouseButtonDown(MouseButton.Right))
        {
            startX = Raylib.GetMouseX();
            startY = Raylib.GetMouseY();
        }

        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            vector.XComponent = Convert.ToInt32(Variables.GetMouseX());
            vector.YComponent = Convert.ToInt32(Variables.GetMouseY());
        }

        int endX = startX + (int)(vector.XComponent * Variables.gridSize);
        int endY = startY - (int)(vector.YComponent * Variables.gridSize);

        Raylib.DrawLineEx(
        new System.Numerics.Vector2(startX, startY),
        new System.Numerics.Vector2(endX, endY),
        3f,
        Color.Green
        );

    }
}