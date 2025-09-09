using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    private float speed = 8f;           // velocità dello scorrimento
    private float resetPositionX = -55f; // posizione a cui resettare il terreno

    private Vector3 startPosition;

    void Start()
    {
        // salva la posizione iniziale
        startPosition = transform.position;
    }

    void Update()
    {
        if (PlayerScript.playerIsAlive == true)
        {
            // muove il terreno verso sinistra
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        // se supera la posizione di reset, torna all'inizio
        if (transform.position.x < resetPositionX)
        {
            transform.position = startPosition;
        }
    }
}
