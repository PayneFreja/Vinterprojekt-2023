namespace Vinterprojekt_2023;

public class Banana : Food
{
    public Banana()
    {
        additionalTime = 6;
        timeBetweenFoods = 6;
        foodTimer = 0;
        col = Raylib_cs.Color.YELLOW;

    }
}
