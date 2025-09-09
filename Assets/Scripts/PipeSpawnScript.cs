using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    private float spawnRate = 2.5f;
    private float timer = 0;
    private float heightOffset = 5;

    public GameObject pipe;
    // All'avvio spawna subito un tubo
    void Start()
    {
        spawnPipe();
    }

    // Per ogni secondi di timer spawna un nuovo tubo solo se il player è vivo
    void Update()
    {
        if (!PlayerScript.playerIsAlive)
            return; // interrompe lo spawn se il player è morto

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    // Genera un tubo in posizione casuale sull'asse Y
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
