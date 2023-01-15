using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]

public class SceneSwitcher : MonoBehaviour
{
    public void StartTutorial1()
    {
        SceneManager.LoadScene(1);
    }
    
    public void StartStep_01()
    {
        SceneManager.LoadScene(2);
    }
}
