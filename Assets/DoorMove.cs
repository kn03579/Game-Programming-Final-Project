using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{

    GameObject MoveDoor;
    public float doorHight;

    // Start is called before the first frame update
    void Start()
    {
        MoveDoor = GameObject.Find("MovingWall");
    }

    // Update is called once per frame
    void Update()
    {
        doorHight = MoveDoor.transform.position.y;

        //If all targets are destoryed and door is not at max hight
        if (doorHight < 300 && EnemyExplode.targetRemain <= 10)
        {
            float y = MoveDoor.transform.position.y + 5f * Time.deltaTime;
            Vector3 newPos = new Vector3(MoveDoor.transform.position.x, y, MoveDoor.transform.position.z);
            MoveDoor.transform.position = newPos;
        }
    }
}
