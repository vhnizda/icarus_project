using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody2D trampolineBody;

    private void Awake()
    {
        trampolineBody = GetComponent<Rigidbody2D>();
    }


    public void MouseMove(InputAction.CallbackContext context)
    {
        Debug.Log("mouse moved" + context);
        InputControl activeControl = context.action.activeControl;
        {

        }
        trampolineBody.AddForce(Vector3.right * 5f, ForceMode2D.Impulse);
    }

}
