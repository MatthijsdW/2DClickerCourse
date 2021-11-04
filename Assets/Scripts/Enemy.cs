using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int currentHp;
    public int maxHp;
    public int goldToGive;
    public Image healthBarFill;
    public Animation anim;

    public void Damage()
    {
        currentHp--;

        healthBarFill.fillAmount = (float)currentHp / maxHp;

        anim.Stop();
        anim.Play();

        if (currentHp <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
