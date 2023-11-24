using Raylib_cs;

public class Enemy
{
    public Rectangle rect;
    public Texture2D image;
    //public string Name { get => name; set => name = value; }
    public int speed;
    public int damage;
    public static List<Enemy> enemies = new List<Enemy>(); // skapar en lista för enemies
    public static List<Enemy> enemiesToRemove = new List<Enemy>(); // skapar en lista för enemies som ska tas bort
    public Enemy()  //metod som skapar zombies på en slumpmässig plats längs y axeln, med en rektangel på 500x200 px
    {
        Random generator = new Random();
        int y = generator.Next(900);
        int x = generator.Next(1600);
        rect = new Rectangle(x, y, 50, 50);
    }

    public static void Spawn() // metod som skapar en ny enemy
    {
        enemies.Add(new Enemy()); // skapar en ny enemy
    }

    public static void Eaten(Cube cube)
    {
        foreach (Enemy e in enemies)
        {
            if (Game.CollisionCheck(cube, e))
            {
                enemiesToRemove.Add(e);
                Game.timeleft += 10;
            }
        }
    }
    public static void Clear() // metod som tar bort enemies i listan enemiesToRemove
    {
        foreach (Enemy e in enemiesToRemove)
        {
            enemies.Remove(e);
        }
    }
    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.RED);
    }
    public static void DrawAll() // en metod som ritar alla enemies
    {
        foreach (Enemy e in enemies)
        {
            e.Draw();
        }
    }

    public void Update(Cube cube)
    {
        Clear();
        Eaten(cube);
        Spawn();
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

