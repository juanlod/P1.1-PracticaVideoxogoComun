using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform jugador;
    // Start is called before the first frame update
    void Start()
    {
        if (jugador == null){
            Debug.Log("Script Camara: no has configurado al jugador");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 nuevaPosicion = transform.position;
        nuevaPosicion.x = jugador.position.x;
        nuevaPosicion.y = jugador.position.y;
        transform.position = nuevaPosicion;
    }
}
