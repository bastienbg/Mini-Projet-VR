using UnityEngine;


public class XRGrabbableInteractableTwoAttach : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;
    public override Transform GetAttachTransform(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor interactor)
    {
        Transform i_attachTransform = null;

        if (interactor.transform.CompareTag("Left Hand"))
        {
            i_attachTransform = leftAttachTransform;
        }
        if (interactor.transform.CompareTag("Right Hand"))
        {
            i_attachTransform = rightAttachTransform;
        }
        return i_attachTransform != null ? i_attachTransform : base.GetAttachTransform(interactor);
    }
}
