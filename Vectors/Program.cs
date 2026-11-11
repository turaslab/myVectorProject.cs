
using System.Security.Cryptography.X509Certificates;
using Raylib_cs;
using RaylibGame;

Raylib.InitWindow(Variables.width, Variables.height, "Vector Visualizer");
Raylib.SetTargetFPS(60);

/*Benim vektör*/
VectorRenderer vectorRenderer = new VectorRenderer();
Vector p1 = new Vector(3, 4);

int startX;
int startY;
int endX;
int endY;

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Black);

    // Dikey çizgiler
    for (int x = 0; x <= Variables.width; x += Variables.gridSize)
    {
        Raylib.DrawLine(x, 0, x, Variables.height, Color.DarkGray);
    }

    // Yatay çizgiler
    for (int y = 0; y <= Variables.height; y += Variables.gridSize)
    {
        Raylib.DrawLine(0, y, Variables.width, y, Color.DarkGray);
    }

    // Koordinat eksenleri
    Raylib.DrawLine(Variables.width / 2, 0, Variables.width / 2, Variables.height, Color.White);
    Raylib.DrawLine(0, Variables.height / 2, Variables.width, Variables.height / 2, Color.White);
    // Vektör çizme   


    vectorRenderer.RenderVector(p1);
    string text;
    text = Convert.ToString(p1.Length());
    Raylib.DrawText("Vector Length Is: " + text, 0, 0, 24, Color.Violet);

    Raylib.DrawText("Your X Is: " + Variables.GetMouseX(), 0, 24, 24, Color.Violet);
    Raylib.DrawText("Your Y Is: " + Variables.GetMouseY(), 0, 48, 24, Color.Violet);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
