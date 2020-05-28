using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{

    public GameObject panel;
    public GameObject text;
    // Start is called before the first frame update

    IEnumerator Start(){
        panel.SetActive(false);
        text.SetActive(false);
        yield return new WaitForSeconds(480);

        panel.SetActive(true);
        text.SetActive(true);

    }
 

    // Update is called once per frame
    void Update()
    {
        
    }

    

}
