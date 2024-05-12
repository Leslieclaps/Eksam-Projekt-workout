
using UnityEngine;

using UnityEngine.SceneManagement;
 
public class SceneChanger : MonoBehaviour

{

    // Function to change the scene based on scene name

    public void ChangeSceneByName(string sceneName)

    {

        SceneManager.LoadScene(sceneName);

    }

    // Function to change the scene based on scene index

    public void ChangeSceneByIndex(int sceneIndex)

    {

        SceneManager.LoadScene(sceneIndex);

    }

}

