using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue16 : MonoBehaviour
{
    [SerializeField]
    AudioSource Happy, Sad;
    public static int levelUp = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            levelUp = 1;
            if (mainMenu.Sound == 0)
            {
                Happy.Play();
            }
        }
        if (collision.gameObject.tag == "finish")
        {
            Time.timeScale = 0;
            Life.life -= 1;
            Blue1.life -= 1;
            if (mainMenu.Sound == 0)
            {
                Sad.Play();
            }
        }
    }
}
