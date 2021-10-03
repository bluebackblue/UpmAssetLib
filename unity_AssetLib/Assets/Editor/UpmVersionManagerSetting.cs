

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief 設定。
*/


/** Editor
*/
#if(UNITY_EDITOR)
namespace Editor
{
	/** UpmVersionManagerSetting
	*/
	[UnityEditor.InitializeOnLoad]
	public static class UpmVersionManagerSetting
	{
		/** UpmVersionManagerSetting
		*/
		static UpmVersionManagerSetting()
		{
			//Object_RootUssUxml
			BlueBack.UpmVersionManager.Editor.Object_RootUssUxml.CreateFile(false);

			BlueBack.UpmVersionManager.Editor.Object_Setting.CreateInstance();
			BlueBack.UpmVersionManager.Editor.Object_Setting.Param t_param = new BlueBack.UpmVersionManager.Editor.Object_Setting.Param();
			{
				//author_name
				t_param.author_name = "BlueBack";

				//author_url
				t_param.author_url = "https://github.com/bluebackblue";

				//■package_name
				t_param.package_name = "AssetLib";

				//■getpackageversion
				t_param.getpackageversion = BlueBack.AssetLib.Version.GetPackageVersion;

				//packagejson_unity
				t_param.packagejson_unity = "2020.1";

				//■packagejson_discription
				t_param.packagejson_discription = "アセット操作";

				//■packagejson_keyword
				t_param.packagejson_keyword = new string[]{
					"asset"
				};

				//■changelog
				t_param.changelog = new string[]{
					"# Changelog",
					"",

					/*
					"## [0.0.0] - 0000-00-00",
					"### Changes",
					"- Init",
					"",
					*/

					"## [0.0.1] - 2021-03-30",
					"### Changes",
					"- Init",
					"",
				};

				//■readme_md
				t_param.object_root_readme_md = new BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Type[]{

					//概要。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"# " + a_argument.param.author_name + "." + a_argument.param.package_name,
							"アセット操作",
							"* パッケージの作成",
							"* アセットバンドルの作成",
							"* プレハブ、アセット、テキストのセーブロード",
							"* テキストのエンコードデコード",
							"* ディレクトリの作成、削除",
							"* ファイル名、ディレクトリ名の列挙、検索",
							"* STLのセーブロード",
						};
					},

					//ライセンス。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## ライセンス",
							"MIT License",
							"* " + a_argument.param.author_url + "/" + a_argument.param.package_name + "/blob/main/LICENSE",
						};
					},

					//依存。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 外部依存 / 使用ライセンス等",
							//"* " + a_argument.param.author_url + "/" + "AssetLib",
							//"### サンプルのみ",
							//"* " + a_argument.param.author_url + "/" + "AssetLib",
						};
					},

					//動作確認。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 動作確認",
							"Unity " + UnityEngine.Application.unityVersion,
						};
					},

					//UPM。
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## UPM",
							"### 最新",
							"* " + a_argument.param.author_url + "/" + a_argument.param.package_name + ".git?path=unity_" + a_argument.param.package_name + "/Assets/UPM#" + a_argument.version,
							"### 開発",
							"* " + a_argument.param.author_url + "/" + a_argument.param.package_name + ".git?path=unity_" + a_argument.param.package_name + "/Assets/UPM",
						};
					},

					//インストール。 
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## Unityへの追加方法",
							"* Unity起動",
							"* メニュー選択：「Window->Package Manager」",
							"* ボタン選択：「左上の＋ボタン」",
							"* リスト選択：「Add package from git URL...」",
							"* 上記UPMのURLを追加「 https://github.com/～～/UPM#バージョン 」",
							"### 注",
							"Gitクライアントがインストールされている必要がある。",
							"* https://docs.unity3d.com/ja/current/Manual/upm-git.html",
							"* https://git-scm.com/",
						};
					},

					//例。
					#if(false)
					(in BlueBack.UpmVersionManager.Editor.Object_Setting.Creator_Argument a_argument) => {
						return new string[]{
							"## 例",
							"```",
							"```",
						};
					},
					#endif

				};
			}

			BlueBack.UpmVersionManager.Editor.Object_Setting.GetInstance().Set(t_param);
		}
	}
}
#endif
