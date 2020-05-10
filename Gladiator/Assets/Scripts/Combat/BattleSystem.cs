using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyPrefab;
    public GameObject leftPanel;
    public GameObject rightPanel;

    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        yield return new WaitForSeconds(0f);
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        setActivePanels(true);

        yield return new WaitForSeconds(1f);
    }

    void PlayerTurn()
    {
        
    }

    public IEnumerator EnemyTurn()
    {
        print("hi");
        yield return new WaitForSeconds(1f);

    }

    public void OnAttackButton()
    {
        if (state != BattleState.PLAYERTURN)
        {
            return;
        }

        StartCoroutine(PlayerAttack());
    }

    public void OnDefendButton()
    {
        setActivePanels(true);
    }

    public void OnTalkButton()
    {
        setActivePanels(true);
    }

    public void OnItemButton()
    {
        setActivePanels(true);
    }

    public void setActivePanels(bool display)
    {
        leftPanel.SetActive(display);
        rightPanel.SetActive(display);
    }
}
