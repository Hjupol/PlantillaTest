using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Movimiento_Enemigo : MonoBehaviour
{
    public float velocidad = 5.0f;

    private Rigidbody rbEnemigo;

    public GameObject target;
    public float daño;
    Controller_Player jugador = FindAnyObjectByType<Controller_Player>();

    // Start is called before the first frame update
    void Start()
    {
        rbEnemigo = GetComponent<Rigidbody>();
        target = GameObject.Find("jugador");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.transform.position) < 5) {

            var lookPos = target.transform.position - transform.position;
            //lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            transform.rotation = Quaternion.RotateTowards(transform.rotation,rotation,2);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);

        }

       
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Proyectil"))
        {
            Destroy(gameObject);
        }

        
    }
}
