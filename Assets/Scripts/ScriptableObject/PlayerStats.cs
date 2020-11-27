using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "New Character/Ennemy")]
public class PlayerStats : ScriptableObject
{
    public enum Use { Rage, Sanity, XP };

    public struct Loot
    {
        public string _nameSO;
        public Use _useSO;
        public int _intensitySO;

        public Loot(string name, Use use, int intensity)
        {
            _nameSO = name;
            _useSO = use;
            _intensitySO = intensity;
        }
    }
}
