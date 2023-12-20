using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controll_Start : MonoBehaviour
{
    public void Start_button()
    {
        SceneManager.LoadScene("Main");
    }
}
