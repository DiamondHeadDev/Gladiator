using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Android : MonoBehaviour
{
    private string androidName;
    private int id;
    private int maxHP;
    private int currentHP;

    public Android() { }

    public Android(string androidName, int id, int maxHP, int currentHP)
    {
        this.androidName = androidName;
        this.id = id;
        this.maxHP = maxHP;
        this.currentHP = currentHP;
    }

    public bool TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }

    public string getName()
    {
        return androidName;
    }

    public void setName(string name)
    {
        androidName = name;
    }

    public int getCurrentHP()
    {
        return currentHP;
    }

    public void setCurrentHP(int hp)
    {
        currentHP = hp;
    }

    public int getMaxHP()
    {
        return maxHP;
    }

    public void setMaxHP(int hp)
    {
        maxHP = hp;
    }

    public void resetHP(int hp)
    {
        maxHP = hp;
        currentHP = maxHP;
    }
}
