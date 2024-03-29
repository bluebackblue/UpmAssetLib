

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief テキストロード。
*/


/** BlueBack.AssetLib
*/
namespace BlueBack.AssetLib
{
	/** LoadGuidWithUrl
	*/
	public static class LoadGuidWithUrl
	{
		/** ロード。

			a_url							: URL
			a_post == null					: GET
			a_encoding						: 文字列エンコード。

		*/
		public static string Load(string a_url,System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> a_post)
		{
			return LoadGuidWithMetaString.Load(LoadTextWithUrl.Load(a_url,a_post));
		}

		/** ロード。

			a_url							: URL
			a_post == null					: GET
			a_encoding						: 文字列エンコード。

		*/
		public static MultiResult<bool,string> TryLoad(string a_url,System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> a_post)
		{
			#pragma warning disable 0168
			try{
				return new MultiResult<bool,string>(true,Load(a_url,a_post));
			}catch(System.IO.FileNotFoundException t_exception){
				//ファイルなし。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return new MultiResult<bool,string>(false,null);
			}catch(System.Exception t_exception){
				//エラー。
				#if(DEF_BLUEBACK_DEBUG_LOG)
				DebugTool.Log(string.Format("exception : {0}",t_exception));
				#endif
				return new MultiResult<bool,string>(false,null);
			}
			#pragma warning restore
		}
	}
}

