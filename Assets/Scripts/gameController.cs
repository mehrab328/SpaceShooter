using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    public void loadAnotherScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
	
}
