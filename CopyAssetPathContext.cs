//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// Singleton.cs (21/02/2017)                                                    \\
// Autor: Antonio Mateo (Moon Pincho)                                           \\
// Descripcion:     Herramienta para copiar la ruta                             \\
// Fecha Mod:       21/02/2017                                                  \\
// Ultima Mod:      Version inicial                                             \\
//******************************************************************************\\

using UnityEngine;
using UnityEditor;

public static class CopyAssetPathContext
{

    [MenuItem("Assets/Copy Asset Path")]
    public static void CopyAssetPath()
    {
        if (Selection.activeObject != null)
        {
            string assetPath = AssetDatabase.GetAssetPath(Selection.activeObject);
            EditorGUIUtility.systemCopyBuffer = assetPath;
            Debug.Log("Copiado en Buffer:" + assetPath);
        }
        else
        {
            Debug.Log("Nada seleccionado.");
        }

    }
}