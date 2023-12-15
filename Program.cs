global using System.Numerics;
using Raylib_cs;
using Vinterprojekt_2023;

Raylib.InitWindow(1600, 900, "dinorunner");


Raylib.SetTargetFPS(60);
Cube c = new();
Food f = new();
FoodFactory factory = new();
Game game = new();
Texture2D bkg;
bkg = Raylib.LoadTexture("background1.png");
//---------------------------------------SPEL LOGIK----------------------------------------//
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing(); // börjar rita spelet

    //---------------------------------------SPEL GRAFIK----------------------------------------//
    Raylib.DrawTexture(bkg, 0, 0, Color.WHITE); // ritar upp bilden för scenen
    Game.UpdateAll(c, factory);
    Game.DrawAll(c, f);
    Raylib.EndDrawing();
}