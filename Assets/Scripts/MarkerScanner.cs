using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ProjectD.Scripts;

public class MarkerScanner : MonoBehaviour
{
    public TMP_Text text;

    public void HandleInput()
    {
        StateNameController.userLocation = new Location();
        text.text = StateNameController.userLocation.GetValue();
    }
}
