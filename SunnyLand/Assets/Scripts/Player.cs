using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public string nome = "DBD";
    public int HP = 5;
    public float speed = 2;
    private bool isAlive = true;
    private Rigidbody2D rb;
    public float CU = 0;

    void Start()
    {
        Debug.Log("Nome:" + nome + "\nVida:" + HP + "\nVelocidade:" + speed + "\nVivo ou morto:" + isAlive);
    rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = CU;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
