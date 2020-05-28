using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject medaillon1;
    public GameObject couvercleTournette;
    public GameObject bouton;

    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;

    public Material matDepart;

    public bool filmResine = false;
    public bool motifResine = false;

    public GameObject messageFinal;


    Renderer rend;
        void Start()
    {
        /*Material x = new Material(Shader.Find("Transparent/Diffuse"));
        x.color = Color.gray;*/
        medaillon1.GetComponent<Renderer>().material = matDepart;
        messageFinal.SetActive(false);
      
    }

    void OnCollisionEnter (Collision col){
        Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
        x2.color = Color.red;

        if(col.gameObject.tag == "tag_tournette"){
            float xObj  = couvercleTournette.transform.position.x;
            if (col.gameObject.GetComponent<Renderer>().material.color==x2.color){
                medaillon1.GetComponent<Renderer>().material = x2;
                filmResine=true;
            }
           
        }
        //

        else if(col.gameObject.tag == "tag_aligneur"&&filmResine==true){
            
            int numLogo = bouton.GetComponent<change_logo>().GetNumLogo();
           // messageFinal.SetActive(true);

            switch (numLogo)
            {
                case 1 :
                    medaillon1.GetComponent<Renderer>().material = mat1;
                    break;
                case 2 :
                    medaillon1.GetComponent<Renderer>().material = mat2;
                    break;
                case 3 :
                    medaillon1.GetComponent<Renderer>().material = mat3;
                    messageFinal.SetActive(true);

                    break;
                case 4 :
                    medaillon1.GetComponent<Renderer>().material = mat4;
                    break;
                default : 
                    break;

            }
            filmResine=false;
            motifResine=true;


            
        }
        
    }
}
