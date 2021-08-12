
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed;
    public float Width;
    
    public int score=0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   
    public void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newpos=rb.position + Vector2.right *x;

        newpos.x=Mathf.Clamp(newpos.x,-Width,Width);

        rb.MovePosition(newpos);
    }
    void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManager>().EndGame();
           
    }
}
