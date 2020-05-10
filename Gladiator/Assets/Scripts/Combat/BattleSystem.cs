using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject leftPanel;
    public GameObject rightPanel;
    public Text eventText;
    private SceneNav sceneNav;
    Android playerAndroid;
    Android enemyAndroid;

    public BattleState state;
    // Start is called before the first frame update
    void Start()
    {
        sceneNav = new SceneNav();
        state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        playerAndroid = player.GetComponent<Android>();
        enemyAndroid = enemy.GetComponent<Android>();
        enemyAndroid.setName("Jeff");
        enemyAndroid.resetHP(10);
        playerAndroid.setName("Player");
        playerAndroid.resetHP(10);
        eventText.text = enemyAndroid.getName() + " Approaches.";

        yield return new WaitForSeconds(0f);
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator PlayerAttack()
    {
        setActivePanels(true);

        yield return new WaitForSeconds(1f);
    }

    IEnumerator EnemyAttack()
    {
        yield return new WaitForSeconds(1f);
    }

    void PlayerTurn()
    {
        
    }

    public void PanelAttack(Weapon wep)
    {
        bool isDead = enemyAndroid.TakeDamage(wep.Damage);
        print(enemyAndroid.getCurrentHP());
        state = BattleState.ENEMYTURN;
        if (isDead)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }

    }

    public IEnumerator EnemyTurn()
    {
        print(playerAndroid.getCurrentHP());
        print("Enemy Turn");
        setActivePanels(false);
        eventText.text = enemyAndroid.getName() + " strikes for 5 damage.";
        bool isDead = playerAndroid.TakeDamage(5);

        print(playerAndroid.getCurrentHP());
        yield return new WaitForSeconds(0.0f);
        print("test");
        if (isDead)
        {
            state = BattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }

    void EndBattle()
    {
        if (state == BattleState.WON)
        {
            sceneNav.loadScene("Victory");
            //dialogueText.text = "You won the battle!";
        }
        else if (state == BattleState.LOST)
        {
            sceneNav.loadScene("Defeat");
            //dialogueText.text = "You were defeated.";
        }
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
