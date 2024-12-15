using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Controller_Player jugador = FindObjectOfType<Controller_Player>();

            if (jugador != null)
            {
                jugador.speed = 20f;
            }
           
            Destroy(this.gameObject);

        }
    }


}
