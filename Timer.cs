using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;

    void Update()
    {
        seconds -= Time.deltaTime;

        if (seconds <= 0)
        {
            if (minutes <= 0)
            {
                seconds += 59;
                minutes -= 1;
            }
            else
            {
                int sceneindex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneindex);
            }
        }
    }
}
