using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controll_Object : MonoBehaviour
{
    [SerializeField] private Toggle toggle_kawa;
    public GameObject yatugatake_def;
    public GameObject yatugatake_kawa;

    void Start()
    {
        // onValueChangedイベントにToggle_Kawaメソッドを追加
        toggle_kawa.onValueChanged.AddListener(delegate {
            Toggle_Kawa();
        });
        Debug.Log("STARTTTTTT!!!!!");
    }

    public void Toggle_Kawa()
    {
        if (toggle_kawa.isOn)
        {
            GetComponent<ARTrackedImageManager>().trackedImagePrefab = yatugatake_kawa;
            Debug.Log("kawa");
        }
        else
        {
            GetComponent<ARTrackedImageManager>().trackedImagePrefab = yatugatake_def;
            Debug.Log("def");
        }
    }
}
