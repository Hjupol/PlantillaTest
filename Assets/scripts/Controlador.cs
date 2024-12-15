using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class Controlador : MonoBehaviour
{

    public Controller_Player balas;
    public TMP_Text cantidadBalas;
    public string textoBalas;
    private Vector3 initialPosition;
    public int playerHealth = 100;
    public TMP_Text healthText;


    // Start is called before the first frame update
    void Start()
    {

        initialPosition = transform.position;
        healthText.text = "Vida:" + playerHealth.ToString();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Controller_Player jugador = FindAnyObjectByType<Controller_Player>();
            SceneManager.LoadScene("SampleScene");
            transform.position = initialPosition;
            jugador.speed = 3;
        }
        cantidadBalas.text = balas.bulletCount.ToString();
        healthText.text = playerHealth.ToString();
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {

            playerHealth -= 20;           
            Debug.Log(playerHealth);           
            if (playerHealth <= 0)
            {
                
                SceneManager.LoadScene("SampleScene");
             
               

            }

        }

   
    }
    public override string ToString()
    {
        
        return "vida:" + playerHealth.ToString();
    }
}  
