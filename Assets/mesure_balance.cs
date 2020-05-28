using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mesure_balance : MonoBehaviour
{
    public GameObject t10;
    public Text txt;
    int total=0;
    // Start is called before the first frame update
    void Start()
    {
        t10.SetActive(true);
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "tag_resine"){
          
            total=total+50; 
        }
        
         if(col.gameObject.tag == "tag_resine_2"){
         
           total=total+20;
            
        } 
         if(col.gameObject.tag == "tag_resine_3"){
           
            total=total+10;
        }
        


      txt.text = total.ToString()+" g.";


        
    }

    void OnCollisionExit(Collision col)
     {
           if(col.gameObject.tag == "tag_resine"){
           
            total=total-50;
        }
        
         if(col.gameObject.tag == "tag_resine_2"){
         
           total=total-20;
            
        } 
         if(col.gameObject.tag == "tag_resine_3"){
        
            total=total-10;
        }
        txt.text = total.ToString()+" g.";
        
         
     }
     
}
