using System;
using Raylib_cs;
public class Game
{
    public static int timeleft = 60;
    public static int timeSinceStart() // metod som konverterar en double till en int för att räkna tiden sedan start
    {
        double gameTime = Raylib.GetTime();
        int seconds = (int)gameTime; // konverterar "double gametime" till "int seconds"
        return seconds;
    }
    public static void DrawInts() // en metod som ritar spelets UI
    {
        Raylib.DrawText($"Time: {timeSinceStart()}", 400, 35, 20, Color.BLACK);
    }
    public static bool CollisionCheck(Cube cube, Enemy enemy) // en metod som kollar kollision mellan zoey och enemy.
    {
        if (Raylib.CheckCollisionRecs(cube.rect, enemy.rect)) // if-sats som kollar ifall kollisionen sker, returnera true, annars returnera false.
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void UpdateAll(Cube cube, Enemy enemy) // en metod som kallar på bullet, enemy, tank och zoeys update-metoder
    {
        cube.Update();
        enemy.Update(cube);
    }
    public static void DrawAll(Cube cube, Enemy enemy) // metod som kallar på alla motsvarande draw-metoder samt UI.
    {
        cube.Draw();
        Enemy.DrawAll();
        DrawInts();
    }

}