using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controll_Yatugatake : MonoBehaviour
{
    [SerializeField] private Toggle toggle_syokuseitai;
    [SerializeField] private Toggle toggle_kouzantai;
    [SerializeField] private Toggle toggle_akouzantai;
    [SerializeField] private Toggle toggle_teizantai;
    [SerializeField] private Toggle toggle_kawa;
    [SerializeField] private Toggle toggle_animal;

    public GameObject dem;
    public GameObject kouzan;
    public GameObject akouzan;
    public GameObject teizan;
    public GameObject zentai;
    public GameObject kawa;
    public GameObject animal;

    //public void Start()
    //{
    //    this.enabled = false;
    //}

    public void Update()
    {
        Toggle_Syokusei();
        Toggle_Kawa();
        Toggle_Animal();
    }

    public void Toggle_Syokusei()
    {
        if (toggle_syokuseitai.isOn)
        {
            if (toggle_kouzantai.isOn)
            {
                dem.SetActive(false);
                kouzan.SetActive(true);
                akouzan.SetActive(false);
                teizan.SetActive(false);
                zentai.SetActive(false);
            }
            else if (toggle_akouzantai.isOn)
            {
                dem.SetActive(false);
                kouzan.SetActive(false);
                akouzan.SetActive(true);
                teizan.SetActive(false);
                zentai.SetActive(false);
            }
            else if (toggle_teizantai.isOn)
            {
                dem.SetActive(false);
                kouzan.SetActive(false);
                akouzan.SetActive(false);
                teizan.SetActive(true);
                zentai.SetActive(false);
            }
            else
            {
                dem.SetActive(false);
                kouzan.SetActive(false);
                akouzan.SetActive(false);
                teizan.SetActive(false);
                zentai.SetActive(true);
            }
        }
        else
        {
            dem.SetActive(true);
            kouzan.SetActive(false);
            akouzan.SetActive(false);
            teizan.SetActive(false);
            zentai.SetActive(false);
        }
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

    public void Toggle_Animal()
    {
        if (toggle_animal.isOn)
        {
            animal.SetActive(true);
        }
        else
        {
            animal.SetActive(false);
        }
    }
}
