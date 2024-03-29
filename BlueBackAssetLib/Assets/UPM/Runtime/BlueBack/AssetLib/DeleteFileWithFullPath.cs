

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief ファイル削除。フルパス。
*/


/** BlueBack.AssetLib
*/
namespace BlueBack.AssetLib
{
	/** DeleteFileWithFullPath
	*/
	public static class DeleteFileWithFullPath
	{
		/** 削除。

			a_full_path_with_extention		: フルパス。拡張子付き。

		*/
		public static bool Delete(string a_full_path_with_extention)
		{
			System.IO.File.Delete(a_full_path_with_extention);
			return true;
		}

		/** 削除。

			a_full_path_with_extention		: フルパス。拡張子付き。
			returns == true					: 成功。

		*/
		public static bool TryDelete(string a_full_path_with_extention)
		{
			#pragma warning disable 0168
			try{
				return Delete(a_full_path_with_extention);
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

