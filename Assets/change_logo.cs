using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change_logo : MonoBehaviour
{
    public GameObject voyant1;
    public GameObject voyant2;
    public GameObject voyant3;
    public GameObject voyant4;

    public Material m1;
    public Material m2;
    public Material m3;
    public Material m4;

    public int inTouch = 0;

    public int numLogo=1;

    public int GetNumLogo(){
        return numLogo;

    }

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
        x2.color = Color.grey;

        voyant1.GetComponent<Renderer>().material = m1;
        voyant2.GetComponent<Renderer>().material = m2;
        voyant3.GetComponent<Renderer>().material = m3;
        voyant4.GetComponent<Renderer>().material = m4;

        if (numLogo == 1){
            voyant1.GetComponent<Renderer>().material = x2;
        }
        else if (numLogo == 2){
            voyant2.GetComponent<Renderer>().material = x2;
        }
        else if (numLogo == 3){
            voyant3.GetComponent<Renderer>().material = x2;
        }
        else if (numLogo == 4){
            voyant4.GetComponent<Renderer>().material = x2;
        }
        
    }

    void OnCollisionEnter (Collision col){

       if(col.gameObject.tag == "tag_mains"){

           if(inTouch==0){
            numLogo++;
            inTouch++;

            if(numLogo==5){
                numLogo=1;
           }
          
        }
        }
        
        
    }

    void OnCollisionExit (Collision col){
        if(col.gameObject.tag == "tag_mains"){
            if(inTouch==1){
                inTouch--;

            }
        
        }
    }


    
}
