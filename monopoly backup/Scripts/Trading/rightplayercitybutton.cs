using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightplayercitybutton : MonoBehaviour
{
    public static rightplayercitybutton rightinstance;

    public int[] rightcities = new int[41];
    public int rightcitycounter = 1;

    private void Awake()
    {
        makeinstance();

    }

    void makeinstance()
    {
        if(rightinstance == null)
        {
            rightinstance = this;
        }
    }
    public void city1()
    {
        rightcities[rightcitycounter] = 1;
        rightcitycounter++;
    }
    public void city3()
    {
        rightcities[rightcitycounter] = 3;
        rightcitycounter++;
    }
    public void city5()
    {
        rightcities[rightcitycounter] = 5;
        rightcitycounter++;
    }
    public void city6()
    {
        rightcities[rightcitycounter] = 6;
        rightcitycounter++;
    }
    public void city8()
    {
        rightcities[rightcitycounter] = 8;
        rightcitycounter++;
    }
    public void city9()
    {
        rightcities[rightcitycounter] = 9;
        rightcitycounter++;
    }
    public void city11()
    {
        rightcities[rightcitycounter] = 11;
        rightcitycounter++;
    }
    public void city12()
    {
        rightcities[rightcitycounter] = 12;
        rightcitycounter++;
    }
    public void city13()
    {
        rightcities[rightcitycounter] = 13;
        rightcitycounter++;
    }
    public void city14()
    {
        rightcities[rightcitycounter] = 14;
        rightcitycounter++;
    }
    public void city15()
    {
        rightcities[rightcitycounter] = 15;
        rightcitycounter++;
    }
    public void city16()
    {
        rightcities[rightcitycounter] = 16;
        rightcitycounter++;
    }
    public void city18()
    {
        rightcities[rightcitycounter] = 18;
        rightcitycounter++;
    }
    public void city19()
    {
        rightcities[rightcitycounter] = 19;
        rightcitycounter++;
    }
    public void city21()
    {
        rightcities[rightcitycounter] = 21;
        rightcitycounter++;
    }
    public void city23()
    {
        rightcities[rightcitycounter] = 23;
        rightcitycounter++;
    }
    public void city24()
    {
        rightcities[rightcitycounter] = 24;
        rightcitycounter++;
    }
    public void city25()
    {
        rightcities[rightcitycounter] = 25;
        rightcitycounter++;
    }
    public void city26()
    {
        rightcities[rightcitycounter] = 26;
        rightcitycounter++;
    }
    public void city27()
    {
        rightcities[rightcitycounter] = 27;
        rightcitycounter++;
    }
    public void city28()
    {
        rightcities[rightcitycounter] = 28;
        rightcitycounter++;
    }
    public void city29()
    {
        rightcities[rightcitycounter] = 29;
        rightcitycounter++;
    }
    public void city31()
    {
        rightcities[rightcitycounter] = 31;
        rightcitycounter++;
    }
    public void city32()
    {
        rightcities[rightcitycounter] = 32;
        rightcitycounter++;
    }
    public void city34()
    {
        rightcities[rightcitycounter] = 34;
        rightcitycounter++;
    }
    public void city35()
    {
        rightcities[rightcitycounter] = 35;
        rightcitycounter++;
    }
    public void city37()
    {
        rightcities[rightcitycounter] = 37;
        rightcitycounter++;
    }
    public void city39()
    {
        rightcities[rightcitycounter] = 39;
        rightcitycounter++;
    }



}
