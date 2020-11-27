using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Ennemy
{
    public string _name;
    public int _rage;
    public int _verve;

    // Constructeur
    public Ennemy(string name, int rage, int verve)
    {
        _name = name;
        _rage = rage;
        _verve = verve;
    }
}

public enum Use { Rage, Sanity, XP};

public struct Loot
{
    public string _name;
    public Use _use;
    public int _intensity;

    // Constructeur
    public Loot(string name, Use use, int intensity)
    {
        _name = name;
        _use = use;
        _intensity = intensity;
    }
}
