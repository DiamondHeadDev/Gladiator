using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSelector : MonoBehaviour
{
    public BattleSystem battleSystem;

    public void OnSelectWeapon()
    {
        StartCoroutine(battleSystem.EnemyTurn());
    }
}
