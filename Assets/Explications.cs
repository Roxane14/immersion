using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explications : MonoBehaviour
{

    public GameObject description;
     public GameObject compris;

    public void Start(){
        description.SetActive(false);
        compris.SetActive(false);
    }
    public void explique()
    {
        description.SetActive(true);
        compris.SetActive(true);
    }

    public void ok()
    {
        compris.SetActive(false);
        description.SetActive(false);
    }
}
