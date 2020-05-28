using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
     void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenDoor");
    }
    private void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
