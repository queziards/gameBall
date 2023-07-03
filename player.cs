using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float spped; //velocidade
    public float jumpForce;
    public Rigidbody2D rig;

    float direction; //direita/esquerda e o float retorna um valor  

    void Start()
    {
        
    }

   
    void Update() //chamado a cada frame
    {
        direction = Input.GetAxis("Horizontal"); //se pressionar direita retorna 1 se esquerda retorna -1, e nada = 0

        if(Input.GetKeyDown(KeyCode.Space)) //checador de condicional
        {
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

   void FixedUpdate()//chamado pela fisica, usadp para manipular a fisica do jogo
  {
    rig.velocity = new Vector2(direction * spped, rig.velocity.y);
  }



}
