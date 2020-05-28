using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ouverture_fermeture : MonoBehaviour
{
public GameObject objet;
int possibleOuv = 1;
int possibleFerm = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void Ouverture(){
    if(possibleOuv==1){
        objet.transform.Translate(-0.3f,0,0, Space.World);
        possibleOuv=0;
        possibleFerm=1;
    }
        
    
}

public void Fermeture(){
    if(possibleFerm==1){
        objet.transform.Translate(0.3f,0,0, Space.World);
        possibleFerm=0;
        possibleOuv=1;

    }


}

}
