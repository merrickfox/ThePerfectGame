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
	public static Texture2D leafIcon = (Texture2D) Resources.Load ("Textures/PileofLeaf");
	public static Texture2D springIcon;
	public static Texture2D wireIcon;
	public static Texture2D fishingRodIcon;
	public static Texture2D netIcon;
	public static Texture2D nullIcon;

	// Trap Textures
	public static Texture2D boxTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/Box_Trap");
	public static Texture2D spikeTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/spiketrap");
	public static Texture2D bearTrapIcon;
	public static Texture2D cageTrapIcon;
	public static Texture2D snareTrapIcon;
	public static Texture2D RodIcon;
	public static Texture2D electricHumanIcon;
	public static Texture2D electricNetIcon;
	public static Texture2D balloonTrapIcon;

	//Bait Textures
	public static Texture2D nutBaitIcon = (Texture2D)Resources.Load ("Textures/Nuts");
	public static Texture2D spiderBaitIcon;
	public static Texture2D squirrelBaitIcon;
	public static Texture2D fishBaitIcon;
	public static Texture2D beaverBaitIcon;
	public static Texture2D mouseBaitIcon;
	public static Texture2D bearBaitIcon;
	public static Texture2D carrotsBaitIcon;
	public static Texture2D moneyBaitIcon;
	public static Texture2D sextapeBaitIcon;
	public static Texture2D bookBaitIcon;

	// Items
	public ItemClass nullItem = new ItemClass(0, 0, 0, "null", nullIcon, "null",false);
	public ItemClass stick_r = new ItemClass(1, 0, 0, "Stick", stickIcon, "A sturdy stick. Looks like it can be used to create a trap!",false);
	public ItemClass string_r = new ItemClass(2, 0, 0, "String", stringIcon, "A piece of string. Looks like I can use this for a trap!",false);
	public ItemClass box_r = new ItemClass(3, 0, 0, "Box", boxIcon, "A box in perfect condition... Wow I'm lucky! Maybe it can be used to create a trap!",false);
	public ItemClass rope_r = new ItemClass(4, 0, 0, "Rope", ropeIcon, "A pretty decent sized rope, maybe I can use it to create a trap!",false);
	public ItemClass rock_r = new ItemClass(5, 0, 0, "Rock", rockIcon, "A rock. Hmm... maybe I can use this to create a trap!",false);
	public ItemClass knife_r = new ItemClass(6, 0, 0, "Knife", knifeIcon, "A pretty sharp knife, maybe I can use it to create a trap!",false);
	public ItemClass needle_r = new ItemClass(7, 0, 0, "Needle", needleIcon, "A needle, wow how did I spot this little thing. Maybe I can use this in a creative trap!",false);
	public ItemClass balloon_r = new ItemClass(8, 0, 0, "Balloon", balloonIcon, "A child's balloon... maybe I can fool someone using this...",false);
	public ItemClass cbattery_r = new ItemClass(9, 0, 0, "Car Battery", cbatteryIcon, "A car battery, still has a little bit of juice. I might be able to use this to shock something...",false);
	public ItemClass wheel_r = new ItemClass(10, 0, 0, "Wheel", wheelIcon, "Hmm a wheel... alone it's weak, but maybe if I can make a trap with it...",false);
	public ItemClass hanger_r = new ItemClass(11, 0, 0, "Clothes Hanger", hangerIcon, "A clothes hanger... what am I going to do with this! Actually, it might be good for a trap...",false);
	public ItemClass leaf_r = new ItemClass (13, 0, 0, "Leaf", leafIcon, "A leaf... useless on it's own... maybe I can use it for a trap as camouflage...", false);
	public ItemClass spring_r = new ItemClass (14, 0, 0, "Spring", springIcon, "A spring... Well maybe I can use it in a trap for something...", false);
	public ItemClass wire_r = new ItemClass (15, 0, 0, "Wire", wireIcon, "A strong piece of metal wire... This can be pretty useful in a trap.", false);
	public ItemClass fishingRod_r = new ItemClass (16, 0, 0, "Fishing Rod", fishingRodIcon, "A fishing rod with no string... Maybe I can use this to create a trap of some sort.", false);
	public ItemClass net_r = new ItemClass (17, 0, 0, "Net", netIcon, "A net, it is still in decent condition to catch weaker things in a trap.", false);

	// Traps
	public ItemClass boxTrap_c = new ItemClass(0, 1, 0, "Box Trap", boxTrapIcon, "A simple box trap.", true);
	public ItemClass spikeTrap_c = new ItemClass(0, 2, 0, "Spike Trap", spikeTrapIcon, "A spike trap with a camouflage, ready to catch the unexpected", true);
	public ItemClass bearTrap_c = new ItemClass(0, 3, 0, "Bear Trap", bearTrapIcon, "A bear trap, can be used on more than just bears", true);
	public ItemClass cageTrap_c = new ItemClass(0, 4, 0, "Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass snareTrap_c = new ItemClass(0, 5, 0, "Snare Trap", snareTrapIcon, "A snare camouflaged to catch and hold things.", true);
	public ItemClass Rod_c = new ItemClass(0, 6, 0, "Human Rod", RodIcon, "Dollar Bill Rod, time to reel in some poor homeless people", true);
	public ItemClass electricHuman_c = new ItemClass (0, 7, 0, "Electrify Human Trap", electricHumanIcon, "A electric trap, powerful enough to paralyse most things", true);
	public ItemClass electricNetTrap_c = new ItemClass (0, 8, 0, "Electric Net Trap", electricNetIcon, "Electric Net Trap", true);
	public ItemClass balloonTrap_c = new ItemClass (0, 9, 0, "Ballon Trap", balloonTrapIcon, "A balloon to the regular person, but what they don't know is it has a spider inside which can paralyse any unsuspecting prey", true);

	//Bait
	public ItemClass alcohol_r = new ItemClass(0, 0, 1, "Alcohol", alcoholIcon, "Ooooo, Alcohol... Must resist urge to drink, I can probably use this in a trap for a weak fool...",false);
	public ItemClass nuts_b = new ItemClass (0, 0, 2, "Nuts", nutBaitIcon, "Too bad I have a nut allergy, but maybe I can use it to lure something I can eat!", false);
	public ItemClass spider_b = new ItemClass (0, 0, 3, "Spider", spiderBaitIcon, "A spider... YUCK! Maybe I can use it in a trap!", false);
	public ItemClass squirrel_b = new ItemClass (0, 0, 4, "Squirrel", squirrelBaitIcon, "Aww a cute Squirrel. Maybe I can fool someone with it!", false);
	public ItemClass fish_b = new ItemClass (0, 0, 5, "Fish", fishBaitIcon, "This fish has gone a little sour for me, maybe I can use it to capture something fresh!", false);
	public ItemClass beaver_b = new ItemClass (0, 0, 6, "Beaver", beaverBaitIcon, "This beaver was a pain to catch, but maybe I can get something more useful using it in a trap!", false);
	public ItemClass mouse_b = new ItemClass (0, 0, 7, "Mouse", mouseBaitIcon, "A cute little mouse, the perfect bait!", false);
	public ItemClass bear_b = new ItemClass (0, 0, 8, "Bear", bearBaitIcon, "A massive bear, what the hell am I going to do with this?!", false);
	public ItemClass carrots_b = new ItemClass (0, 0, 9, "Carrots", carrotsBaitIcon, "Hmm carrots, I can eat them, or I can use it to lure tastier things!", false);
	public ItemClass money_b = new ItemClass (0, 0, 10, "Money", moneyBaitIcon, "Pfft, Money. Usless to me... But maybe I can fool a fool!", false);
	public ItemClass sextape_b = new ItemClass (0, 0, 11, "Sextape", sextapeBaitIcon, "Oh a sextape, it seems important!", false);
	public ItemClass book_b = new ItemClass (0, 0, 12, "Lovecraft", bookBaitIcon, "Goths love Cthulu, maybe I can use this to trap some idgits!", false);

	/*
	//Traps with Bait
	//Box Trap
	public ItemClass CarrotboxTrap_c = new ItemClass(50, 10, "Carrot Box Trap", boxTrapIcon, "A simple box trap with a carrot bait", true);
	public ItemClass FishboxTrap_c = new ItemClass(51, 11, "Fish Box Trap", boxTrapIcon, "A simple box trap with a fish bait", true);
	public ItemClass NutboxTrap_c = new ItemClass(52, 12, "Nut Box Trap", boxTrapIcon, "A simple box trap with a nut bait", true);
	public ItemClass SquirrelboxTrap_c = new ItemClass(53, 13, "Squirrel Box Trap", boxTrapIcon, "A simple box trap with a squirrel bait", true);
	public ItemClass BeaverboxTrap_c = new ItemClass(54, 14, "Beaver Box Trap", boxTrapIcon, "A simple box trap with a beaver bait", true);
	public ItemClass MouseboxTrap_c = new ItemClass(55, 15, "Mouse Box Trap", boxTrapIcon, "A simple box trap with a mouse bait", true);

	//Spike Trap
	public ItemClass FishspikeTrap_c = new ItemClass(56, 16, "Fish Spike Trap", spikeTrapIcon, "A spike trap with a camouflage, ready to catch the unexpected, stinks of fish", true);
	public ItemClass SpiderspikeTrap_c = new ItemClass(57, 17, "Spider Spike Trap", spikeTrapIcon, "A spike trap with a camouflage, ready to catch the unexpected, and just in case I'll throw in some spiders", true);

	//Bear Trap
	public ItemClass CarrotbearTrap_c = new ItemClass(58, 18, "Carrot Bear Trap", bearTrapIcon, "A bear trap, can be used on more than just bears, also with a lure of carrots for the hungry", true);
	public ItemClass MousebearTrap_c = new ItemClass(59, 19, "Mouse Bear Trap", bearTrapIcon, "A bear trap, can be used on more than just bears, also with a lure of mouse for the hungry", true);

	//Cage Trap
	public ItemClass NutscageTrap_c = new ItemClass(24, 4, "Nuts Cage Trap", cageTrapIcon, "A cage which will catch anything that is lured by the nuts", true);
	public ItemClass FishcageTrap_c = new ItemClass(24, 4, "Fish Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass MousecageTrap_c = new ItemClass(24, 4, "Mouse Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass CarrotscageTrap_c = new ItemClass(24, 4, "Carrots Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass MoneycageTrap_c = new ItemClass(24, 4, "Money Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass SextapecageTrap_c = new ItemClass(24, 4, "Sextape Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass BookcageTrap_c = new ItemClass(24, 4, "Book Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass AlcoholcageTrap_c = new ItemClass(24, 4, "Alcohol Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	*/
	public class ItemClass
	{
		public int ItemID;
		public int TrapID;
		public int baitID;
		public string name;
		public Texture2D icon;
		public string description;
		public bool isTrap;
		
		public ItemClass(int ItemIDe, int TrapIDe, int baitIDe, string name_e, Texture2D ico, string des, bool isTrapE)
		{
			ItemID = ItemIDe;
			TrapID = TrapIDe;
			baitID = baitIDe;
			name = name_e;
			icon = ico;
			description = des;
			isTrap = isTrapE;
			
		}

		public ItemClass()
		{
			ItemID = 0;
			TrapID = 0;
			baitID = 0;
			name = null;
			icon = null;
			description = null;
			isTrap = false;

		}
		
		
	}

	public string GetName()
	{
		return name;
	}

}
