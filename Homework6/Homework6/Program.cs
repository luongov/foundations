// File: tv.cs
using System;

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    public bool IsOn
    {
        get
        {
            return isOn;
        }
        set
        {
            if (value == true)
                return;

            isOn = value;
        }
    }

    public int Channel
    {

        get
            {
            return channel;
            }
        set
           {
            if (value < 0 || value > 50)
                return;

            channel = value;
           }
    }

    public int Volume()
    {
        get
            {
            return volume;
        }
        set
           {
            if (value < 0 || value > 100)
                return;

            channel = value;
        }
    }

}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn) //getting
        {
            tv.IsOn = true;  //setting
        }



        tv.Channel = 3; //setting

        tv.Volume++; //getting and setting
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.IsOn = false; //setting
    }
}