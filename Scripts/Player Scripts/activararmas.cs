using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activararmas : MonoBehaviour
{
    public TomarArmas tomarArmas;
    public int numeroArma;

    // Start is called before the first frame update
    void Start()
    {
tomarArmas=GameObject.FindGameObjectWithTag("Player").GetComponent<TomarArmas>();
    }

   public void OnTriggerEnter(Collider other)
{
if(other.tag=="Player"){
    tomarArmas.ActivarArmas(numeroArma);
    Destroy(gameObject);
}
}
}
