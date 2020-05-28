using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{

    //public Animator anim;
    public Animation myanim;
    public GameObject objet;
    // Start is called before the first frame update
    void Start()
    {
        /*Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.red;
            objet.GetComponent<Renderer>().material = x2;*/
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
  

        void OnCollisionEnter (Collision col){
        Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
        if(col.gameObject.tag == "tag_resine"){
            x2.color = Color.red;
            objet.GetComponent<Renderer>().material = x2;
            //anim.Play("clip_tournette_ouvrir", -1, 0f);
            myanim.Play();
        }
    }
}
