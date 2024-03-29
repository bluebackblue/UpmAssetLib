

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ディレクトリ作成。アセットパス。
*/


/** BlueBack.AssetLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.AssetLib.Editor
{
	/** CreateDirectoryWithAssetsPath
	*/
	public static class CreateDirectoryWithAssetsPath
	{
		/** 作成。

			a_assets_path					: 「Assets」からの相対パス。

		*/
		public static System.IO.DirectoryInfo Create(string a_assets_path)
		{
			return CreateDirectoryWithFullPath.Create(AssetLib.application_data_path + '\\' + a_assets_path);
		}

		/** 作成。

			a_assets_path					: 「Assets」からの相対パス。
			return == true					: 成功。

		*/
		public static MultiResult<bool,System.IO.DirectoryInfo> TryCreate(string a_assets_path)
		{
			#pragma warning disable 0168
			try{
				return new MultiResult<bool,System.IO.DirectoryInfo>(true,Create(a_assets_path));
			}catch(System.IO.IOException t_exception){
				//ＩＯエラー。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return new MultiResult<bool,System.IO.DirectoryInfo>(false,null);
			}catch(System.Exception t_exception){
				//エラー。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return new MultiResult<bool,System.IO.DirectoryInfo>(false,null);
			}
			#pragma warning restore
		}
	}
}
#endif

