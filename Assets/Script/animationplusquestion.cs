using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationplusquestion : MonoBehaviour
{

    public GameObject description;
      Animator anim;
    
     public GameObject compris;

    public void Start(){
        anim=GetComponent<Animator>();
        description.SetActive(false);
        compris.SetActive(false);
       
    }
    public void explique()
    {
        description.SetActive(true);
        compris.SetActive(true);
        ProfiloAnim.setX(true);
        print("aaaaaaa");
        print(anim);
    }

    public void ok()
    {
        compris.SetActive(false);
        description.SetActive(false);
    }
   
}
