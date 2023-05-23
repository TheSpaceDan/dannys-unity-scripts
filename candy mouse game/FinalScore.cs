using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text finalScore;

    // Update is called once per frame
    void Update()
    {
        finalScore.text = "Score: " + GameManager.score.ToString();
    }
}
