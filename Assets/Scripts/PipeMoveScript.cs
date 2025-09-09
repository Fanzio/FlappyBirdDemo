using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float moveSpeed = 8;
    private float deadZone = -35;

    // Muove il tubo verso sinistra e lo elimina quando esce dallo schermo
    void Update()
    {
        if (PlayerScript.playerIsAlive == true)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
