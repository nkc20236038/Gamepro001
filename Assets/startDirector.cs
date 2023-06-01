using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Gamescene");
        }
        if (Input.GetKeyDown(0))
        {
            SceneManager.LoadScene("Gamescene");
        }
    }
}

