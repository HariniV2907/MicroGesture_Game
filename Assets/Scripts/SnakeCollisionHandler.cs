using UnityEngine;
using TMPro;

public class SnakeCollisionHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public GameObject appleSoundObj;
    public GameObject defectSoundObj;
    public GameObject wallSoundObj;

    private AudioSource appleAudio;
    private AudioSource defectAudio;
    private AudioSource wallAudio;

    private int score = 0;
    private bool gameOver = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UpdateScoreDisplay();

        // Get the AudioSources from GameObjects
        appleAudio = appleSoundObj.GetComponent<AudioSource>();
        defectAudio = defectSoundObj.GetComponent<AudioSource>();
        wallAudio = wallSoundObj.GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameOver) return;

        GameObject other = collision.gameObject;

        Debug.Log("Touched: " + other.tag);

        if (other.CompareTag("Apple"))
        {
            score += 5;
            UpdateScoreDisplay();
            other.SetActive(false);
            if (appleAudio != null) appleAudio.Play();
        }
        else if (other.CompareTag("Defect"))
        {
            score -= 2;
            UpdateScoreDisplay();
            other.SetActive(false);
            if (defectAudio != null) defectAudio.Play();
        }
        else if (other.CompareTag("Wall"))
        {
            gameOver = true;
            scoreText.text = "GAME OVER";
            rb.linearVelocity = Vector3.zero;
            rb.isKinematic = true;
            if (wallAudio != null) wallAudio.Play();
        }
    }

    void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
