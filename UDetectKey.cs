#region Librerias
using UnityEngine;
using System;
#endregion

namespace MoonAntonio
{
	public class UDetectKey : MonoBehaviour 
	{
  		private void Update()
		  {
			    DeteccionTeclaBtnPresionada();
		  }

		  public void DeteccionTeclaBtnPresionada()
		  {
			foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
			{
				  if (Input.GetKeyDown(kcode)) Debug.Log("KeyCode down: " + kcode);
			}
		}
  }
}