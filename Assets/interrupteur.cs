using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class interrupteur : MonoBehaviour
{
    PostProcessVolume m_Volume;
    ColorGrading m_Color;
    Color couleurFiltre = Color.blue;
    Color couleurFiltreBlanc = Color.white;

    int lumiere = 0;


    // Start is called before the first frame update
    void Start()
    {
            m_Color = ScriptableObject.CreateInstance<ColorGrading>();
            m_Color.enabled.Override(true);
            m_Color.colorFilter.Override(couleurFiltre);
            m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Color);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col){

       if(col.gameObject.tag == "tag_mains"){

           if (lumiere == 0){
               m_Color.colorFilter.Override(couleurFiltreBlanc);
               lumiere++;

           }

           else if (lumiere == 1){
               m_Color.colorFilter.Override(couleurFiltre);
               lumiere--;
           }
            


        }
        
    }



}
