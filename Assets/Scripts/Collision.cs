using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour {

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Gegner")
        {
            Debug.Log("Wand");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.collider.tag == "Ziel")
        {
            Debug.Log("Ziel");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
