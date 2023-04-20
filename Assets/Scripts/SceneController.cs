using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("ItemMenu");
    }

    public void NextScene()
    {
        UnityEngine.Debug.Log($"{StateNameController.item.name} can be found at these coordinates: {StateNameController.item.xPos}, {StateNameController.item.yPos}, {StateNameController.item.zPos}");
        SceneManager.LoadScene("BlankAR");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
