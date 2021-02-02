using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftplayercitybutton : MonoBehaviour
{
    public static leftplayercitybutton leftinstance;

    public int[] leftcities = new int[41];

    public int leftcitycounter = 1;

    private void Awake()
    {
        makeinstance();

    }

    void makeinstance()
    {
        if(leftinstance == null)
        {
            leftinstance = this;
        }
    }

    public void city1()
    {
        leftcities[leftcitycounter] = 1;
        leftcitycounter++;
    }
    public void city3()
    {
        leftcities[leftcitycounter] = 3;
        leftcitycounter++;
    }
    public void city5()
    {
        leftcities[leftcitycounter] = 5;
        leftcitycounter++;
    }
    public void city6()
    {
        leftcities[leftcitycounter] = 6;
        leftcitycounter++;
    }
    public void city8()
    {
        leftcities[leftcitycounter] = 8;
        leftcitycounter++;
    }
    public void city9()
    {
        leftcities[leftcitycounter] = 9;
        leftcitycounter++;
    }
    public void city11()
    {
        leftcities[leftcitycounter] = 11;
        leftcitycounter++;
    }
    public void city12()
    {
        leftcities[leftcitycounter] = 12;
        leftcitycounter++;
    }
    public void city13()
    {
        leftcities[leftcitycounter] = 13;
        leftcitycounter++;
    }
    public void city14()
    {
        leftcities[leftcitycounter] = 14;
        leftcitycounter++;
    }
    public void city15()
    {
        leftcities[leftcitycounter] = 15;
        leftcitycounter++;
    }
    public void city16()
    {
        leftcities[leftcitycounter] = 16;
        leftcitycounter++;
    }
    public void city18()
    {
        leftcities[leftcitycounter] = 18;
        leftcitycounter++;
    }
    public void city19()
    {
        leftcities[leftcitycounter] = 19;
        leftcitycounter++;
    }
    public void city21()
    {
        leftcities[leftcitycounter] = 21;
        leftcitycounter++;
    }
    public void city23()
    {
        leftcities[leftcitycounter] = 23;
        leftcitycounter++;
    }
    public void city24()
    {
        leftcities[leftcitycounter] = 24;
        leftcitycounter++;
    }
    public void city25()
    {
        leftcities[leftcitycounter] = 25;
        leftcitycounter++;
    }
    public void city26()
    {
        leftcities[leftcitycounter] = 26;
        leftcitycounter++;
    }
    public void city27()
    {
        leftcities[leftcitycounter] = 27;
        leftcitycounter++;
    }
    public void city28()
    {
        leftcities[leftcitycounter] = 28;
        leftcitycounter++;
    }
    public void city29()
    {
        leftcities[leftcitycounter] = 29;
        leftcitycounter++;
    }
    public void city31()
    {
        leftcities[leftcitycounter] = 31;
        leftcitycounter++;
    }
    public void city32()
    {
        leftcities[leftcitycounter] = 32;
        leftcitycounter++;
    }
    public void city34()
    {
        leftcities[leftcitycounter] = 34;
        leftcitycounter++;
    }
    public void city35()
    {
        leftcities[leftcitycounter] = 35;
        leftcitycounter++;
    }
    public void city37()
    {
        leftcities[leftcitycounter] = 37;
        leftcitycounter++;
    }
    public void city39()
    {
        leftcities[leftcitycounter] = 39;
        leftcitycounter++;
    }



}
