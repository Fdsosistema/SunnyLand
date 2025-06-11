using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private int pontos = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("game started" + pontos + "pontos");       
    }

    // Update is called once per frame
    void Update()
    {
    }
}
