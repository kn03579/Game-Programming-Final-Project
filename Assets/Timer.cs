using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time = 0;
    GameObject timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GameObject.Find("TimerText");
    }

    // Update is called once per frame
    void Update()
    {
        //Update the timer if there are still targets
        if (EnemyExplode.targetRemain != 0) {
            time += Time.deltaTime;
            timerText.GetComponent<Text>().text = "Time " + (int)time;
        }

    }
}
