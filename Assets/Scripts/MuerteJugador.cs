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
        RespawnJugador(jugador);
    }

    private void OnTriggerEnter2D(Collider2D colider){
        Jugador jugador = colider.gameObject.GetComponent<Jugador>();
        RespawnJugador(jugador);
    }

    private void RespawnJugador(Jugador jugador){
        if (jugador != null){
            jugador.Morir();
        }
    }
}
