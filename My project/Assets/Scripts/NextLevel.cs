using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            //  Debug.Log("Hit!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }

}
