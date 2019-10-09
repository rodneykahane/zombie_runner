using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomRegularView = 60f;
    [SerializeField] float zoomInView = 20f;
    [SerializeField] float mouseZoomRegularSensitiviyFactor = 2f;
    [SerializeField] float mouseZoomInSensitiviyFactor = .5f;


    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            fpsCamera.fieldOfView = zoomInView;
            fpsController.mouseLook.XSensitivity = mouseZoomInSensitiviyFactor;
            fpsController.mouseLook.YSensitivity = mouseZoomInSensitiviyFactor;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            fpsCamera.fieldOfView = zoomRegularView;
            fpsController.mouseLook.XSensitivity = mouseZoomRegularSensitiviyFactor;
            fpsController.mouseLook.YSensitivity = mouseZoomRegularSensitiviyFactor;
        }
    }

}
