using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WorldObject
{
    public WorldObject() { }
    public WorldObject(string name, double mass)
    {
        Name = name;
        Mass = mass;
    }
    public string Name { get; set; }
    public bool LockValues { get; set; } = false;
    public double Mass { get; set; }
    private double _volume = 0;
    private double _density = 0;
    public double Volume
    {
        get => _volume;
        set {
            _volume = value;
            if (!LockValues)
            {
                LockValues = true;
                Density = Mass / value;
                LockValues = false;
            }
        }
    }
    public double Density
    {
        get => _density;
        set
        {
            _density = value;
            if (!LockValues)
            {
                LockValues = true;
                Volume = Mass / value;
                LockValues = false;
            }
        }
    }
}
