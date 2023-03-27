using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Debug = UnityEngine.Debug;

public class ItemList : MonoBehaviour
{
    public class Item
    {
        public int id;
        public string name;
        public int xPos;
        public int yPos;
        public int zPos;

        public Item(int Id, string Name) 
        {
            id = Id;
            name = Name;
            xPos = 0;
            yPos = 0;
            zPos = 0;
        }

        public Item(int Id, string Name, int x, int y, int z)
        {
            id = Id;
            name = Name;
            xPos = x;
            yPos = y;
            zPos = z;
        }
    }

    public List<Item> items = new List<Item>()
    {
        new Item(1, "Pens"),
        new Item(2, "Paper"),
    };

    public TMP_Dropdown ItemDropdown;

    public List<string> CreateList()
    {
        var res = new List<string>();
        foreach(var item in items)
        {
            res.Add(item.name);
        }
        return res;
    }

    // Start is called before the first frame update
    void Start()
    {
        var DropOptions = CreateList();
        ItemDropdown = transform.GetComponent<TMP_Dropdown>();
        ItemDropdown.options.Clear();
        foreach (string option in DropOptions)
        {
            ItemDropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        ItemDropdown.value = 0;
        ItemDropdown.RefreshShownValue();
    }
}
