using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickHomeBtn() {
        SceneManager.LoadScene("StartScene");
    }

    public void OnClickStartBtn() {
        SceneManager.LoadScene("PlayScene");
    }

    public void ExitBtn() {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif        
    }
}
