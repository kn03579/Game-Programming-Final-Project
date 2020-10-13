using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    GameObject MagicCylinder;
    GameObject MagicCylinder2;

    // Start is called before the first frame update
    void Start()
    {
        MagicCylinder = GameObject.Find("MagicCylinder");
        MagicCylinder2 = GameObject.Find("MagicCylinder2");
    }

    //Pick up magic cylinder
    void OnCollisionEnter(Collision c)
    {
        if(c.transform.gameObject.tag == "MagicCylinder")
        {
            Destroy(MagicCylinder2);
            MagicCylinder.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
