using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfiloAnim : MonoBehaviour
{
    public static bool x;
    Animator anim;
    void Start()
    {
        anim=GetComponent<Animator>();
        x=false;
    }
    public bool getX(){
        return x;
    }
    public static void setX(bool a){
        x=a;
    }

    // Update is called once per frame
    void Update()
    {
        if(x)
		{
			anim.SetTrigger("profilo");
		}
    }
}
