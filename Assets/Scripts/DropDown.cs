using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Debug = UnityEngine.Debug;

public class DropDown : MonoBehaviour
{

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            Debug.Log("Option 1");
        }
        if (val == 1)
        {
            Debug.Log("Option 2");
        }
        if (val == 2)
        {
            Debug.Log("Option 3");
        }
    }
}
