using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changement_couleur_script : MonoBehaviour
{
    //ma_couleur_verte est un élément de type Material, qui devra être 
    //passé en paramètre de notre cube
    public Material ma_couleur_verte;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnCollisionEnter est une fonction qui se déclenchera automatiquement 
    //si notre objet en touche un autre
    void OnCollisionEnter(Collision col){
        //le if permet de vérifier que l'objet touché a bien pour tag "cube"
        if(col.gameObject.tag=="cube"){
            //si c'est bien le cas, notre objet doit donc prendre le 
            //nouveau matériau que l'on a entré en paramètre
            this.GetComponent<Renderer>().material = ma_couleur_verte;
        }

    }
}
