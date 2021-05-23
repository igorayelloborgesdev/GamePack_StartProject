using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraManager : MonoBehaviour
{
    #region Variable
    private const float cameraLimitServe = 1.5f;
    private const float cameraLimitPlay = 1.0f;
    private static float cameraLimit = 0.0f;
    #endregion
    #region Methods    
    public void MoveCamera(bool isLeft)
    {
        try
        {
            this.transform.position = new Vector3(
            (isLeft ? cameraLimit : -cameraLimit),
            this.transform.position.y,
            this.transform.position.z
            );
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);            
        }
    }
    public void MoveCamera()
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);            
        }
    }
    private float ReturnCameraInc()
    {
        try
        {
            return 0.0f;
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
            return 0.0f;
        }
    }
    private float ReturnCameraIncRightLeft(bool isLeft)
    {
        try
        {
            if (isLeft)
            {
                return -0.15f;
            }
            else
            {
                return 0.15f;
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);
            return 0.0f;
        }
    }
    public static void SetCameraLimit(bool isServe)
    {
        try
        {
            if (isServe)
            {
                cameraLimit = cameraLimitServe;
            }
            else
            {
                cameraLimit = cameraLimitPlay;
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);            
        }
    }
    public void ResetCamera(bool isleft)
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            Debug.Log(ex.Message);            
        }
    }
    #endregion
}
