using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controll_Yatugatake : MonoBehaviour
{
    [SerializeField] private Toggle toggle_kawa;

    public GameObject kawa;

    public void Update()
    {
        Toggle_Kawa();
    }

    public void Toggle_Kawa()
    {
        if (toggle_kawa.isOn)
        {
            kawa.SetActive(true);
        }
        else
        {
            kawa.SetActive(false);
        }
    }
}
