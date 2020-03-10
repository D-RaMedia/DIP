using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Ground : MonoBehaviour
{
    public int Ecore = 0;

    private void OnTriggerEnter(Collider Other)
    {
        EndScore();
        if (Ecore == 2)
        {
            IveBeenClicked();
        }
    }
    void EndScore()
    {
        Ecore++;
        Debug.Log("Hell");


    }
    public void IveBeenClicked()
    {
        Debug.Log("Noice");
        SceneManager.LoadScene("Quit");
    }
}