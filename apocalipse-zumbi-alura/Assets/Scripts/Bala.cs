using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float Velocidade = 20;
    private Rigidbody rigibodyBala;

    void Start()
    {
        rigibodyBala = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigibodyBala.MovePosition(rigibodyBala.position + transform.forward * Velocidade * Time.deltaTime);
    }


    void OnTriggerEnter(Collider objetoDeColisao)
    {
        // destroi o objeto que possui a tag Inimigo
        if(objetoDeColisao.tag =="Inimigo")
        {
            Destroy(objetoDeColisao.gameObject);
        }

        // Destroi o proprio objeto (Bala)
        Destroy(gameObject);

    }
}
