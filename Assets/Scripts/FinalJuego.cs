using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D colider){
        Jugador jugador = colider.gameObject.GetComponent<Jugador>();
        Debug.Log(jugador);
        if (jugador != null){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
