using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    float myInputValue;
    public GameObject cameraPrincipale;


    public GameObject panel;
    public GameObject text;
    // Start is called before the first frame update

    IEnumerator Start(){
        panel.SetActive(false);
        text.SetActive(false);
        yield return new WaitForSeconds(180);
        panel.SetActive(true);
        text.SetActive(true);
    }
 

    // Update is called once per frame
    void Update()
    {
        myInputValue = Input.GetAxis("Oculus_GearVR_LThumbstickX");
        //Debug.Log(myInputValue);
        if(myInputValue==0){
            cameraPrincipale.GetComponent<RealSpace3D.RealSpace3D_AudioSource>().rs3d_PlaySound();
        }

    }

    

}
