using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para gestionar las escenas
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateScore(int change) {
        score += change;
        GameObject txtScore = GameObject.Find("txtScore");
        txtScore.GetComponent<Text>().text = "Puntos: " + score;

        // Comprobar si el puntaje ha llegado a 10
        if (score >= 5)
        {
            CambiarEscena();
        }
    }

    static void CambiarEscena()
    {
        // Cambiar a la escena "Escenario2"
        SceneManager.LoadScene("Escenario2");
    }
}
