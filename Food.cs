using Raylib_cs;
using Vinterprojekt_2023;

public class Food
{

    public int additionalTime = 0;
    public Rectangle rect;
    public Texture2D image;
    //public string Name { get => name; set => name = value; }s
    public static List<Food> foods = new List<Food>();
    public static List<Food> foodsToRemove = new List<Food>();
    public float timeBetweenFoods;
    public int foodsBetweenDifficulties;
    public float foodTimer;
    public Food()
    {
        Random generator = new Random();
        int y = generator.Next(900);
        int x = generator.Next(1600);
        rect = new Rectangle(x, y, 50, 50);
    }

    // public static void Spawn() 
    // {
    //     foods.Add(new Food()); // skapar en ny food
    // }

    // public static void Eaten(Cube cube)
    // {
    //     foreach (Food f in foods)
    //     {
    //         if (Game.CollisionCheck(cube, f))
    //         {
    //             foodsToRemove.Add(f);
    //             Game.time += f.additionalTime;
    //         }
    //     }
    // }

    // public void Spawn() // metod som skapar en ny enemy
    // {
    //     if (foodTimer < 0) // if sats som kollar om enemytimer är mindre än noll. Nedanstående görs då.
    //     {
    //         foodTimer = timeBetweenFoods;
    //         foods.Add(new Food());
    //     }
    // }
    // public static void Clear()
    // {
    //     foreach (Food f in foodsToRemove)
    //     {
    //         foods.Remove(f);
    //     }
    // }
    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.RED);
    }
    public static void DrawAll()
    {
        foreach (Food f in foods)
        {
            f.Draw();
        }
    }














    // private int _hp;
    // private string name;

    // public int Hp
    // {
    //     get
    //     {
    //         return _hp;
    //     }
    //     set
    //     {
    //         _hp = value;
    //         if (_hp < 0) Hp = 0;
    //         if (_hp > 100) _hp = 100;
    //     }
    // }



    // public int GetHP()
    // {
    //     return _hp;
    // }

    // public void SetHp(int value)
    // {
    //     _hp = value;
    //     if (_hp < 0) _hp = 0;
    // }

    // public void Hurt(int amount)
    // {
    //     SetHp(GetHP() - amount);
    // }
}

