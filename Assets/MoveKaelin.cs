using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKaelin : MonoBehaviour
{
    Animator anim;
    GameObject BigExplosionEffect;
    public GameObject firstPersonView, thirdPersonView;
    public GameObject gunFP, gunTP;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        BigExplosionEffect = GameObject.Find("BigExplosionEffect");
        gunFP = GameObject.Find("Gun(FP)");
        gunFP.gameObject.SetActive(false);
        gunTP = GameObject.Find("Gun(TP)");
    }

    // Update is called once per frame
    void Update()
    {
        //Jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("jump", true);
        }
        else
        {
            anim.SetBool("jump", false);
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        anim.SetFloat("LeftRight", h);
        anim.SetFloat("ForwBack", v);

        //Change between
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (firstPersonView.GetComponent<Camera>().enabled)
            {
                firstPersonView.GetComponent<Camera>().enabled = false;
                thirdPersonView.GetComponent<Camera>().enabled = true;
                gunTP.gameObject.SetActive(true);
                gunFP.gameObject.SetActive(false);
            }
            else
            {
                firstPersonView.GetComponent<Camera>().enabled = true;
                thirdPersonView.GetComponent<Camera>().enabled = false;
                gunTP.gameObject.SetActive(false);
                gunFP.gameObject.SetActive(true);
            }
        }
    }
}
