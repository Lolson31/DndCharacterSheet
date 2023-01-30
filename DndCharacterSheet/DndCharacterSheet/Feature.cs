using System;

/// <summary>
/// A feature to be used by characters or races
/// </summary>
public class Feature
{
	private string description;
	private sbyte level;
	private string source;
	public enum ASIs { 
		Str = 0,
		Dex = 0,
		Con = 0,
		Int = 0,
		Wis = 0,
		Cha = 0
	}

	public Feature()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
