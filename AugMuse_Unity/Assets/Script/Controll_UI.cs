using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Controll_UI : MonoBehaviour
{
    public GameObject Menu;
    public bool menu_flag = false;

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
}
