using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Object_controll : MonoBehaviour
{
    ARTrackedImageManager trackedImageManager;
    [SerializeField] private GameObject objectToAdjust;


    private void Awake()
    {
        trackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    void OnImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        Debug.Log("ARdayo");
        foreach (var trackedImage in eventArgs.added)
        {
            // Check if the recognized image is the one you want
            if (trackedImage.referenceImage.name == "ARdayo")
            {
                // Adjust the orientation of your GameObject
                objectToAdjust.transform.rotation = Quaternion.Euler(90, 0, 0);
            }
        }
    }
}
