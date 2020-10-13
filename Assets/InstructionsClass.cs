using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstructionsClass : MonoBehaviour
{
    // Start is called before the first frame update
    Canvas CanvasInstructions, CanvasTargets, CanvasWin, CanvasSceneClear;
    static bool InstructionsShowing;
    Scene currentScene;

    void Start()
    {
        CanvasInstructions = GameObject.Find("CanvasInstructions").GetComponent<Canvas>();
        CanvasTargets = GameObject.Find("CanvasTargets").GetComponent<Canvas>();
        CanvasWin = GameObject.Find("CanvasWin").GetComponent<Canvas>();
        CanvasSceneClear = GameObject.Find("CanvasSceneClear").GetComponent<Canvas>();
        CanvasInstructions.enabled = false;
        CanvasWin.enabled = false;
        CanvasSceneClear.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        //Get current scene
        currentScene = SceneManager.GetActiveScene();

        if(EnemyExplode.targetRemain == 0)
        {
            CanvasWin.enabled = true;
            CanvasInstructions.enabled = false;
            CanvasTargets.enabled = false;

        }
        //Instructions
        else if(Input.GetKeyDown(KeyCode.H)) {
            if(InstructionsShowing)
            {
                InstructionsShowing = false;
                CanvasInstructions.enabled = false;
                CanvasTargets.enabled = true;

            } else {
                InstructionsShowing = true;
                CanvasInstructions.enabled = true;
                CanvasTargets.enabled = false;
            }
        }

        //Display scene clear
        if (EnemyExplode.targetRemain == 10 && currentScene.name == "Scene")
        {
            CanvasSceneClear.enabled = true;
        } else
        {
            CanvasSceneClear.enabled = false;
        } 
    }
}
