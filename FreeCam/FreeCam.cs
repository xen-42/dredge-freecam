using UnityEngine;
using Winch.Core;

namespace FreeCam
{
	public class FreeCam : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(FreeCam)} has loaded!");
		}

		public void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha0))
			{
				GameObject.FindObjectOfType<DebugFreeCam>().EnableAfterDelay();
			}
		}
	}
}
