using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton_tournette_ferm : MonoBehaviour
{
    public GameObject cubeTest;
    public GameObject cube1;
    public GameObject objet;
    public int statut = 0;

    public void SetStatut(int s){
        this.statut=s;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(statut ==1 ){
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.white;
            cubeTest.GetComponent<Renderer>().material = x2;
        }
        else{
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.green;
            cubeTest.GetComponent<Renderer>().material = x2;
        }
        
    }

    void OnCollisionEnter (Collision col){

       if(col.gameObject.tag == "tag_mains"){
           if(statut==1){
                statut--;
                
                cube1.GetComponent<bouton_tournette>().SetStatut(statut);
                
                objet.transform.Translate(0.3f,0,0, Space.World);
                
           }
            

        }
        
    }



}
