using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KontroleDugmadi : MonoBehaviour {
    public static bool usao = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Exit()
    {
        Application.Quit();
    }

    public void Pokreni()
    {
        SceneManager.LoadScene("scena");
        usao = false;

    }
    public static void PovecajLevel()
    {
        if(usao)
        {
            SceneManager.LoadScene("meniScena");
            Pauza.Zavrseno = true;
            GameManager.lvl = 0;
            GameManager.skor = 0;
            

        }


        if (GameManager.lvl<14)
        {
                GameManager.lvl++;
               
        }
        else
        {
            usao = true;
        }

            
        
        if(usao==false)
            SceneManager.LoadScene("scena");
        //Application.LoadLevel(Application.loadedLevel);
      
        
    }

}
