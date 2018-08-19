//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// BtnMenuCircular.cs (13/06/2017)												\\
// Autor: Antonio Mateo (Moon Antonio) 	antoniomt.moon@gmail.com				\\
// Descripcion:		Control del boton del menu circular							\\
// Fecha Mod:		16/06/2017													\\
// Ultima Mod:		Implementada funcionalidad animacion de botones.			\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;
#endregion

namespace MoonAntonio.UI
{
	/// <summary>
	/// <para>Control del boton del menu circular</para>
	/// </summary>
	[AddComponentMenu("Moon Antonio/UI/BtnMenuCircular")]
	public class BtnMenuCircular : MonoBehaviour , IPointerEnterHandler,IPointerExitHandler
	{
		#region Variables Publicas
		/// <summary>
		/// <para>Velocidad de animacion de los botones.</para>
		/// </summary>
		public float velAnimacion = 0.8f;					// Velocidad de animacion de los botones
		#endregion

		#region Actualizadores
		/// <summary>
		/// <para>Inicio de animacion de los botones.</para>
		/// </summary>
		/// <returns></returns>
		private IEnumerator AnimacionBotonesIn()// Inicio de animacion de los botones
		{
			// Asignacion de variables
			transform.localScale = Vector3.zero;
			float timer = 0.0f;

			// Bucle
			while (timer < (1 / velAnimacion))
			{
				// Animacion
				timer += Time.deltaTime;
				transform.localScale = Vector3.one * timer * velAnimacion;
				yield return null;
			}
			// Reseteo
			transform.localScale = Vector3.one;
		}
		#endregion
	}
}