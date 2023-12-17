using Raylib_cs;
using Vinterprojekt_2023;

public class Food
{

    public int additionalTime = 0;
    public Rectangle rect;
    public Texture2D image;
    //public string Name { get => name; set => name = value; }s

    public float timeBetweenFoods;
    public float foodTimer = 0;

    public int foodsBetweenDifficulties;
    // public float foodTimer;
    public Food()
    {
        Random generator = new Random();
        int y = generator.Next(900);
        int x = generator.Next(1600);
        rect = new Rectangle(x, y, 50, 50);
    }


    public void Eaten(Cube cube, List<Food> foodsToRemove, List<Apple> apples, List<Banana> bananas)
    {
        foreach (Apple a in apples)
        {
            if (Game.CollisionCheck(cube, a))
            {
                foodsToRemove.Add(a);
                Game.time += a.additionalTime;
            }
        }
        foreach (Banana b in bananas)
        {
            if (Game.CollisionCheck(cube, b))
            {
                foodsToRemove.Add(b);
                Game.time += b.additionalTime;
            }
        }
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.RED);
    }
    public static void DrawAll(List<Food> foods)
    {
        foreach (Food f in foods)
        {
            f.Draw();
        }
    }

}

