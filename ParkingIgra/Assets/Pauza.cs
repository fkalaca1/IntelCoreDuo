using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class Pauza : MonoBehaviour
{
    float levelStartDelay = 2f;
    bool Pauzirano = false;
    public static bool Zavrseno;
    int skor = GameManager.skor;

    void Start()
    {
        Time.timeScale = 1.0f;
        Pauzirano = false;
        Zavrseno = false;
    }

    


    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Pauzirano)
            {
                SceneManager.LoadScene("meniScena");
                Pauzirano = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                Pauzirano = true;
            }
        }
        else if (Input.GetKeyDown("return") && Pauzirano)
        {
            Time.timeScale = 1.0f;
            Pauzirano = false;
        }

       // if (GameManager.lvl == 15)
        //{
          //  Zavrseno = true;
        //}
        skor = GameManager.skor;

    }

    void OnGUI()
    {
        var centeredStyle = GUI.skin.GetStyle("Label");
        centeredStyle.alignment = TextAnchor.UpperCenter;

        if (Pauzirano)
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 150, 150), "<color=black><size=30>Pauzirali ste igru</size></color>\n<size=20>Pritisnite escape za izlaz, a enter za nastavak igre</size>");

        if (Zavrseno)
        {
            GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 250, 150), "<color=black><size=35>Cestitamo osvojili ste </size>\n" + skor + "<size=20>Pritisnite esc za izlazak</size></color>");
            //Time.timeScale = 0.0f;
            
            

        }
    }
    
}
