using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_carte : MonoBehaviour
{
    private Animator anim;
    public GameObject magnet;
    public int ouvert = 0;

    public void SetOuvert (int o){
        this.ouvert = o;
    }


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    /* void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenDoor");
    }
    private void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }*/
    
    // Update is called once per frame
    void Update()
    {
        if(ouvert == 1)
       {
           anim.SetTrigger("OpenDoor");
           anim.enabled = true;

       } 
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
