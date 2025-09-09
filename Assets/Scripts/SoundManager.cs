using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance; 
    public AudioClip scoreClip;     
    private AudioSource audioSource;

    private void Awake()
    {
        // Mantiene un solo SoundManager tra le scene
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject); // Se esiste già, elimina il duplicato
        }
    }

    // Riproduce il suono del punteggio
    public void PlayScoreSound()
    {
        if (scoreClip != null)
            audioSource.PlayOneShot(scoreClip);
    }
}
