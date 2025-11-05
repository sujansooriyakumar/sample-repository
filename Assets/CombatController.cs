using UnityEngine;
using UnityEngine.InputSystem;

public class CombatController : MonoBehaviour
{
    public InputAction lightAttack;
    public InputAction heavyAttack;
    private int maxHits = 5;
    private int hitCount = 0;

    private void Start()
    {
        lightAttack.Enable();
        heavyAttack.Enable();

        lightAttack.performed += ExecuteLightAttack;
        heavyAttack.performed += ExecuteHeavyAttack;
    }

    private void ExecuteLightAttack(InputAction.CallbackContext c)
    {
        Debug.Log("Light attack executed");
    }

    private void ExecuteHeavyAttack(InputAction.CallbackContext c)
    {
        Debug.Log("Heavy attack executed");

    }
}
