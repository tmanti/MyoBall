using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youWin : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }

    void Update()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Main Menu");
    }
}
