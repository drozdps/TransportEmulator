﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Vehicle
{
    private int _maxDistance;
    public int maxDistance {
        get { return _maxDistance; }
        set { _maxDistance = value; }
    }
    private int _driverAge;
    public int driverAge
    {
        get { return _driverAge; }
        set {_driverAge=value; }
    }

    private int curSpeed
    {
        get;
        set;
    }

    private int _maxSpeed;
    public int maxSpeed
	{
		get{return _maxSpeed;}
		set { _maxSpeed = value; }
	}

    private int _weight;
    public int weight
    {
		get {return _weight; }
		set { _weight = value; }
	}
    private String _name;
    public String name
    {
        get { return _name; }
        set { _name = value; }
    }

    public virtual String info()
	{
        return ">" + _name + "," + _weight + "kg," + _maxSpeed + "kph,";
	}

	public virtual void setSpeed(object Integer)
	{
		throw new System.NotImplementedException();
	}

	public Vehicle()
	{
	}

}
