

/**
	Copyright (c) blueback
	Released under the MIT License
	@brief バイナリロード。アセットパス。
*/


/** BlueBack.AssetLib.Editor
*/
#if(UNITY_EDITOR)
namespace BlueBack.AssetLib.Editor
{
	/** LoadBinaryWithAssetsPath
	*/
	public static class LoadBinaryWithAssetsPath
	{
		/** ロード。

			a_assets_path_with_extention	: 「Assets」からの相対バス。拡張子付き。
			return							: バイナリ。

		*/
		public static byte[] Load(string a_assets_path_with_extention)
		{
			return LoadBinaryWithFullPath.Load(AssetLib_Editor.GetApplicationDataPath() + '\\' + a_assets_path_with_extention);
		}

		/** ロード。

			a_assets_path_with_extention	: 「Assets」からの相対バス。拡張子付き。
			return							: バイナリ。

		*/
		public static MultiResult<bool,byte[]> TryLoad(string a_assets_path_with_extention)
		{
			#pragma warning disable 0168
			try{
				return new MultiResult<bool,byte[]>(true,Load(a_assets_path_with_extention));
			}catch(System.IO.IOException t_exception){
				#if(DEF_BLUEBACK_ASSETLIB_ASSERT)
				DebugTool.Assert(false,t_exception);
				#endif
				return new MultiResult<bool,byte[]>(false,null);
			}catch(System.Exception t_exception){
				#if(DEF_BLUEBACK_ASSETLIB_ASSERT)
				DebugTool.Assert(false,t_exception);
				#endif
				return new MultiResult<bool,byte[]>(false,null);
			}
			#pragma warning restore
		}

		/** ロード。

			a_assets_path_with_extention	: 「Assets」からの相対バス。拡張子付き。
			a_buffer						: バッファ。

			return.result == true			: 成功。
			return.value					: 読み込みサイズ。

		*/
		public static MultiResult<bool,int> LoadToBuffer(string a_assets_path_with_extention,byte[] a_buffer)
		{
			return LoadBinaryWithFullPath.LoadToBuffer(AssetLib_Editor.GetApplicationDataPath() + '\\' + a_assets_path_with_extention,a_buffer);
		}

		/** ロード。

			a_assets_path_with_extention	: 「Assets」からの相対バス。拡張子付き。
			a_buffer						: バッファ。

			return.result == true			: 成功。
			return.value					: 読み込みサイズ。

		*/
		public static MultiResult<bool,int> TryLoadToBuffer(string a_assets_path_with_extention,byte[] a_buffer)
		{
			#pragma warning disable 0168
			try{
				return LoadToBuffer(a_assets_path_with_extention,a_buffer);
			}catch(System.IO.IOException t_exception){
				#if(DEF_BLUEBACK_ASSETLIB_ASSERT)
				DebugTool.Assert(false,t_exception);
				#endif
				return new MultiResult<bool,int>(false,0);
			}catch(System.Exception t_exception){
				#if(DEF_BLUEBACK_ASSETLIB_ASSERT)
				DebugTool.Assert(false,t_exception);
				#endif
				return new MultiResult<bool,int>(false,0);
			}
			#pragma warning restore
		}
	}
}
#endif

