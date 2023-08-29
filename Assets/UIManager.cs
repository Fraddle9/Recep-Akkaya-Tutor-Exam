using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
