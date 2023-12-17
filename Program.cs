global using System.Numerics;
using Raylib_cs;
using Vinterprojekt_2023;

Raylib.InitWindow(1600, 900, "dinorunner");


Raylib.SetTargetFPS(60);
Cube c = new();
Food f = new();
Apple a = new();
Banana b = new();
FoodFactory factory = new();
Game game = new();
// Texture2D bkg;
// bkg = Raylib.LoadTexture("background1.png");
//---------------------------------------SPEL LOGIK----------------------------------------//
while (!Raylib.WindowShouldClose())
    Raylib.BeginDrawing(); // börjar rita spelet
game.CheckScreen();
{
    if (game.CheckScreen() == "play")
    {
        // Raylib.DrawTexture(bkg, 0, 0, Color.WHITE); // ritar upp bilden för scenen
        Game.UpdateAll(c, factory, f, a, b);
        game.CheckTimer();
        Game.DrawAll(c, f, factory, FoodFactory.apples, FoodFactory.bananas);
        Raylib.EndDrawing();

    }

    //---------------------------------------SPEL GRAFIK----------------------------------------//

}