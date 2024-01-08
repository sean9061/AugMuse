using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Controll_UI : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Feedback;
    public bool menu_flag = false;
    public bool feedback_flag = false;

    public void Controll_Menu()
    {
        if (!menu_flag)
        {
            //Menu.SetActive(true);
            Menu.transform.DOLocalMoveY(-350f, 0.5f);
            menu_flag = true;
        }
        else
        {
            Menu.transform.DOLocalMoveY(-1520f, 0.5f);
            //Menu.SetActive(false);
            menu_flag = false;
        }
    }

    public void Controll_Home()
    {
        SceneManager.LoadScene("Title");
    }

    public void Controll_Feedback()
    {
        if (!feedback_flag)
        {
            Feedback.SetActive(true);
            feedback_flag = true;
        }
        else
        {
            Feedback.SetActive(false);
            feedback_flag = false;
        }
    }

    public void Google_form()
    {
        Application.OpenURL("https://forms.gle/vZXLA5VUoX7vEVPQA");
    }
}
