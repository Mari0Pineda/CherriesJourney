using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiodeescena : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);//carga la escena del mismo valor que sceneToLoad
    }
}
