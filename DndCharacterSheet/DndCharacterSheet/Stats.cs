using System;

public class Stats
{
	private byte strength { get; set; }
	private byte dexterity { get; set; }
	private byte constitution { get; set; }
	private byte wisdom { get; set; }
	private byte intelligence { get; set; }
	private byte charisma { get; set; }

	public sbyte getMod(int stat)
	{
		/*if (stat <= 1)
		{
			return -5;
		}
		else if (stat <= 3)
		{
			return -4;
		}
		else if (stat <= 5)
		{
			return -3;
		}
		else if (stat <= 7)
		{
			return -2;
		}
		else if (stat <= 9)
		{
			return -1;
		}
		else if (stat <= 11)
		{
			return 0;
		}
		else if (stat <= 13)
		{
			return 1;
		}
		else if (stat <= 15)
		{
			return 2;
		}
		else if (stat <= 17)
		{
			return 3;
		}
		else if (stat <= 19)
		{
			return 4;
		}
		else if (stat <= 21)
		{
			return 5;
		}
		else if (stat <= 23)
		{
			return 6;
		}
		else if (stat <= 25)
		{
			return 7;
		}
		else if (stat <= 27)
		{
			return 8;
		}
		else if (stat <= 29)
		{
			return 9;
		}
		else if (stat <= 30)
		{
			return 10;
		}
		else
		{
			return 11;
		}*/
		return Convert.ToSByte((stat - stat % 2 - 10)/2);
	}
}