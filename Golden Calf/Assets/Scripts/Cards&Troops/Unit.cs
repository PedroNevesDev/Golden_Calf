using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Data", menuName = "Units/NewUnit", order = 1)]
public class Unit : ScriptableObject
{
    [Header("Description")]
    [SerializeField] string uName;
    [SerializeField] Sprite cardSprite;
    [SerializeField] Mesh cardModel;

    [Header("Stats")]
    [SerializeField] int health = 1;
    [SerializeField] int defense = 0;
    [SerializeField] int attack = 0;
    [SerializeField] int movement = 1;

    [Header("Upgrades/Evolution")]
    [SerializeField] int upgradesCost = 1;
    [SerializeField] int upgradesIncrementionCost = 1;
    [SerializeField] int evolutionUpgradesNeeded = 5;
    [SerializeField] int evolutionNum = 0;

    [Header("Active")]
    [SerializeField] bool hasActive = false;
    [SerializeField] int activeNum;

    [Header("Passive")]
    [SerializeField] bool hasPassive = false;
    [SerializeField] int passiveNum;

}
