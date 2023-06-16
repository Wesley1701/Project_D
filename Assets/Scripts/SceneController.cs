using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ProjectD.Scripts 
{
    public class SceneController : MonoBehaviour
    {

        public void checkValues()
        {
            if (StateNameController.item != null || StateNameController.userLocation != null)
            {
                NextScene();
            }
            else
            {
                UnityEngine.Debug.Log("Select a value");
            }
        }

        public void LoadQRScanner()
        {
            SceneManager.LoadScene("QRScanner");
        }

        public void LoadMenuScene()
        {
            SceneManager.LoadScene("ItemMenu");
        }

        public void NextScene()
        {
            //UnityEngine.Debug.Log($"The user can be found at these coordinates: {StateNameController.userLocation.GetValue()}");
            UnityEngine.Debug.Log($"{StateNameController.item.name} can be found at these coordinates: {StateNameController.item.location.GetValue()}");
            SceneManager.LoadScene("AR-Section");
        }

        public void ReloadScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
