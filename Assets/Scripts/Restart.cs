using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.EventSystems;


public class Restart : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            // reload the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}