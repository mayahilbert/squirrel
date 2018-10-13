using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter () {
        StartCoroutine(Wait());
        SceneManager.LoadScene("Level 02", LoadSceneMode.Additive);
    }
    IEnumerator Wait()
    {
        print(Time.time);
        yield return new WaitForSecondsRealtime(5);
        print(Time.time);
    }

}
