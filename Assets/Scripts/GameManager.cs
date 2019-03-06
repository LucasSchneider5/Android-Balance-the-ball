using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject completeLevel;
	public void CompleteLevel ()
    {
        completeLevel.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
