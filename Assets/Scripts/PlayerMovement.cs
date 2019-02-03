using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed, jumpForce;
    private float xMove, yMove;
    private bool isRunning, staminareload, ableToRun;
    public float runningAccelaration, maxRunningSpeed, Stamina, staminaMinLoad, staminaAdd;

    private void Start()
    {
        ableToRun = true;
        staminareload = false;
        isRunning = true;
        Speed = 4;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");

        float moveVecH = xMove * (Speed * Time.deltaTime);
        float moveVecV = yMove * (Speed * Time.deltaTime);

        transform.Translate(moveVecH, 0, moveVecV);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
            if(Stamina >= 0 && !staminareload)
            {
                staminareload = false;
            }
            Running();
        }
        else { isRunning = false; Running(); }

        staminaCalc();
        

    }

    public void Running()
    {
        if(isRunning && ableToRun)
        {
            if(Speed < maxRunningSpeed)
            {
               Speed += runningAccelaration * Time.deltaTime;
            }
            
        }
        else { Speed = 4; }
    }


    public void staminaCalc()
    {
        if(isRunning && ableToRun)
        {
            Stamina -= staminaMinLoad * Time.deltaTime;
            if(Stamina <= 0 && ableToRun)
            {
                isRunning = false;
                Stamina = 0;
                staminareload = true;
                ableToRun = false;
            }
        }
        if (staminareload)
        {
            Stamina += staminaAdd * Time.deltaTime;
            if (Stamina >= 10)
            {
                Stamina = 10;
                staminareload = false;
            }
            if (Stamina >= 4)
            {
                ableToRun = true;
            }
        }
    }
}
