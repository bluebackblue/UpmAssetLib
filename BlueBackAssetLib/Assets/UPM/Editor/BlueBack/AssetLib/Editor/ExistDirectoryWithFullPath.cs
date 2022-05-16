

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ディレクトリ存在チェック。フルパス。
*/


/** BlueBack.AssetLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.AssetLib.Editor
{
	/** ExistDirectoryWithFullPath
	*/
	public static class ExistDirectoryWithFullPath
	{
		/** チェック。

			a_full_path						: フルパス。
			return == true					: 存在する。

		*/
		public static bool Check(string a_full_path)
		{
			return System.IO.Directory.Exists(a_full_path);
		}
	}
}
#endif

