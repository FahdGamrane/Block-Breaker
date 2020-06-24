using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    public static int lives = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives--;
        if (lives == -1)
            lives = 2;

        if (lives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
        else
        {
            FindObjectOfType<Ball>().hasStarted = false;
            FindObjectOfType<Ball>().LockBallToPaddle();

        }
    }
}
