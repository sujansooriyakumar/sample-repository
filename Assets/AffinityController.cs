using UnityEngine;
using UnityEngine.InputSystem;

public class AffinityController : MonoBehaviour
{
    public InputAction switchAffinity;
    public ElementalAffinity currentAffinity;
    MeshRenderer meshRenderer;

    private void Start()
    {
        switchAffinity.Enable();
        switchAffinity.performed += SwitchAffinity;
        currentAffinity = ElementalAffinity.NONE;
        meshRenderer = GetComponent<MeshRenderer>();

    }

    private void SwitchAffinity(InputAction.CallbackContext c)
    {
        if (currentAffinity == ElementalAffinity.NONE) currentAffinity = ElementalAffinity.FIRE;
        else
        {
            currentAffinity += 1;
        }
        UpdateMaterial(currentAffinity);
    }

    private void UpdateMaterial(ElementalAffinity affinity)
    {
        switch (affinity)
        {
            case ElementalAffinity.FIRE:
                meshRenderer.material.color = Color.red;
                break;
            case ElementalAffinity.EARTH:
                meshRenderer.material.color = Color.brown;

                break;
            case ElementalAffinity.WATER:
                meshRenderer.material.color = Color.blue;

                break;
            case ElementalAffinity.AIR:
                meshRenderer.material.color = Color.white;

                break;
            case ElementalAffinity.NONE:
                meshRenderer.material.color = Color.gray;

                break;
        }
    }
}

public enum ElementalAffinity
{
    FIRE,
    EARTH,
    WATER,
    AIR,
    NONE
}
