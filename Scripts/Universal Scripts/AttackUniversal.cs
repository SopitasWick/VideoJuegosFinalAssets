using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackUniversal : MonoBehaviour
{

    public LayerMask collisionLayer;
    public float radius = 1f;
    public float damage = 2f;

    public bool is_Player, is_Enemy;
    
    public GameObject hit_FX_Prefab;

    // Update is called once per frame
    void Update()
    {
        DetectCollision();
    }

    void DetectCollision() {
        Collider[] Hit = Physics.OverlapSphere(transform.position, radius, collisionLayer);

        if(Hit.Length > 0) {
            if(is_Player) {
                Vector3 hitFX_Pos = Hit[0].transform.position;
                hitFX_Pos.y += 1.3f;

                if(Hit[0].transform.forward.x > 0) {
                    hitFX_Pos.x += 0.3f;
                } else if (Hit[0].transform.forward.x < 0) {
                    hitFX_Pos.x += 0.3f;
                }

                Instantiate(hit_FX_Prefab, hitFX_Pos, Quaternion.identity);

                if (gameObject.CompareTag(Tags.LEFT_ARM_TAG) ||
                gameObject.CompareTag(Tags.LEFT_LEG_TAG)) {
                 Hit[0].GetComponent<HelathScript>().ApplyDamage(damage,true);
                    
                } else {
                    Hit[0].GetComponent<HelathScript>().ApplyDamage(damage,false);

                }

            }//is player
            if(is_Enemy) {
                Hit[0].GetComponent<HelathScript>().ApplyDamage(damage,false);
            }

            gameObject.SetActive(false);
        }
    }

}
