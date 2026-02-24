using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZone : MonoBehaviour
{
    public string sceneToLoad = "Level_2";
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
