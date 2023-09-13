using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    GameObject Happy, Sad;
    [SerializeField]
    AudioSource inTheGame, PauseMenu;
    float speed = 5f;
    Rigidbody2D rb;
    public static bool leftRight;

    private void Start()
    {
        leftRight = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        if(dir.sqrMagnitude > 1)
        {
            dir.Normalize();
        }

        dir *= Time.deltaTime;
        rb.AddForce(dir * speed, ForceMode2D.Impulse);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Red") || collision.gameObject.CompareTag("Blue"))
        {
            leftRight = false;
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            if (mainMenu.Sound == 0)
            {
                inTheGame.Pause();
                PauseMenu.Play();
            }
        }
        else if (collision.gameObject.CompareTag("finish"))
        {
            leftRight = false;
            Happy.SetActive(false);
            Sad.SetActive(true);
            if (mainMenu.Sound == 0)
            {
                inTheGame.Pause();
                PauseMenu.Play();
            }
        }
    }
}
