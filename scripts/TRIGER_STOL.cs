using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using TMPro;

public class TRIGER_STOL : MonoBehaviour
{
    private float i =0;
    private int a =0;
    public TextMeshProUGUI text;
    void OnTriggerStay (Collider other){
        i=i+Time.deltaTime;
        if (i>=15){
            if  (other.gameObject.name == "g1") 
            {
                PlayerPrefs.SetInt("OCKI_ST",1);
                PlayerPrefs.Save();
            }
            if  (other.gameObject.name == "g2") 
            {
                PlayerPrefs.SetInt("OCKI_ST",2);
                PlayerPrefs.Save();
            }
            if  (other.gameObject.name == "g3") 
            {
                PlayerPrefs.SetInt("OCKI_ST",3);
                PlayerPrefs.Save();
            }
            if  (other.gameObject.name == "g4") 
            {
                PlayerPrefs.SetInt("OCKI_ST",4);
                PlayerPrefs.Save();
            }
            if  (other.gameObject.name == "g5") 
            {
                PlayerPrefs.SetInt("OCKI_ST",5);
                PlayerPrefs.Save();
            }
            if  (other.gameObject.name == "g6") 
            {
                PlayerPrefs.SetInt("OCKI_ST",6);
                PlayerPrefs.Save();
            }
            a = PlayerPrefs.GetInt("NUMHOD");
            PlayerPrefs.SetInt("NUMHOD",a+1);
            PlayerPrefs.Save();
            text.text = ""+PlayerPrefs.GetInt("OCKI_ST");
        }
        if (i>40){
            SceneManager.LoadScene(1);
        }
        
    }
}
