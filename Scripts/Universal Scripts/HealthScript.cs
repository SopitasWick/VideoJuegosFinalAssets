using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelathScript : MonoBehaviour
{
    public float health = 100f;
    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;
    public bool KnockDown;
    private bool characterDied;
    public bool is_Player;
    private HealthUI health_UI;

    void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();
        if (is_Player)
        {
            health_UI = GetComponentInChildren<HealthUI>(); // Cambiado a GetComponentInChildren
        }
    }

    public void ApplyDamage(float damage, bool KnockDown)
    {
        if (characterDied)
            return ;

        health -= damage;
        
        if (health_UI != null) // Chequeo si health_UI no es nulo
        {
            health_UI.DisplayHealth(health);
        }

        if (health <= 0f)
        {
            animationScript.Death();
            characterDied = true;
            if (is_Player)
            {
                GameObject.FindGameObjectWithTag(Tags.ENEMY_TAG).GetComponent<EnemyMovement>().enabled = false; // Corregido Tags.ENEMY_TAG
            }
            return;
        }

        if (!is_Player)
        {
            if (KnockDown)
            {
                if (Random.Range(0, 2) > 0)
                {
                    animationScript.KnockDown();
                }
            }
            else
            {
                if (Random.Range(0, 3) > 1)
                {
                    animationScript.Hit();
                }
            }
        }
    }
}

