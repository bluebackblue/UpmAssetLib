

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ファイル削除。アセットパス。
*/


/** BlueBack.AssetLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.AssetLib.Editor
{
	/** DeleteFileWithAssetsPath
	*/
	public static class DeleteFileWithAssetsPath
	{
		/** ファイル削除。

			a_assets_path_with_extention	: 「Assets」からの相対パス。拡張子付き。

		*/
		public static bool Delete(string a_assets_path_with_extention)
		{
			return DeleteFileWithFullPath.Delete(AssetLib.application_data_path + '\\' + a_assets_path_with_extention);
		}

		/** ファイル削除。

			a_assets_path_with_extention	: 「Assets」からの相対パス。拡張子付き。
			return == true					: 成功。

		*/
		public static bool TryDelete(string a_assets_path_with_extention)
		{
			#pragma warning disable 0168
			try{
				return Delete(a_assets_path_with_extention);
			}catch(System.IO.FileNotFoundException t_exception){
				//ファイルなし。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return false;
			}catch(System.IO.IOException t_exception){
				//ＩＯエラー。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return false;
			}catch(System.Exception t_exception){
				//エラー。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return false;
			}
			#pragma warning restore
		}
	}
}
#endif

