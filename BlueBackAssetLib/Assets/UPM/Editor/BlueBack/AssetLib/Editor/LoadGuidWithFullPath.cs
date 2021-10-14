﻿

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief ＧＵＩＤロード。フルパス。
*/


/** BlueBack.AssetLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.AssetLib.Editor
{
	/** LoadGuidWithFullPath
	*/
	public static class LoadGuidWithFullPath
	{
		/** ロード。

			a_full_path_with_extention		: フルパス。拡張子付き。
			a_encoding						: 文字列エンコード。

		*/
		public static string Load(string a_full_path_with_extention,System.Text.Encoding a_encoding)
		{
			string t_string = LoadTextWithFullPath.LoadNoBomUtf8(a_full_path_with_extention);
			return LoadGuidWithMetaString.Load(t_string);
		}

		/** ロード。

			a_full_path_with_extention		: フルパス。拡張子付き。
			a_encoding						: 文字列エンコード。

		*/
		public static MultiResult<bool,string> TryLoad(string a_full_path_with_extention,System.Text.Encoding a_encoding)
		{
			#pragma warning disable 0168
			try{
				return new MultiResult<bool,string>(true,Load(a_full_path_with_extention,a_encoding));
			}catch(System.IO.FileNotFoundException t_exception){
				return new MultiResult<bool,string>(false,null);
			}catch(System.IO.IOException t_exception){
				#if(DEF_BLUEBACK_ASSETLIB_ASSERT)
				DebugTool.Assert(false,t_exception);
				#endif
				return new MultiResult<bool,string>(false,null);
			}catch(System.Exception t_exception){
				#if(DEF_BLUEBACK_ASSETLIB_ASSERT)
				DebugTool.Assert(false,t_exception);
				#endif
				return new MultiResult<bool,string>(false,null);
			}
			#pragma warning restore
		}
	}
}
#endif
