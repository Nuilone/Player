using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TMPro.TextMeshProUGUI timer;
    public GameObject text;

    void Update()
    {
        timer.text = timer.text + minutes + ":" + System.MathF.Round(seconds,2);
        seconds -= Time.deltaTime;

        if (seconds < 0)
        {
            if (minutes < 0)
            {
                seconds = 59;
                minutes -= 1;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        float roundSeconds = Mathf.RoundToInt(seconds);
    }
}
