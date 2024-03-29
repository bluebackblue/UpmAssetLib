

/** BlueBack.AssetLib.Samples.Scene.Editor
*/
namespace BlueBack.AssetLib.Samples.Scene.Editor
{
	/** MenuItem
	*/
	#if(UNITY_EDITOR)
	public static class MenuItem
	{
		/** OpenSceneFromAssetsPath
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.AssetLib/Scene/OpenSceneFromAssetsPath_1")]
		private static void MenuItem_OpenSceneFromAssetsPath_1()
		{
			string t_path = BlueBack.AssetLib.Editor.FindFileWithAssetsPath.FindFirst("Samples",".*","^TestScene1\\.unity$");
			BlueBack.AssetLib.Editor.OpenSceneFromAssetsPath.Open(t_path,UnityEditor.SceneManagement.OpenSceneMode.Single);
		}

		/** OpenSceneFromAssetsPath
		*/
		[UnityEditor.MenuItem("Samples/BlueBack.AssetLib/Scene/OpenSceneFromAssetsPath_2")]
		private static void MenuItem_OpenSceneFromAssetsPath_2()
		{
			string t_path = BlueBack.AssetLib.Editor.FindFileWithAssetsPath.FindFirst("Samples",".*","^TestScene2\\.unity$");
			BlueBack.AssetLib.Editor.OpenSceneFromAssetsPath.Open(t_path,UnityEditor.SceneManagement.OpenSceneMode.Single);
		}
	}
	#endif
}

