using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public Transform player;
    public GameObject cetObjet;
    public float speed;
    FixedJoint joint;

    public GameObject porte;

    int Touche;
    
    // Start is called before the first frame update
    void Start()
    {
        Touche = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if(Touche == 0){
            if (Vector3.Distance(transform.position, player.position) < 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }

            if (Vector3.Distance(transform.position, player.position) < 0.05f)
            {
                cetObjet.GetComponent<Rigidbody>().useGravity = false;
                speed = 10;
            }

            if (Vector3.Distance(transform.position, player.position) > 0.05f)
            {
                cetObjet.GetComponent<Rigidbody>().useGravity = true;
                speed = 3;
            }

            if (Vector3.Distance(transform.position, player.position) > 0.1f)
            {
                cetObjet.GetComponent<Rigidbody>().useGravity = true;
                speed = 0;
            }
            
        }

        if(Touche == 1){

            Material x2 = new Material(Shader.Find("Transparent/Diffuse"));
            x2.color = Color.green;
            this.GetComponent<Renderer>().material = x2;

        }

        
    }

    void OnCollisionEnter(Collision col) {

        

        if(col.gameObject.tag == "tag_aimant"){

            joint = gameObject.AddComponent<FixedJoint>();
            joint.connectedBody = col.gameObject.GetComponent<Rigidbody>();

            Touche = 1;
            speed = 0;

            if(porte.tag == "Porte"){
                porte.GetComponent<Door_carte>().SetOuvert(Touche);
            }

            if(porte.tag == "Placard"){
                porte.GetComponent<Ouverture_placard>().SetOuvert(Touche);
            }

        }
       
    }




}
