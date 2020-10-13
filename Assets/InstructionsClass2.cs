using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionsClass2 : MonoBehaviour
{
    // Start is called before the first frame update
    Canvas CanvasInstructions, CanvasTargets, CanvasWin;
    static bool InstructionsShowing;
    GameObject finalTimeText;

    void Start()
    {
        CanvasInstructions = GameObject.Find("CanvasInstructions").GetComponent<Canvas>();
        CanvasTargets = GameObject.Find("CanvasTargets").GetComponent<Canvas>();
        CanvasWin = GameObject.Find("CanvasWin").GetComponent<Canvas>();
        CanvasInstructions.enabled = false;
        CanvasWin.enabled = false;
        finalTimeText = GameObject.Find("FinalTimeText");

    }

    // Update is called once per frame
    void Update()
    {
        //If all enemies are defeated
        if (EnemyExplode.targetRemain == 0)
        {
            CanvasWin.enabled = true;
            CanvasInstructions.enabled = false;
            CanvasTargets.enabled = false;

            //Display finalm time
            finalTimeText.GetComponent<Text>().text = "Final Stage Time: " + (int)Timer.time;


        }
        //Instructions
        else if (Input.GetKeyDown(KeyCode.H))
        {
            if (InstructionsShowing)
            {
                InstructionsShowing = false;
                CanvasInstructions.enabled = false;
                CanvasTargets.enabled = true;

            }
            else
            {
                InstructionsShowing = true;
                CanvasInstructions.enabled = true;
                CanvasTargets.enabled = false;
            }
        }
    }
}
