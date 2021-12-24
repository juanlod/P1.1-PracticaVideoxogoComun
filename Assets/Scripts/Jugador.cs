using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public float VELOCIDAD = 5;

    public float FUERZA_SALTO = 10;

    public LayerMask mascaraSuelo;
    float direccion;

    private Rigidbody2D cuerpo;

    private CapsuleCollider2D colisionador;


    void Start()
    {
         this.cuerpo = GetComponent<Rigidbody2D>(); 
         this.colisionador = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoverJugador(); 
        RotarSprite();

        if (Input.GetKey(KeyCode.Space) && ComprobarSuelo()){
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

    private bool ComprobarSuelo(){
        float desfase = 0.01f;
        RaycastHit2D golpe  = Physics2D.Raycast(this.colisionador.bounds.center, Vector2.down, this.colisionador.bounds.extents.y + desfase , mascaraSuelo );
        return golpe.collider != null;
    }

    public void Morir(){
        this.transform.position = ControladorJuego.instancia.posicionRespawn.position;
    }
}
