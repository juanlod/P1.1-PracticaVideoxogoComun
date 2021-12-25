using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int numeroCheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D colisionador){
        Jugador jugador = colisionador.gameObject.GetComponent<Jugador>();

        if (jugador != null){
            Debug.Log("Checkpoint numero " + numeroCheckPoint);
        }
    }
}
