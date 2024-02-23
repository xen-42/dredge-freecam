﻿using UnityEngine;

namespace FreeCam
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(FreeCam));
			gameObject.AddComponent<FreeCam>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}