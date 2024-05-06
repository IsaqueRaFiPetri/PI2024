using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public float speed = 5.0f;       // Velocidade do personagem
    public float jumpForce = 5.0f;  // Forca do pulo

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Input do jogador
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        float jump = Input.GetAxisRaw("Jump");

        // Movimentação do personagem
        Vector3 movement = new Vector3(moveHorizontal * speed, jump * jumpForce, moveVertical * speed);
        rb.AddForce(movement);

        print(movement);
        print(moveVertical);
        print(moveHorizontal);
    }
}
//https://www.youtube.com/watch?v=eJPD2Os9leI - assitir
