using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSelector : MonoBehaviour
{
    public BattleSystem battleSystem;

    public Weapon[] options;

    void Start()
    {
        Weapon w = new Weapon();
        w.Damage = 4;
        options = new Weapon[10];
        options[0] = w;
        print(options[0].Damage);
    }

    public void OnSelectObject()
    {
        battleSystem.transferEnemy();
    }
}
