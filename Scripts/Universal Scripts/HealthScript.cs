using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelathScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float health=100f;
    private CharacterAnimation animationScript;
    private EnemyMovement enemyMovement;
   public bool KnockDown;
private bool characterDied;
    public bool is_Player;

    void Awake()
    {
        animationScript = GetComponentInChildren<CharacterAnimation>();
    }
    public void ApplyDamage(float damage,bool KnockDown){
         if(characterDied)
        return;
    health -= damage;
    //display damage UI

    if(health < 0f){
        animationScript.Death();
        characterDied =true;
        if(is_Player){
            //IF IS PLAYER DEACTIVATE ENEMY SCRIPT
          
        }
        return;
    }
    if(!is_Player){
if(KnockDown){
if(Random.Range(0,2)>0){
    animationScript.KnockDown();
}
}else{
    if(Random.Range(0,3)>1){
        animationScript.Hit();
    }
}
    }//if is a player

    }//apply damage
    

  
}
//class
