using System;

/// <summary>
/// Contains level, stats, xp, hp rolls, hp, speed, size, age, language, and class(es)
/// </summary>
public class Character
{
	private sbyte levelTotal;
	// TODO: Add race once the race class is created
	private sbyte[] xp;
	private sbyte[] hpRolls;
	private short hp;
	private sbyte speed;
	private enum Size { };
	private short age;
	private string[] languages;
	private Dictionary<string, sbyte> classes;

	public Character()
	{
		// TODO: constructor
	}
}
