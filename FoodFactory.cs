namespace Vinterprojekt_2023;
using Raylib_cs;
public class FoodFactory : Food
{

    public void Eaten(Cube cube)
    {
        foreach (Food f in foods)
        {
            if (Game.CollisionCheck(cube, f))
            {
                Food.foodsToRemove.Add(f);
                Game.time += f.additionalTime;
            }
        }
    }


    public void CheckFoodTimer()
    {
        if (foodTimer < 0)
        {
            foodTimer = timeBetweenFoods;
            Spawn();
        }
    }
    public void Spawn()
    {
        foods.Add(new Food());
    }

    public void Clear()
    {
        foreach (Food f in foodsToRemove)
        {
            foods.Remove(f);
        }
    }

    public void Update(Cube cube)
    {
        Clear();
        Eaten(cube);
        CheckFoodTimer();
    }

}