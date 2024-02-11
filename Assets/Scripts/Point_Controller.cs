using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Point_Controller : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Score_Controller.instance.AddScore();
    }
    
}
