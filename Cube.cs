using Raylib_cs;

public class Cube
{

    public Rectangle rect;
    public Texture2D image;

    public int health = 100;
    public Cube()
    {
        rect = new Rectangle(800, 450, 100, 100);

    }

    public void Move()
    {
        float speed = 5;

        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            rect.X += speed;

        }

        else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            rect.X -= speed;

        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            rect.Y -= speed;

        }
        else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            rect.Y += speed;

        }
    }
    public void WallCollision()
    {
        if (rect.X <= 0)
        {
            rect.X += 20;
        }
        if (rect.X >= Raylib.GetScreenWidth() - 100)
        {
            rect.X -= 20;
        }
        if (rect.Y >= Raylib.GetScreenHeight() - 100)
        {
            rect.Y -= 20;
        }
        if (rect.Y <= 10)
        {
            rect.Y += 20;
        }
    }
    public void Update()
    {
        Move();
        WallCollision();
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.DARKGREEN);
    }
}