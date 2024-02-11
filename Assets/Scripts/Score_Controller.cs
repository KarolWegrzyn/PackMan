using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Controller : MonoBehaviour
{
    public static Score_Controller instance;

    [SerializeField] private TextMeshProUGUI current_score;
    private int score;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        current_score.text = score.ToString();
    }

    public void AddScore()
    {
        score++;
        current_score.text = score.ToString();
    }
}
