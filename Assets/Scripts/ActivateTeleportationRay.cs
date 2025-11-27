using UnityEngine;
using UnityEngine.InputSystem;



public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;
    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor leftRay;
    public UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor rightRay;


    void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);
        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);

        leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1);
        rightTeleportation.SetActive(!isRightRayHovering && rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.1);
    }
}
