using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
//using System.Threading.Tasks;


public class effet_ivre : MonoBehaviour
{
    PostProcessVolume m_Volume;
    Vignette m_Vignette;
    Bloom m_Bloom;
    ColorGrading m_Color;
    Color couleurFiltre = Color.green;
    Color filtreBlanc = Color.white;

    int declenche;
    
    void Start()
    {
        declenche = 0;

        m_Vignette = ScriptableObject.CreateInstance<Vignette>();
        m_Bloom = ScriptableObject.CreateInstance<Bloom>();
        m_Color = ScriptableObject.CreateInstance<ColorGrading>();

        m_Vignette.enabled.Override(true);
        m_Bloom.enabled.Override(true);
        m_Color.enabled.Override(true);

        //m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Vignette);
        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Bloom);
        m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Color);


    }

    // Update is called once per frame
    void Update()
    {
        if(declenche == 1){

            //m_Vignette.intensity.Override(1f);
            m_Bloom.intensity.Override(200f);
            m_Bloom.diffusion.Override(7f);
            m_Color.colorFilter.Override(couleurFiltre);
            m_Bloom.intensity.value = 50+50*(Mathf.Sin(Time.realtimeSinceStartup));
        }

        else if(declenche == -1){
            m_Bloom.intensity.Override(0f);
            m_Bloom.diffusion.Override(0f);
            m_Color.colorFilter.Override(filtreBlanc);
        }
        
    }


    IEnumerator OnCollisionEnter (Collision col){

        if((col.gameObject.tag == "tag_resine")||(col.gameObject.tag == "tag_resine_2")||(col.gameObject.tag == "tag_resine_3")){

            declenche = 1;

            yield return new WaitForSeconds(15);

            declenche = -1;

    }

    }


}
