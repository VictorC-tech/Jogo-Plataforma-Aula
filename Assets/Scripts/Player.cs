using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    private float horizontal;
    private bool isFacingRight = true;   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        this.rb.velocity = new Vector2(horizontal * 8f, this.rb.velocity.y);    

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Tecla espaço pressionada");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Botao direito pressionado");
        }
        Flip();
    }

    private void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }
}
