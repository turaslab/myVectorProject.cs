
using Raylib_cs;
using RaylibGame;

Raylib.InitWindow(Variables.width, Variables.height, "Vector Visualizer");
Raylib.SetTargetFPS(60);

/*Benim vektör*/
Vector p1 = new Vector(6, 8);

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

    VectorRenderer vectorRenderer = new VectorRenderer();

    vectorRenderer.RenderVector(p1);
    string text;
    text = Convert.ToString(p1.Lenght());
    Raylib.DrawText("Vector Lenght Is: " + text, 0, 0, 24, Color.Violet);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
