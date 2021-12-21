using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float VELOCIDAD = 5;
    float direccion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverJugador(); 
    }

    private void MoverJugador(){
        direccion = 0;
        Vector2 posicionSiguiente = transform.position;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            direccion = -1;
        }
        posicionSiguiente.x += direccion * VELOCIDAD * Time.deltaTime;
        transform.position = posicionSiguiente;
    }
}
