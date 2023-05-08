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
            ItemDropdown.options.Add(new TMP_Dropdown.OptionData("Select an item to locate"));
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
        public Location location;

        public Item(int Id, string Name)
        {
            id = Id;
            name = Name;
            location = new Location();
        }

        public Item(int Id, string Name, double x, double y, double z)
        {
            id = Id;
            name = Name;
            location = new Location(x, y, z);
        }
    }

    public class Location
    {
        public double xPos;
        public double yPos;
        public double zPos;

        public Location()
        {
            var random = new System.Random();
            this.xPos = random.NextDouble();
            this.yPos = random.NextDouble();
            this.zPos = random.NextDouble();
        }
        public Location(double x, double y, double z)
        {
            this.xPos = x;
            this.yPos = y;
            this.zPos = z;
        }

        public string GetValue()
        {
            return $"{this.xPos}, {this.yPos}, {this.zPos}";
        }
    }
}