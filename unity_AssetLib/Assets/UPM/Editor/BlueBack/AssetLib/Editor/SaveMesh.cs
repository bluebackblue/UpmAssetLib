

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief メッシュセーブ。
*/


/** BlueBack.AssetLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.AssetLib.Editor
{
	/** SaveMesh
	*/
	public class SaveMesh
	{
		/** メッシュセーブ。

			a_mesh							: メッシュ。
			a_assets_path_with_extention	: 「Assets」からの相対バス。拡張子付き。

		*/
		#if(UNITY_EDITOR)
		public static void SaveAsMeshToAssetsPath(UnityEngine.Mesh a_mesh,string a_assets_path_with_extention)
		{
			UnityEngine.Mesh t_new_mesh = UnityEngine.Object.Instantiate<UnityEngine.Mesh>(a_mesh);
			UnityEditor.AssetDatabase.CreateAsset(t_new_mesh,"Assets/" + a_assets_path_with_extention);
		}
		#endif
	}
}
#endif
