using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteJugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D colision){
        Jugador jugador = colision.gameObject.GetComponent<Jugador>();

        if (jugador != null){
            jugador.Morir();
        }
    }
}
