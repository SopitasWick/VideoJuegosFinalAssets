using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public GameObject winPanel; // Asigna el objeto 'YouWinPanel' desde el editor

    void Start()
    {
        GameObject txtScore = GameObject.Find("txtScore");
        if (txtScore != null)
        {
            txtScore.GetComponent<Text>().text = "Puntos: " + score;
        }
    }

    void Update()
    {
        
    }

    public static void UpdateScore(int change)
    {
        score += change;
        GameObject txtScore = GameObject.Find("txtScore");
        if (txtScore != null)
        {
            txtScore.GetComponent<Text>().text = "Puntos: " + score;
        }

        if (score >= 11)
        {
            CambiarEscena();
        }
    }

    static void CambiarEscena()
    {
        SceneManager.LoadScene("Youwin"); // Cambia a la escena 'YouWin'
     
    }

    public void SalirAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}


