global using System.Numerics;
using Raylib_cs;

Raylib.InitWindow(1600, 900, "dinorunner");


Raylib.SetTargetFPS(60);
Cube c = new();
Enemy e = new();
Game game = new();
Texture2D bkg;
bkg = Raylib.LoadTexture("background1.png");
//---------------------------------------SPEL LOGIK----------------------------------------//
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing(); // börjar rita spelet

    //---------------------------------------SPEL GRAFIK----------------------------------------//
    Raylib.DrawTexture(bkg, 0, 0, Color.WHITE); // ritar upp bilden för scenen
    Game.UpdateAll(c, e);
    Game.DrawAll(c, e);
    Raylib.EndDrawing();

}