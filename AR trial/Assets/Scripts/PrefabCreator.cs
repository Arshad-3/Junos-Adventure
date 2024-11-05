using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class PrefabCreator : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Vector3 offset;

    private ARTrackedImageManager imageManager;
    private GameObject dragon;

    private void OnEnable()
    {
        imageManager = GetComponent<ARTrackedImageManager>();
        imageManager.trackedImagesChanged += ImageManager_trackedImagesChanged;
    }

    private void ImageManager_trackedImagesChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            dragon = Instantiate(prefab, image.transform);
            dragon.transform.position += offset;
        }
    }
}
