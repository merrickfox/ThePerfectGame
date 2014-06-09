using UnityEngine;
using System.Collections;

public class Item_Class : MonoBehaviour {

	// Item Textures
	public static Texture2D stickIcon = (Texture2D) Resources.Load ("Textures/Stick_IMG");
	public static Texture2D stringIcon = (Texture2D) Resources.Load ("Textures/String");
	public static Texture2D boxIcon = (Texture2D) Resources.Load ("Textures/Box");
	public static Texture2D ropeIcon = (Texture2D) Resources.Load ("Textures/Rope");
	public static Texture2D rockIcon = (Texture2D) Resources.Load ("Textures/Rock");
	public static Texture2D knifeIcon = (Texture2D) Resources.Load ("Textures/Knife");
	public static Texture2D needleIcon = (Texture2D) Resources.Load ("Textures/Needle");
	public static Texture2D balloonIcon = (Texture2D) Resources.Load ("Textures/Balloon");
	public static Texture2D cbatteryIcon = (Texture2D) Resources.Load ("Textures/CarBattery");
	public static Texture2D wheelIcon = (Texture2D) Resources.Load ("Textures/BikeWheel");
	public static Texture2D hangerIcon = (Texture2D) Resources.Load ("Textures/Hanger");
	public static Texture2D alcoholIcon = (Texture2D) Resources.Load ("Textures/Alcohol");
	public static Texture2D leafIcon = (Texture2D) Resources.Load ("Textures/PileofLeaf");
	public static Texture2D springIcon = (Texture2D) Resources.Load ("Textures/Spring");
	public static Texture2D wireIcon = (Texture2D) Resources.Load ("Textures/Wire");
	public static Texture2D fishingRodIcon = (Texture2D) Resources.Load ("Textures/FishingRod");
	public static Texture2D netIcon = (Texture2D) Resources.Load ("Textures/net");
	public static Texture2D metalIcon = (Texture2D) Resources.Load ("Textures/scrapMetal");
	public static Texture2D nullIcon;

	// Trap Textures
	public static Texture2D boxTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/Box_Trap");
	public static Texture2D spikeTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/spiketrap");
	public static Texture2D bearTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/BearTrap");
	public static Texture2D cageTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/Cage");
	public static Texture2D snareTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/Snare");
	public static Texture2D RodIcon = (Texture2D)Resources.Load ("Textures/Traps/RodTrap");
	public static Texture2D electricHumanIcon = (Texture2D)Resources.Load ("Textures/Traps/ElectricTrap");
	public static Texture2D electricNetIcon = (Texture2D)Resources.Load ("Textures/Traps/ElectricNet");
	public static Texture2D balloonTrapIcon = (Texture2D)Resources.Load ("Textures/Traps/BalloonTrap");

	//Bait Textures
	public static Texture2D nutBaitIcon = (Texture2D)Resources.Load ("Textures/Bait/Nuts");
	public static Texture2D carrotsBaitIcon = (Texture2D)Resources.Load ("Textures/Bait/Carrot");
	public static Texture2D moneyBaitIcon = (Texture2D)Resources.Load ("Textures/Bait/DollarBill");
	public static Texture2D sextapeBaitIcon = (Texture2D)Resources.Load ("Textures/Bait/SexTape");
	public static Texture2D bookBaitIcon = (Texture2D)Resources.Load ("Textures/Bait/Book");
	public static Texture2D spiderBaitIcon = (Texture2D)Resources.Load ("Textures/Captures/spider");
	public static Texture2D squirrelBaitIcon= (Texture2D)Resources.Load ("Textures/Captures/squirrel");
	//public static Texture2D fishBaitIcon;
	public static Texture2D beaverBaitIcon = (Texture2D)Resources.Load ("Textures/Captures/beaver");
	public static Texture2D mouseBaitIcon= (Texture2D)Resources.Load ("Textures/Captures/mouse");
	public static Texture2D bearBaitIcon= (Texture2D)Resources.Load ("Textures/Captures/bear");
	public static Texture2D snakeIcon= (Texture2D)Resources.Load ("Textures/Captures/snake");
	public static Texture2D rabbitIcon= (Texture2D)Resources.Load ("Textures/Captures/rabbit");
	public static Texture2D deerIcon= (Texture2D)Resources.Load ("Textures/Captures/deer");
	public static Texture2D skunkIcon= (Texture2D)Resources.Load ("Textures/Captures/skunk");
	public static Texture2D hedgehogIcon= (Texture2D)Resources.Load ("Textures/Captures/hedgehog");
	public static Texture2D chickenIcon= (Texture2D)Resources.Load ("Textures/Captures/chicken");
	public static Texture2D owlIcon= (Texture2D)Resources.Load ("Textures/Captures/owl");
	public static Texture2D eagleIcon= (Texture2D)Resources.Load ("Textures/Captures/eagle");
	public static Texture2D pigeonIcon= (Texture2D)Resources.Load ("Textures/Captures/pigeon");
	public static Texture2D dogsIcon= (Texture2D)Resources.Load ("Textures/Captures/dog");
	public static Texture2D catsIcon= (Texture2D)Resources.Load ("Textures/Captures/cat");
	public static Texture2D lizardIcon= (Texture2D)Resources.Load ("Textures/Captures/lizard");
	public static Texture2D racoonIcon= (Texture2D)Resources.Load ("Textures/Captures/raccoon");
	public static Texture2D gothIcon= (Texture2D)Resources.Load ("Textures/Captures/goth");
	public static Texture2D mayorIcon= (Texture2D)Resources.Load ("Textures/Captures/mayor");
	public static Texture2D druggyIcon= (Texture2D)Resources.Load ("Textures/Captures/druggy");
	public static Texture2D whoreIcon= (Texture2D)Resources.Load ("Textures/Captures/whore");
	public static Texture2D priestIcon= (Texture2D)Resources.Load ("Textures/Captures/priest");
	public static Texture2D drunkIcon= (Texture2D)Resources.Load ("Textures/Captures/drunk");
	public static Texture2D homelessIcon= (Texture2D)Resources.Load ("Textures/Captures/homeless");
	public static Texture2D pharmacistIcon= (Texture2D)Resources.Load ("Textures/Captures/pharmacist");
	public static Texture2D bankerIcon= (Texture2D)Resources.Load ("Textures/Captures/banker");
	public static Texture2D binmanIcon= (Texture2D)Resources.Load ("Textures/Captures/binman");


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
	public ItemClass fishingRod_r = new ItemClass (16, 0, 0, "Broken Fishing Rod", fishingRodIcon, "A fishing rod with no string... Maybe I can use this to create a trap of some sort.", false);
	public ItemClass net_r = new ItemClass (17, 0, 0, "Net", netIcon, "A net, it is still in decent condition to catch weaker things in a trap.", false);
	public ItemClass scrapMetal_r = new ItemClass (18, 0, 0, "Scrap Metal", metalIcon, "This can be used to construct traps!", false);

	// Traps
	public ItemClass boxTrap_c = new ItemClass(0, 1, 0, "Box Trap", boxTrapIcon, "A simple box trap.", true);
	public ItemClass spikeTrap_c = new ItemClass(0, 2, 0, "Spike Trap", spikeTrapIcon, "A spike trap with a camouflage, ready to catch the unexpected", true);
	public ItemClass bearTrap_c = new ItemClass(0, 3, 0, "Bear Trap", bearTrapIcon, "A bear trap, can be used on more than just bears", true);
	public ItemClass cageTrap_c = new ItemClass(0, 4, 0, "Cage Trap", cageTrapIcon, "A cage which will catch anything that gets lured inside", true);
	public ItemClass snareTrap_c = new ItemClass(0, 5, 0, "Snare Trap", snareTrapIcon, "A snare camouflaged to catch and hold things.", true);
	public ItemClass Rod_c = new ItemClass(0, 6, 0, "Rod", RodIcon, "A sturdy Rod, time to reel in some poor homeless people", true);
	public ItemClass electricHuman_c = new ItemClass (0, 7, 0, "Electrify Human Trap", electricHumanIcon, "A electric trap, powerful enough to paralyse most things", true);
	public ItemClass electricNetTrap_c = new ItemClass (0, 8, 0, "Electric Net Trap", electricNetIcon, "Electric Net Trap", true);
	public ItemClass balloonTrap_c = new ItemClass (0, 9, 0, "Ballon Trap", balloonTrapIcon, "A balloon to the regular person, but what they don't know is it has a spider inside which can paralyse any unsuspecting prey", true);

	//Bait
	public ItemClass alcohol_b = new ItemClass(0, 0, 1, "Alcohol", alcoholIcon, "Ooooo, Alcohol... Must resist urge to drink, I can probably use this in a trap for a weak fool...",false);
	public ItemClass nuts_b = new ItemClass (0, 0, 2, "Nuts", nutBaitIcon, "Too bad I have a nut allergy, but maybe I can use it to lure something I can eat!", false);
	public ItemClass spider_b = new ItemClass (0, 0, 3, "Spider", spiderBaitIcon, "A spider... YUCK! Maybe I can use it in a trap!", false);
	public ItemClass squirrel_b = new ItemClass (0, 0, 4, "Squirrel", squirrelBaitIcon, "Aww a cute Squirrel. Maybe I can fool someone with it!", false);
	//public ItemClass fish_b = new ItemClass (0, 0, 5, "Fish", fishBaitIcon, "This fish has gone a little sour for me, maybe I can use it to capture something fresh!", false);
	public ItemClass beaver_b = new ItemClass (0, 0, 6, "Beaver", beaverBaitIcon, "This beaver was a pain to catch, but maybe I can get something more useful using it in a trap!", false);
	public ItemClass mouse_b = new ItemClass (0, 0, 7, "Mouse", mouseBaitIcon, "A cute little mouse, the perfect bait!", false);
	public ItemClass bear_b = new ItemClass (0, 0, 8, "Bear", bearBaitIcon, "A massive bear, what the hell am I going to do with this?!", false);
	public ItemClass carrots_b = new ItemClass (0, 0, 9, "Carrots", carrotsBaitIcon, "Hmm carrots, I can eat them, or I can use it to lure tastier things!", false);
	public ItemClass money_b = new ItemClass (0, 0, 10, "Money", moneyBaitIcon, "Pfft, Money. Usless to me... But maybe I can fool a fool!", false);
	public ItemClass sextape_b = new ItemClass (0, 0, 11, "Sextape", sextapeBaitIcon, "Oh a sextape, it seems important!", false);
	public ItemClass book_b = new ItemClass (0, 0, 12, "Lovecraft", bookBaitIcon, "Goths love Cthulu, maybe I can use this to trap some idgits!", false);
	public ItemClass snake_b = new ItemClass (0, 0, 13, "Snake", snakeIcon, "A snake, delicious to eat but maybe I can use it in a trap as a bait", false);
	public ItemClass rabbit_b = new ItemClass (0, 0, 14, "Rabbit", rabbitIcon, "A cute little rabbit, could be used in a trap as bait!", false);
	public ItemClass deer_b = new ItemClass (0, 0, 15, "Deer", deerIcon, "A deer, beautiful and majestic... maybe I can use it as bait", false);
	public ItemClass skunk_b = new ItemClass (0, 0, 16, "Skunk", skunkIcon, "A stinky, disgusting little creature... maybe I can use it as bait!", false);
	public ItemClass hedgehog_b = new ItemClass (0, 0, 17, "Hedgehog", hedgehogIcon, "A prickly little devil, maybe it can cause damage as bait!", false);
	public ItemClass chicken_b = new ItemClass (0, 0, 18, "Chicken", chickenIcon, "Chicken is delicious, but maybe I can lure something even tastier...", false);
	public ItemClass owl_b = new ItemClass (0, 0, 19, "Owl", owlIcon, "A hooting owl, it's noise could make good bait.", false);
	public ItemClass eagle_b = new ItemClass (0, 0, 20, "Eagle", eagleIcon, "A majestic bird, violent and proud. Great for bait on a trap!", false);
	public ItemClass pigeon_b = new ItemClass (0, 0, 21, "Pigeon", pigeonIcon, "A very basic bird, a very basic bait, but something nonetheless.", false);
	public ItemClass dog_b = new ItemClass (0, 0, 22, "Dog", dogsIcon, "A dog, loved by many. Will be great as bait!", false);
	public ItemClass cat_b = new ItemClass (0, 0, 23, "Cat", catsIcon, "A cat, loved by many. Will be great as bait!", false);
	public ItemClass lizard_b = new ItemClass (0, 0, 24, "Lizard", lizardIcon, "A sneaky little bugger, maybe I can use it as bait", false);
	public ItemClass goth_b = new ItemClass (0, 0, 25, "Goth", gothIcon, "Moody weirdo", false);
	public ItemClass mayor_b = new ItemClass (0, 0, 26, "Mayor", mayorIcon, "I run the town now", false);
	public ItemClass druggy_b = new ItemClass (0, 0, 27, "Drug User", druggyIcon, "He's better off in my inventory", false);
	public ItemClass whore_b = new ItemClass (0, 0, 28, "Whore", whoreIcon, "No more street walking for you! I kinda saved her", false);
	public ItemClass priest_b = new ItemClass (0, 0, 29, "Priest", priestIcon, "I feel closer to god already", false);
	public ItemClass drunk_b = new ItemClass (0, 0, 30, "Drunk", drunkIcon, "This guy was drunk and a danger to everyone", false);
	public ItemClass homeless_b = new ItemClass (0, 0, 31, "Homeless", homelessIcon, "He can either live in my stomach or someone elses", false);
	public ItemClass pharmacist_b = new ItemClass (0, 0, 32, "Pharmacist", pharmacistIcon, "For Science", false);
	public ItemClass banker_b = new ItemClass (0, 0, 33, "Banker", bankerIcon, "Money money money", false);
	public ItemClass binman_b = new ItemClass (0, 0, 34, "Binman", binmanIcon, "Who's cleaning up the streets now?", false);
	public ItemClass raccoon_b = new ItemClass (0, 0, 35, "Raccoon", racoonIcon, "A delicacy amongst the homeless", false);

	//public ItemClass snake_b = new ItemClass (0, 0, 12, "Lovecraft", bookBaitIcon, "Goths love Cthulu, maybe I can use this");



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
