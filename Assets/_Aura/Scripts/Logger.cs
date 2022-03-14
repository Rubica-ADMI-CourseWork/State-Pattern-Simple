using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    private static Logger instance;
    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Logger>();
                if(instance == null)
                {
                    instance = new GameObject().AddComponent<Logger>();
                }
            }
            return instance;
        }
    }
   public void LogOutMessage(string message,bool canLog)
    {
        if (canLog)
        {
            Debug.Log(message);
        }
    }
}
