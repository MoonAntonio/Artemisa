//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Singleton.cs (21/02/2017)                                               	    \\
// Autor: Antonio Mateo (Moon Pincho) 							                            \\
// Descripcion:     Singleton basico	 	 				            		                \\
// Fecha Mod:       21/02/2017                                                  \\
// Ultima Mod:      Version inicial         									                  \\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace MoonPincho
{
    public class Singleton : MonoBehaviour
    {
    	public static Singleton instance = null;

    	private void Awake()
    	{
    		if(instance == null)
    		{
    			instance = this;
    		}else if (instance != this)
    		{
    			Destroy(this.gameObject);
    		}

    		DontDestroyOnLoad(this.gameObject);
    	}
    }
}