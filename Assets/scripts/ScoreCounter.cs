using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] private int mult = 1;
    [SerializeField] private float time = 0;
    [SerializeField] private int points = 0;

    public TMP_Text scoreText;

    private void Update()
    {
        time += Time.deltaTime;
        points = PlayerPrefs.GetInt("points",0);

        score = (Mathf.FloorToInt(time) + points) * mult;

        scoreText.text = "Score: " + score.ToString();
    }


}
