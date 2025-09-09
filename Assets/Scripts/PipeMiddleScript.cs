using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;         // riferimento al GameManager/LogicScript
    public AudioSource scoreSound;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // controlla se il collider è il player (layer 3 nel tuo caso)
        if (collision.gameObject.layer == 3)
        {
            // aumenta il punteggio
            logic.addScore(1);

            // riproduci il suono tramite SoundManager
            if (SoundManager.instance != null)
                SoundManager.instance.PlayScoreSound();
        }
    }
}
