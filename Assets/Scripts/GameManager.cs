using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    // Création d'un tableau UNIQUE d'ennemis...
    public static Ennemy[] _enemies =
    {
        new Ennemy("Sheeple", 5, 2),
        new Ennemy("SheeplePlusPlus", 8, 5)
    };

    // Création d'un tableau UNIQUE de loot...
    public static Loot[] _loots =
    {
        new Loot("Xanax", Use.Rage, -2),
        new Loot("Schopenhauer's book", Use.Sanity, 3)
    };

    //public static EnnemyStats[] _enemyTabSO = new EnnemyStats[5];

    public static Ennemy RandomEnemy()
    {
        return _enemies[Random.Range(0, _enemies.Length)];
    }

    public static Loot RandomLoot()
    {
        return _loots[Random.Range(0, _loots.Length)];
    }
}
