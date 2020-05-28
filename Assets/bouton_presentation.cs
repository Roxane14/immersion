using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class bouton_presentation : MonoBehaviour
{
    public GameObject ceCube;
    public GameObject robot;


    public int statut = 0;

    public GameObject texte_1;
    public GameObject texte_2;
    public GameObject texte_3;
    public GameObject texte_4;
    public GameObject texte_5;


    void Start()
    {
        robot.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(statut ==0 ){
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.red;
            ceCube.GetComponent<Renderer>().material = x2;
        }
        else if(statut ==1){
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.magenta;
            ceCube.GetComponent<Renderer>().material = x2;
        }
        else if(statut ==2){
            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.white;
            ceCube.GetComponent<Renderer>().material = x2;
        }
        else{
            statut = 0;
        }
    }

    IEnumerator OnCollisionEnter (Collision col){

       if(col.gameObject.tag == "tag_mains"){

           if(statut==0){
                statut ++;
                yield return new WaitForSeconds(1);
                statut ++;
                robot.SetActive(true);
                texte_1.SetActive(false);
                texte_2.SetActive(false);
                texte_3.SetActive(false);
                texte_4.SetActive(false);
                texte_5.SetActive(true);
           }

           else if(statut==2){
                statut --;
                yield return new WaitForSeconds(1);
                statut --;
                robot.SetActive(false);
           }
           /*else{
               statut = 0;
           }*/
            

        }
        
    }



}