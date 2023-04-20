using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ProjectD.Scripts;

using Debug = UnityEngine.Debug;

namespace ProjectD.Scripts
{
    public class DropDown : MonoBehaviour
    {
        public void HandleInputData(int val)
        {
            var itemList = new ItemList();
            var selItem = itemList.items[val];
            StateNameController.item = selItem;
        }
    }
}

