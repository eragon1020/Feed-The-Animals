using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce = 10f;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public InputAction floatAction;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip bounceSound;

    private float topBound = 15f;

    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        floatAction.Enable();
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    void Update()
{
    bool isFloating = Keyboard.current != null && Keyboard.current.spaceKey.isPressed;
    Debug.Log("Space: " + isFloating + " | gameOver: " + gameOver + " | posY: " + transform.position.y);

    if (isFloating && !gameOver && transform.position.y < topBound)
    {
        Debug.Log("FUERZA APLICADA");
        playerRb.AddForce(Vector3.up * floatForce);
    }
}

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.transform.position = transform.position;
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            playerRb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
            if (bounceSound != null)
                playerAudio.PlayOneShot(bounceSound, 1.0f);
            else if (moneySound != null)
                playerAudio.PlayOneShot(moneySound, 1.0f);
        }
    }
}