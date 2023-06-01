using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float countdown = 100f;  
    TextMeshProUGUI countdownText;  

    void Start()
    {
        countdownText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            Debug.Log("I—¹");
        }

        countdownText.text = countdown.ToString("F1");
    }
}
