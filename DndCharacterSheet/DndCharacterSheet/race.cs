using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Race
{
	private string raceName;
	private string raceDescription;
	private List<string> proficiencies;
	private enum ASIs : sbyte {
		Str = 0,
		Dex = 0,
		Con = 0,
		Int = 0,
		Wis = 0,
		Cha = 0
	}
	private sbyte speed;
	private sbyte size;
	private List<string> languages;
	private List<string> resistances;
	private List<string> immunities;
	private string creatureType;
	// TODO: Implement feature once class is created

	public Race()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
