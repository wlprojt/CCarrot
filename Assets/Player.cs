using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;

    int score = 0;

    public GameObject winText;

    public GameObject restartButton;

    public int winScore;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;

        transform.Translate(hInput, vInput, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "carrot")
        {

            score++;

            Destroy(collision.gameObject);

            if(score >= winScore)
            {
                winText.SetActive(true);
                restartButton.SetActive(true);
            }

        }
    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}