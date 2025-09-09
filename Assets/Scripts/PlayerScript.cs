using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    private float jumpForce = 5f;
    private float rotationFactor = 5f;
    public static bool playerIsAlive = true;

    private Rigidbody2D rb;
    private LogicScript logic;

    public AudioClip deathSound;
    private AudioSource audioSource;

    // All'avvio prende LogicScript per resettare lo stato del player
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSource = GetComponent<AudioSource>();
        playerIsAlive = true;
    }

    // Controlla l'input del giocatore per far saltare il player
    void Update()
    {
        // Controllo input da Mouse
        if (Mouse.current.leftButton.wasPressedThisFrame && playerIsAlive)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private void FixedUpdate() 
    {
        float angle = rb.velocity.y * rotationFactor;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // Se il player collide con un ostacolo, la partita termina
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (audioSource != null && deathSound != null)
        {
            audioSource.PlayOneShot(deathSound);
        }

        playerIsAlive = false;
        logic.gameOver();
    }
}
