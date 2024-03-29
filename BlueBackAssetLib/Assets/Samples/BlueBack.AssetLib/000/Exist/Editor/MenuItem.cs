

/** BlueBack.AssetLib.Samples.Exist.Editor
*/
namespace BlueBack.AssetLib.Samples.Exist.Editor
{
	/** MenuItem
	*/
	#if(UNITY_EDITOR)
	public static class MenuItem
	{
		/** ExistDirectoryWithAssetsPath
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.AssetLib/Exist/ExistDirectoryWithAssetsPath")]
		private static void MenuItem_ExistDirectoryWithAssetsPath()
		{
			UnityEngine.Debug.Log("Samples : " + BlueBack.AssetLib.Editor.ExistDirectoryWithAssetsPath.Check("Samples").ToString());
		}

		/** ExistFileWithAssetsPath
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.AssetLib/Exist/ExistFileWithAssetsPath")]
		private static void MenuItem_ExistFileWithAssetsPath()
		{
			UnityEngine.Debug.Log("Samples.meta : " + BlueBack.AssetLib.Editor.ExistFileWithAssetsPath.Check("Samples.meta").ToString());
		}
	}
	#endif
}

