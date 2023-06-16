using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditLocation : MonoBehaviour
{
    public TextMeshProUGUI location;
    // Start is called before the first frame update
    void Start()
    {
        location.text = $"({SpawnPosition.posx}, {SpawnPosition.posy}, {SpawnPosition.posz})";
    }

}
    