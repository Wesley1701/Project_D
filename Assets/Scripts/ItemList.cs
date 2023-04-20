using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Debug = UnityEngine.Debug;

namespace ProjectD.Scripts
{
    public class ItemList : MonoBehaviour
    {
        public List<Item> items = new List<Item>()
        {
            new Item(1, "Boxes"),
            new Item(2, "Bags"),
            new Item(3, "Pallets"),
            new Item(4, "Bins"),
            new Item(5, "Storage containers"),
            new Item(6, "Cardboard dividers"),
            new Item(7, "Plastic wrapping"),
            new Item(8, "Foam packaging"),
            new Item(9, "Bubble wrap"),
            new Item(10, "Packing tape"),
            new Item(11, "Safety equipment"),
            new Item(12, "Bar code scanners"),
            new Item(13, "Shipping labels"),
            new Item(14, "Mailing envelopes"),
            new Item(15, "Work gloves"),
            new Item(16, "Bungee cords"),
            new Item(17, "Storage racks"),
            new Item(18, "Shelving units"),
            new Item(19, "Loading dock equipment"),
            new Item(20, "Pallet jacks")
        };

        public TMP_Dropdown ItemDropdown;

        public List<string> CreateListOfNames()
        {
            var res = new List<string>();
            foreach (var item in items)
            {
                res.Add(item.name);
            }
            return res;
        }

        // Start is called before the first frame update
        void Start()
        {
            var DropOptions = CreateListOfNames();
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

    public class Item
    {
        public int id;
        public string name;
        public int xPos;
        public int yPos;
        public int zPos;

        public Item(int Id, string Name)
        {
            var random = new System.Random();
            id = Id;
            name = Name;
            xPos = random.Next(1, 500);
            yPos = random.Next(1, 500);
            zPos = random.Next(1, 500);
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
}