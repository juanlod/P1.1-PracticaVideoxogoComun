using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float VELOCIDAD = 3f;
    public float direccion = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverEnemigo();
    }

    private void MoverEnemigo(){
        Vector3 escala = transform.localScale;
        Vector2 posicion = transform.position;
        if (direccion == -1){
            posicion.x += VELOCIDAD * direccion * Time.deltaTime;
            escala.x = Mathf.Abs(escala.x) * direccion;
        }
        transform.position = posicion;
        transform.localScale = escala;
    }
}
