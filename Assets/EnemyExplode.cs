using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyExplode : MonoBehaviour
{
    public static int targetRemain = 20;
    Text targetsTextComponent;
    BoxCollider coll;

    // Start is called before the first frame update
    void Start()
    {
        targetsTextComponent = GameObject.Find("TargetsText").GetComponent<Text>();
        coll = gameObject.GetComponent<BoxCollider>();
        targetsTextComponent.text = "Remaining Targets\n" + targetRemain;
    }

    private void OnCollisionEnter(Collision c)
    {
        //Only destroy on contact with bullet
        if (c.gameObject.tag != "Bullet") return;

        targetRemain--;

        //Update targets remain
        targetsTextComponent.text = "Remaining Targets\n" + targetRemain;

        coll.enabled = false;

        Destroy(gameObject);

    }
}
