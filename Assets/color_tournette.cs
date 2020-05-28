using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_tournette : MonoBehaviour
{
    public GameObject plateau;
    public int resine = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col){
        Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
        if(col.gameObject.tag == "tag_resine"){
            x2.color = Color.red;
            plateau.GetComponent<Renderer>().material = x2;
            resine = 1;
        }
    }
}
