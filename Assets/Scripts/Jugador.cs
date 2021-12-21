using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float VELOCIDAD = 5;

    public float FUERZA_SALTO = 10;
    float direccion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverJugador(); 
        RotarSprite();

        if (Input.GetKey(KeyCode.Space)){
           Saltar();
       }
    }

    private void MoverJugador(){
        direccion = 0;
        Vector2 posicionSiguiente = transform.position;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            direccion = -1;
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            direccion = 1;
        }

        posicionSiguiente.x += direccion * VELOCIDAD * Time.deltaTime;
        transform.position = posicionSiguiente;
    }
    private void RotarSprite(){
        Vector3 escalaLocal = transform.localScale;
        if (direccion == -1){
            escalaLocal.x = Mathf.Abs(escalaLocal.x) * -1;
        } else if (direccion == 1){
            escalaLocal.x = Mathf.Abs(escalaLocal.x);
        }
        transform.localScale = escalaLocal;
    }

    private void Saltar(){
        cuerpo.velocity = Vector2.up * FUERZA_SALTO;
    }
}
