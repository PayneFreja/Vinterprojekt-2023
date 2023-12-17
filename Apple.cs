using System.Drawing;
using Raylib_cs;

public class Apple : Food
{

    public Apple()
    {
        additionalTime = 3;
        timeBetweenFoods = 2;
        foodTimer = 0;
        col = Raylib_cs.Color.RED;


    }
}