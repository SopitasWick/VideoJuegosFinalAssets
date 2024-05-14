using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        txtScore.GetComponent<Text>().text = "Puntuación: "+score;
    }
}
