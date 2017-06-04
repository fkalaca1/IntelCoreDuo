using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car2dController : MonoBehaviour {

    public Sprite dmgSpritegore;
    public Sprite dmgSpritedole;
    public Sprite dmgSpritelijevo;
    public Sprite dmgSpritedesno;

    public float Steer = 0;
    public float MaxSteerAngle = 30;
    public Vector3 vec = new Vector3();
    public float Accel = 1;
    public float MaxAccel = 10;
    public float MaxReverseAccel = 2;
    public float SteerSpeed = 1;
    public float CarSteerApplySpeed = 1; // 1 - rotacija volana se direktno odrazuje na rotaciju vozila, 0 - nikako
    public float timeleft;
    private Text skorTekst;
    public Image Volan;
    public Vector3 VolanCenterRotation = Vector3.zero;
    public Vector3 CarCenterRotation;

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        //check for button up down here, tehn set a bool that you will use in FixedUpdate
    }

    private float gas = 0;

	// Update is called once per frame
	void FixedUpdate () {
        float speed = 0;

        #region Move/Back movement
        { 
            float vertical = Input.GetAxisRaw("Vertical");
            gas = Mathf.Lerp(gas, vertical, Accel);

            float scaledGas = gas *  (gas > 0 ? MaxAccel : MaxReverseAccel);

            Vector2 moveVec = transform.up * scaledGas;

            speed = moveVec.magnitude;

            var rigid = GetComponent<Rigidbody2D>();
            rigid.position += moveVec;
            vec = rigid.position;
            
        }
        #endregion

        {
            float hor = Input.GetAxisRaw("Horizontal");

            if ( Mathf.Abs(hor) > 0.01f )
                Steer = Mathf.Lerp(Steer, Mathf.Clamp(Steer + hor, -1, 1), SteerSpeed);
            else
                Steer = Mathf.Lerp(Steer, 0, SteerSpeed);

            //Update volan rotation
            Volan.transform.rotation = Quaternion.Euler(VolanCenterRotation - Vector3.forward * Steer * MaxSteerAngle);

            //Update car rotation
            if ( gas > 0.1f )
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles - Vector3.forward * Steer * MaxSteerAngle * CarSteerApplySpeed * speed);
            else if ( gas < -0.1f)
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + Vector3.forward * Steer * MaxSteerAngle * CarSteerApplySpeed * speed);
        }
        Text vrijemeTekst = GameObject.Find("VrijmeText").GetComponent<Text>();
        vrijemeTekst.text = "Preostalo vrijeme " + Mathf.Round(timeleft);

        timeleft -= Time.deltaTime;
        if (timeleft < 0)
        {
            IzracunajSkor();
        }

    }

    public void IzracunajSkor()
    {
        Vector3 tackaTamo = new Vector3(GameManager.kordinatax, GameManager.kordinatay, 0);

        float udaljenost = Vector3.Distance(tackaTamo, vec);
        
        if (udaljenost < 10)
            GameManager.skor += 1000 - (int)(100 * udaljenost);
        KontroleDugmadi.PovecajLevel();
        skorTekst = GameObject.Find("SkorTekst").GetComponent<Text>();
        skorTekst.text = "Skor je: " + GameManager.skor;
        //Debug.Log("skor je " + GameManager.skor);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
            GameManager.skor -= 100;

            Text skorTekst = GameObject.Find("SkorTekst").GetComponent<Text>();
            skorTekst.text = "Skor je: " + GameManager.skor;

    }

}
