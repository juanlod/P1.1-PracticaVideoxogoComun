using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float VELOCIDAD = 3f;
    public int direccion = -1;
    private float contador = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverEnemigo();
        if (contador < 0){
            CambiarDireccion();
        }
        contador -= Time.deltaTime;
    }


    //La funcion mueve al personaje dependiendo de la posicion y la direccion 
    //tambien rota el sprite dependiendo de la direccion
    private void MoverEnemigo(){
        Vector3 escala = transform.localScale;
        Vector2 posicion = transform.position;

        //Se mueve el personaje
        posicion.x += VELOCIDAD * direccion * Time.deltaTime;
        //Se cambia de direccion el sprite
        escala.x = Mathf.Abs(escala.x) * direccion;

        transform.position = posicion;
        transform.localScale = escala;
    }

    //La funcion CambiarDireccion cambia la direccion del personaje y 
    //asigna un numero aleatoria para el proximo cambio de direccion
    private void CambiarDireccion(){
        direccion *= -1;
        contador = Random.Range(0.5f, 2.5f);
    }
}
