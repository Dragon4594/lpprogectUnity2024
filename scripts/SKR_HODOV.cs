using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SKR_HODOV : MonoBehaviour
{
    private int countpl=4;
    private int HOD;
    //private string POSL="";
    private int OCHKI; 
    private int i;
    private int [,] arr;
    //public GameObject STOL_KUB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("NUMHOD")<=8){
            /*arr=new int[countpl,2];
            for (i=0;i<countpl;i++){
                
                STOL_KUB.SetActive(true);
                arr[i,0]=i+1;
                arr[i,1]=PlayerPrefs.GetInt("OCKI_ST");
                STOL_KUB.SetActive(false);
            }*/
            //wihle (POST.lenght==4){
            /*if (PlayerPrefs.GetInt("NUMHOD")=1){
                PlayerPrefs.SetInt("p1",PlayerPrefs.GetInt("OCKI_ST"));
                PlayerPrefs.Save();
            }
            if(PlayerPrefs.GetInt("p1")==0){
                PlayerPrefs.SetInt("p1",PlayerPrefs.GetInt("OCKI_ST"));
                PlayerPrefs.Save();
                SceneManager.LoadScene(2);
            }
            if(PlayerPrefs.GetInt("p2")==0){
                
                SceneManager.LoadScene(2);
            }
            if(PlayerPrefs.GetInt("p3")==0){
                
                SceneManager.LoadScene(2);
            }
            if(PlayerPrefs.GetInt("p4")==0){
                
                SceneManager.LoadScene(2);
            }*/
           

            
        }
    }
}
