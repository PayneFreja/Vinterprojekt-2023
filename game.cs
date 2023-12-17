using System;
using Raylib_cs;
using Vinterprojekt_2023;
public class Game
{


    public static float time = 10;
    public string showScreen = "lobby";

    public void CheckScreen()
    {
        if (showScreen == "lobby")
        {
            Lobby();

        }
        else if (showScreen == "gameOver")
        {
            GameOver();
        }

    }
    public void Lobby()
    {
        Raylib.DrawText("Welcome to CubeEater", 600, 400, 40, Color.DARKGREEN);
        Raylib.DrawText("Walk with W,S,A,D, eat as many fruits as possible before the timer runs out", 600, 500, 40, Color.DARKGREEN);
        Raylib.DrawText("Press space to start game", 600, 600, 40, Color.DARKGREEN);
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
        {
            showScreen = "play";
        }
    }
    public void GameOver()
    {
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawText("Gameover!", 600, 400, 40, Color.DARKGREEN);
        // Raylib.DrawText("Press SPACE to play again!", 600, 450, 40, Color.DARKGREEN);
        // if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) // grunder för att starta om spelet.
        // {
        //     showScreen = 1;
        //     time = 10;
        // }

    }
    public void CheckTimer()
    {
        time -= Raylib.GetFrameTime();
        if (time <= 0)
        {
            showScreen = "gameOver";
        }
    }
    public static int TimeSinceStart() // metod som konverterar en double till en int för att räkna tiden sedan start
    {
        double gameTime = Raylib.GetTime();
        int seconds = (int)gameTime; // konverterar "double gametime" till "int seconds"
        return seconds;
    }
    public static void DrawInts(List<Apple> apples, List<Banana> bananas) // en metod som ritar spelets UI
    {
        Raylib.DrawText($"Time: {time}", 400, 35, 20, Color.BLACK);
        Raylib.DrawText($"AppleListAmount: {apples.Count}", 440, 110, 20, Color.BLACK);
        Raylib.DrawText($"BananaListAmount: {bananas.Count}", 440, 130, 20, Color.BLACK);

    }
    public static bool CollisionCheck(Cube cube, Food food) // en metod som kollar kollision mellan zoey och enemy.
    {
        if (Raylib.CheckCollisionRecs(cube.rect, food.rect)) // if-sats som kollar ifall kollisionen sker, returnera true, annars returnera false.
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void UpdateAll(Cube cube, FoodFactory factory, Food food, Apple apple, Banana banana) // en metod som kallar på bullet, enemy, tank och zoeys update-metoder
    {
        cube.Update();
        factory.Update(cube, food, apple, banana);
    }
    public static void DrawAll(Cube cube, Food food, FoodFactory factory, List<Apple> apples, List<Banana> bananas) // metod som kallar på alla motsvarande draw-metoder samt UI.
    {
        cube.Draw();
        factory.DrawAll();
        DrawInts(apples, bananas);
    }

}