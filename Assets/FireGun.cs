using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject Bullet, BulletStartFP, BulletStartTP;
    public GameObject firstPersonView, thirdPersonView;
    AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Bullet = GameObject.Find("Bullet");
        BulletStartFP = GameObject.Find("BulletStartFP");
        BulletStartTP = GameObject.Find("BulletStartTP");
        firstPersonView = GameObject.Find("FirstPersonCamera");
        thirdPersonView = GameObject.Find("ThirdPersonCamera");
        aud = GetComponent<AudioSource>();
        aud.volume = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Fire gun from appropriate gun
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(firstPersonView.GetComponent<Camera>().enabled)
            {
                fireGun(BulletStartFP);
            } else
            {
                fireGun(BulletStartTP);
            }
        }
    }

    //Fire gun method
    public void fireGun(GameObject start)
    {
        GameObject newBullet = Instantiate(Bullet, start.transform.position, Quaternion.identity);
        Rigidbody rb = newBullet.AddComponent<Rigidbody>();
        rb.AddForce(start.transform.forward * 50000);
        aud.volume = 0.1f;
        aud.Play();
        Destroy(newBullet, 2f);
    }
}
