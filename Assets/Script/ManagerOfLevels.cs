using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerOfLevels : MonoBehaviour
{
   public void LoadFollowingLevel()
    {
        int sceneNow = SceneManager.GetActiveScene().buildIndex;
        int followingSceneIndex = sceneNow++;
        SceneManager.LoadScene(sceneNow);
    }
}
