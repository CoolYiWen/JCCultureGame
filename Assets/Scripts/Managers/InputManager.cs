using UnityEngine;
using System.Collections;

public class InputManager : SingletonUnity<InputManager>
{

    void FixedUpdate()
    {
        if(GameManager.Instance.IsGameRunning)
        {
            if(PlayerController.Instance.IsOnShip)
            {
                PlayerController.Instance.MoveOnShip (ETCInput.GetAxis (Constant.Axis_Horizontal), ETCInput.GetButton (Constant.Button_Jump));
            }
            else
            {
                PlayerController.Instance.Move (ETCInput.GetAxis (Constant.Axis_Horizontal), ETCInput.GetButton (Constant.Button_Jump));
            }
        }




    }

}

