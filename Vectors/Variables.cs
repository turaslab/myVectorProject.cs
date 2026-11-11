using System;
using Raylib_cs;

namespace RaylibGame
{
    public static class Variables
    {
        // --- EKRAN VE PENCERE AYARLARI ---
        public const int width = 800;
        public const int height = 600;
        public const int gridSize = 25;

        public static int MouseX = 0;
        public static int MouseY = 0;
        public static int GetMouseX()
        {
            return Variables.MouseX = (Raylib.GetMouseX() - width / 2) / gridSize;
        }
        public static int GetMouseY()
        {
            return Variables.MouseY = (height / 2 - Raylib.GetMouseY()) / gridSize;
        }
    }
}
