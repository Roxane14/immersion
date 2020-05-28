using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ouverture_placard : MonoBehaviour
{

    public GameObject objet;

    public int ouvert = 0;

    public void SetOuvert(int o){
        this.ouvert = o;
        /*Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.green;
            this.GetComponent<Renderer>().material = x2;*/
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ouvert==1){
            objet.transform.Translate(-0.3f,0,0, Space.World);
            ouvert--;

        }
        
    }

}
