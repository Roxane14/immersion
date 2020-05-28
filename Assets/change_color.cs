using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    public Color macouleur;
    // Start is called before the first frame update
    void Start()
    {
        Material x = new Material(Shader.Find("Transparent/Diffuse"));
        x.color = Color.gray;
        this.GetComponent<Renderer>().material = x;
    }

    public void Change()
    {
        Material x = new Material(Shader.Find("Transparent/Diffuse"));
        x.color = macouleur;
        this.GetComponent<Renderer>().material = x;
    }
}
