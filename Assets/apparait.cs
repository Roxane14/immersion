using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apparait : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject med;
    
    public void Start(){
        med.SetActive(false);
    }

    public void Apparait(){
        med.SetActive(true);
    }
   
}
