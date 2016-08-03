// File: tv.cs

class Television
{
    private int channel = 0;
    private int volume = 0;
    private bool isOn = false;

    //property for IsOn
    public bool IsOn
    {
        get
        {
            return isOn;
        }
        set
        {
            isOn = value;
        }

    }

    //property for Channel
    public int Channel
    {
        get
        {
            return channel;
        }
        set
        {
            channel = value;
        }

    }

    //property for Volume
    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            volume = value;
        }

    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        if (!tv.IsOn)//getting
        {
            tv.IsOn = true; // setting
        }

        tv.Channel = 3; //setting

        tv.Volume++; //gets and sets it
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.IsOn = false; //setting
    }
}