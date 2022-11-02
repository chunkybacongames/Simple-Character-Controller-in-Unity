using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region Variables

    private Vector2 _input;

    #endregion

    #region Events

    public void Move(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
        Debug.Log(_input);
    }

    #endregion
}
