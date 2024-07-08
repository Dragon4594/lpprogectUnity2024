using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_skr : MonoBehaviour
{
    public GameObject play;
    public GameObject menu1;
    public GameObject nast;
    private int level;
    private int np=4;
    private int HOD;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        //Cursor.LockMode = LockMode.Unlocked;
        Cursor.visible = true; 
    }
    public void Play()
    {
        play.SetActive(true);
        menu1.SetActive(false);
    }

    public void Pl()
    {
        level=1;
        HOD=0;
        PlayerPrefs.SetInt("OCKI_ST",-1);
        PlayerPrefs.SetInt("NUMHOD",HOD);
        PlayerPrefs.SetInt("p1",0);
        PlayerPrefs.SetInt("p2",0);
        PlayerPrefs.SetInt("p3",0);
        PlayerPrefs.SetInt("p4",0);
        PlayerPrefs.SetInt("LVL",level);
        PlayerPrefs.Save();
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL"));
    }
    /* public void number_plauers()
    {
        level=1;
        PlayerPrefs.SetInt("LVL",level);
        PlayerPrefs.Save();
        SceneManager.LoadScene(PlayerPrefs.GetInt("LVL"));
    }*/
    public void Pl1()
    {
        SceneManager.LoadScene(0);
    }
    public void Pl11()
    {
        menu1.SetActive(true);
        nast.SetActive(false);
        play.SetActive(false);
    }
    ////////////////////////////////////////////////////
    public void nast0()
    {
        menu1.SetActive(false);
        nast.SetActive(true);
    }


    public void Exit()
    {
        Application.Quit();
    }
    public void cotinu(){
        level = PlayerPrefs.GetInt("LVL");
        SceneManager.LoadScene(level);
    }
}
