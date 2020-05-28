using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class presentation1 : MonoBehaviour
{

    public GameObject texte_1;
    public GameObject texte_2;
    public GameObject texte_3;
    public GameObject texte_4;
    public GameObject texte_5;
    //public GameObject texte_6;
    public GameObject bouton_suivant;
    public GameObject bouton_precedent;
    public GameObject bouton_physique;
    public int place;

    public void Start(){
        texte_1.SetActive(true);
        texte_2.SetActive(true);
        texte_3.SetActive(false);
        texte_4.SetActive(false);
        texte_5.SetActive(false);
        //texte_6.SetActive(false);
        bouton_precedent.SetActive(false);
        bouton_physique.SetActive(false);
        place = 1;
    }
    public void suivant()
    {

      switch (place)
      {
        case 1:
            texte_1.SetActive(false);
            texte_2.SetActive(false);
            texte_3.SetActive(true);
            bouton_precedent.SetActive(true);
            place++;
            break;
        case 2:
            texte_3.SetActive(false);
            texte_4.SetActive(true);
            bouton_suivant.SetActive(false);
            bouton_physique.SetActive(true);
            place++;
            break;
        default:
            break;
      }


    }

    public void precedent()
    {
      switch (place)
      {
        case 2:
            texte_1.SetActive(true);
            texte_2.SetActive(true);
            texte_3.SetActive(false);
            bouton_precedent.SetActive(false);
            place--;
            break;
        case 3:
            texte_3.SetActive(true);
            texte_4.SetActive(false);
            bouton_suivant.SetActive(true);
            place--;
            break;
        default:
            break;
      }

    }

}