namespace Vinterprojekt_2023;
using Raylib_cs;
public class FoodFactory
{

    // public int foodsBetweenDifficulties = 2;
    // public int additionalTime = 2;
    public int spawnAmount = 0;

    public static List<Apple> apples = new List<Apple>();
    public static List<Banana> bananas = new List<Banana>();

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
        // spawnAmount++;
    }
    public void SpawnBanana()
    {
        bananas.Add(new Banana());
        // spawnAmount++;
    }

    public void Clear(List<Food> foodsToRemove)
    {
        foreach (Apple a in foodsToRemove)
        {
            apples.Remove(a);
        }
        foreach (Banana b in foodsToRemove)
        {
            bananas.Remove(b);
        }
    }

    public void Update(Cube cube, List<Food> foodsToRemove, Food food, Apple apple, Banana banana)
    {
        Clear(foodsToRemove);
        food.Eaten(cube, foodsToRemove, apples, bananas);
        CheckFoodTimer(food, apple, banana);
    }

}