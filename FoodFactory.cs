namespace Vinterprojekt_2023;
using Raylib_cs;
public class FoodFactory
{

    // public int foodsBetweenDifficulties = 2;
    // public int additionalTime = 2;
    public int spawnAmount = 0;

    public static List<Apple> apples = new List<Apple>();
    public static List<Apple> applesToRemove = new List<Apple>();
    public static List<Banana> bananas = new List<Banana>();
    public static List<Banana> bananasToRemove = new List<Banana>();

    public void ResetAppleTimer(Apple apple)
    {
        apple.foodTimer = apple.timeBetweenFoods;
    }
    public void ResetBananaTimer(Banana banana)
    {
        banana.foodTimer = banana.timeBetweenFoods;
    }
    public void CheckFoodTimer(Food food, Apple apple, Banana banana)
    {
        apple.foodTimer -= Raylib.GetFrameTime();
        banana.foodTimer -= Raylib.GetFrameTime();
        if (apple.foodTimer < 0) //Apple
        {
            apple.foodTimer = apple.timeBetweenFoods;
            SpawnApple();
            ResetAppleTimer(apple);
        }
        if (banana.foodTimer < 0) //Banana
        {
            banana.foodTimer = banana.timeBetweenFoods;
            SpawnBanana();
            ResetBananaTimer(banana);
        }
    }
    public void SpawnApple()
    {
        apples.Add(new Apple());
    }
    public void SpawnBanana()
    {
        bananas.Add(new Banana());
    }

    public void Clear()
    {
        foreach (Apple a in applesToRemove)
        {
            apples.Remove(a);
        }
        foreach (Banana b in bananasToRemove)
        {
            bananas.Remove(b);
        }
    }

    public void Update(Cube cube, Food food, Apple apple, Banana banana)
    {
        Clear();
        food.Eaten(cube, apples, bananas, applesToRemove, bananasToRemove);
        CheckFoodTimer(food, apple, banana);
    }

    public void DrawAll()
    {
        foreach (Apple a in apples)
        {
            a.Draw();
        }
        foreach (Banana b in bananas)
        {
            b.Draw();
        }
    }

}