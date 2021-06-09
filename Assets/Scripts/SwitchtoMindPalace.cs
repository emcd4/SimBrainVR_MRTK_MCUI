using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Microsoft.MixedReality.Toolkit.Utilities;

public class SwitchtoMindPalace : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwithSceneToClinic(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
