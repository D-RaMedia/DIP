using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSCene : MonoBehaviour
{
    public void Click()
    {
        Debug.Log("yee");
        SceneManager.LoadScene("SampleScene");
    }
}
