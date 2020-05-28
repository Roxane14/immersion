using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class bouton_tournette : MonoBehaviour
{
    public GameObject cubeTest;
    public GameObject cube2;
    public GameObject objet;



    public int statut = 0;

    public void SetStatut(int s){
        this.statut=s;
    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(statut ==0 ){
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.white;
            cubeTest.GetComponent<Renderer>().material = x2;
        }
        else{
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.red;
            cubeTest.GetComponent<Renderer>().material = x2;
        }
    }

    void OnCollisionEnter (Collision col){

       if(col.gameObject.tag == "tag_mains"){
           if(statut==0){
                statut ++;
                
                cube2.GetComponent<bouton_tournette_ferm>().SetStatut(statut);

                objet.transform.Translate(-0.3f,0,0, Space.World);

                


                
           }
            

        }
        
    }



}



