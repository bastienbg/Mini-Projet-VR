using UnityEngine;


public class ActivateRayGrab : MonoBehaviour
{
    public GameObject leftGrabRay;
    public GameObject rightGrabRay;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor leftDirectGrab;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor rightDirectGrab;
    void Update()
    {
        leftGrabRay.SetActive(leftDirectGrab.interactablesSelected.Count == 0);
        rightGrabRay.SetActive(rightDirectGrab.interactablesSelected.Count == 0);
    }
}
