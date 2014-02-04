using UnityEngine;
using System.Collections;

public class Item_Class : MonoBehaviour {



	// Item Textures
	public static Texture2D stickIcon = (Texture2D) Resources.Load ("Textures/Stick_IMG");
	public static Texture2D stringIcon = (Texture2D) Resources.Load ("Textures/String");
	public static Texture2D boxIcon = (Texture2D) Resources.Load ("Textures/Box");
	public static Texture2D ropeIcon;
	public static Texture2D rockIcon = (Texture2D) Resources.Load ("Textures/Rock");
	public static Texture2D knifeIcon;
	public static Texture2D needleIcon;
	public static Texture2D balloonIcon;
	public static Texture2D cbatteryIcon;
	public static Texture2D wheelIcon;
	public static Texture2D hangerIcon;
	public static Texture2D alcoholIcon;
	public static Texture2D nullIcon;

	// Trap Textures
	public static Texture2D boxTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/Box_Trap");
	public static Texture2D bowIcon;

	// Items
	public ItemClass nullItem = new ItemClass(0, 0, "null", nullIcon, "null");
	public ItemClass stick_r = new ItemClass(1, 0, "Stick", stickIcon, "Can be used to make traps");
	public ItemClass string_r = new ItemClass(2, 0, "String", stringIcon, "Can be used to make traps");
	public ItemClass box_r = new ItemClass(3, 0, "Box", boxIcon, "Can be used to make traps");
	public ItemClass rope_r = new ItemClass(4, 0, "Rope", ropeIcon, "Can be used to make traps");
	public ItemClass rock_r = new ItemClass(5, 0, "Rock", rockIcon, "Can be used to make traps");
	public ItemClass knife_r = new ItemClass(6, 0, "Knife", knifeIcon, "Can be used to make traps");
	public ItemClass needle_r = new ItemClass(7, 0, "Needle", needleIcon, "Can be used to make traps");
	public ItemClass balloon_r = new ItemClass(8, 0, "Balloon", balloonIcon, "Can be used to make traps");
	public ItemClass cbattery_r = new ItemClass(9, 0, "Car Battery", cbatteryIcon, "Can be used to make traps");
	public ItemClass wheel_r = new ItemClass(10, 0, "Wheel", wheelIcon, "Can be used to make traps");
	public ItemClass hanger_r = new ItemClass(11, 0, "Clothes Hanger", hangerIcon, "Can be used to make traps");
	public ItemClass alcohol_r = new ItemClass(12, 0, "Alcohol", alcoholIcon, "Can be used to make traps");

	// Traps
	public ItemClass boxTrap_c = new ItemClass(21, 1, "Box Trap", boxTrapIcon, "Traps prey under box");
	public ItemClass bow_c = new ItemClass(22, 2, "Bow", bowIcon, "Bow. Best used with arrows.");

	public class ItemClass
	{
		public int ItemID;
		public int baitID;
		public string name;
		public Texture2D icon;
		public string description;
		
		public ItemClass(int ItemIDe, int baitIDe, string name_e, Texture2D ico, string des)
		{
			ItemID = ItemIDe;
			baitID = baitIDe;
			name = name_e;
			icon = ico;
			description = des;
			
		}

		public ItemClass()
		{
			ItemID = 0;
			baitID = 0;
			name = null;
			icon = null;
			description = null;

		}
		
		
	}

	public string GetName()
	{
		return name;
	}

}
