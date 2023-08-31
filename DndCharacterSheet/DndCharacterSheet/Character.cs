using DndCharacterSheet.StatsClient.Stats.Contracts;
using System;

/// <summary>
/// Contains level, stats, xp, hp rolls, hp, speed, size, age, language, and class(es)
/// </summary>
public class Character
{
	//Level related
	private sbyte levelTotal;
	private Race race;
	private sbyte[] xp;
	private sbyte[] hpRolls;
	private short hp;
	private sbyte speed;
	private enum Size { };
	private short age;
	private string[] languages;
	private Dictionary<string, sbyte> classes;
	// Character stats

	public Character(Race race, Stat str, Stat dex,)
	{
		this.race = race;
		this.
		// TODO: constructor
	}
}
