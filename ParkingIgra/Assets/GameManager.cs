using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;//koristimo unityev random

public class GameManager : MonoBehaviour {
    
    public static GameManager instance = null;
    public GameObject[] auto;
    public GameObject autoProzirni,autoNas;
    public static int skor = 0;
    public static int lvl=1;
    int red = 0;
    int kolona = 0;
    public static float kordinatax, kordinatay;
    int[] lista=new int[15];

   
	
    // Use this for initialization
    void Start()
    {
        Text skorTekst = GameObject.Find("SkorTekst").GetComponent<Text>();
        skorTekst.text = "Skor je: " + skor;

       Text levelTekst = GameObject.Find("LevelText").GetComponent<Text>();
       levelTekst.text = "Level  " + lvl;
        Vector3 mjestoAuta = new Vector3(59f, 9f, 0f);



        //da ne postoje dva game objecta cuva
        /* if (instance == null)
             instance = this;
         else if (instance != this)
             Destroy(gameObject);

         //da ne unisti hijerarhiju objekata pri prelazu sa scena
         DontDestroyOnLoad(gameObject);*/

        //Instantiate(AutoPravi, mjestoAuta, Quaternion.identity);
       

        for (int i=0;i<lvl;i++)
        {
            
            int pozicija = Random.Range(1, 15);
            if (lista[pozicija]!=5)
            {
                
                lista[pozicija] = 5;
                if (pozicija > 7)
                {
                    red = 1;
                    kolona = pozicija - 7-1;
                }
                else
                {
                    kolona = pozicija-1;
                    red = 0;
                }
                
                Vector3 mjesto = new Vector3(10.3f+6.65f*kolona, 52.5f-23.5f*red, 0f);
                int pos = Random.Range(0, 4);

                if (i == 0)
                {
                    Instantiate(autoProzirni, mjesto, Quaternion.identity);
                    kordinatax = mjesto.x;
                    kordinatay = mjesto.y;

                }
                else
                Instantiate(auto[pos], mjesto, Quaternion.identity);

            }
            else
            {
                i--;
            }
                
        }



    }

    internal static void IzracunajSkor()
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

   
}
