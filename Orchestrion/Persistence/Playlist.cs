﻿using System.Collections.Generic;

namespace Orchestrion.Persistence;

public class Playlist
{
	public string Name { get; set; }
	public List<int> Songs { get; set; }
	public RepeatMode RepeatMode { get; set; }
	public ShuffleMode ShuffleMode { get; set; }
	
	public Playlist() { }
	
	public Playlist(string name)
	{
		RepeatMode = RepeatMode.All;
		ShuffleMode = ShuffleMode.Off;
		
		Name = name;
		Songs = new List<int>();
	}
	
	public Playlist(string name, List<int> songs) : this(name)
	{
		Songs = songs;
	}

	public void GetNextSong()
	{
		
	}
}