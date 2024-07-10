using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

namespace Hive.Unity.Editor {

	[InitializeOnLoad]
	public class LoginDataEntryPoint {
		static LoginDataEntryPoint() {
			EditorApplication.playModeStateChanged += OnPlayModeChange;//2017.2+
		}

		private static void OnPlayModeChange(PlayModeStateChange state){
			if(EditorApplication.isPlayingOrWillChangePlaymode) {
				//v4 data setting
				hive.HIVEUnityPlugin.AuthV4LoginData.playerId = AuthV4LoginData.playerId;
				hive.HIVEUnityPlugin.AuthV4LoginData.playerName = AuthV4LoginData.playerName;
				hive.HIVEUnityPlugin.AuthV4LoginData.playerImageUrl = AuthV4LoginData.playerImageUrl;
				hive.HIVEUnityPlugin.AuthV4LoginData.playerToken = AuthV4LoginData.playerToken;
				hive.HIVEUnityPlugin.AuthV4LoginData.did = AuthV4LoginData.did;
			}
		}
	}

	public class AuthV4LoginData {
		private enum HiveEditorPrefsKey {
			playerId = 0,
			playerName,
			playerImageUrl,
			playerToken,
			did,
		};

		static private string hiveIdentifier = "com.hive.unity.editor.prefs.";
		static private string[] hiveEditorPrefsKeyString = {
			hiveIdentifier + "authv4.player.id",
			hiveIdentifier + "authv4.player.name",
			hiveIdentifier + "authv4.player.image.url",
			hiveIdentifier + "authv4.player.token",
			hiveIdentifier + "authv4.did"
		};

		static public long playerId {
			get {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerId];
				return long.Parse(EditorPrefs.GetString(key,"0"));
			}
			internal set {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerId];
				EditorPrefs.SetString(key, value.ToString());
			}
		}
		static private string defaultPlayerName = "AuthV4LoginSimulatorPlayer";
		static public string playerName {
			get {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerName];
				var value = FromBase64(EditorPrefs.GetString(key, ""));
				if (string.IsNullOrEmpty(value)) return defaultPlayerName;
				else return value;
			}
			internal set {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerName];
				EditorPrefs.SetString(key,ToBase64(value));
			}
		}
		static private string defaultPlayerImageUrl = "https://sandbox-hive-fn.qpyou.cn/hubweb/avatar_img/public/noimage.png";
		static public string playerImageUrl {
			get {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerImageUrl];
				var value = FromBase64(EditorPrefs.GetString(key,""));
				if (string.IsNullOrEmpty(value)) return defaultPlayerImageUrl;
				else return value;
			}
			internal set {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerImageUrl];
				EditorPrefs.SetString(key,ToBase64(value));
			}
		}
		static public string playerToken {
			get {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerToken];
				return FromBase64(EditorPrefs.GetString(key,""));
			}
			internal set {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.playerToken];
				EditorPrefs.SetString(key,ToBase64(value));
			}
		}
		static public string did {
			get {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.did];
				return FromBase64(EditorPrefs.GetString(key,""));
			}
			internal set {
				var key = hiveEditorPrefsKeyString[(int)HiveEditorPrefsKey.did];
				EditorPrefs.SetString(key,ToBase64(value));
			}
		}
		static string ToBase64 (string s){
			return System.Convert.ToBase64String (UTF8Encoding.UTF8.GetBytes (s));
		}

		static string FromBase64 (string s){
			return UTF8Encoding.UTF8.GetString (System.Convert.FromBase64String (s));
		}
	}

	public abstract class LoginDataEditor : EditorWindow {
		enum LoginSimulatorVersion {
			AUTHV4
		}

		[MenuItem("Hive/LoginSimulator/Open AuthV4 Setting")]
		static public void OpenAuthV4LoginSimulatorSetting() {
			OpenLoginSimulatorSetting(LoginSimulatorVersion.AUTHV4);
		}

		static void OpenLoginSimulatorSetting(LoginSimulatorVersion version) {
			EditorWindow w;
			switch(version) {
				case LoginSimulatorVersion.AUTHV4:
					w = EditorWindow.GetWindow(typeof(AuthV4LoginDataEditor),true,"Login Simulator Setting (AuthV4)");
					break;
				default:
					w = null;
					break;
			}
			if(w != null)
				w.Show();		
		}

		protected abstract void CreateButton();
		
		protected void UseOnlySandboxServerWarring() {
			EditorGUILayout.HelpBox("This feature use only sandbox server",MessageType.Warning);
		}

		// protected abstract void SaveLoginData();
	}

	public class AuthV4LoginDataEditor : LoginDataEditor {

		string appId = "";
		string hiveCertificationKey = "";

		void Awake() {

		}

		void OnGUI() {
			EditorGUILayout.BeginVertical();

			UseOnlySandboxServerWarring();
			EditorGUILayout.LabelField("Input: ");
			drawAppId(ref appId);
			drawCertificationKey(ref hiveCertificationKey);
			CreateButton();

			EditorGUILayout.LabelField("Output: ");
			EditorGUILayout.LongField("playerId",AuthV4LoginData.playerId);
			EditorGUILayout.TextField("playerName",AuthV4LoginData.playerName);
			EditorGUILayout.TextField("playerImageUrl",AuthV4LoginData.playerImageUrl);
			EditorGUILayout.TextField("playerToken",AuthV4LoginData.playerToken);
			EditorGUILayout.TextField("did",AuthV4LoginData.did);

			EditorGUILayout.EndVertical();
		}

		private void drawAppId(ref string value) {

			var title = "App Id: ";
			var warningMessage = "Check your platform's hive_config.xml <appId>.";

			switch (EditorUserBuildSettings.activeBuildTarget) {
				case BuildTarget.iOS:
					value = HiveConfigXML.iOS.HIVEAppID;
					break;
				case BuildTarget.Android:
					value = HiveConfigXML.Android.HIVEAppID;
					break;
				case BuildTarget.StandaloneOSX:
					value = HiveConfigXML.macOS.HIVEAppID;
					break;
				case BuildTarget.StandaloneWindows:
					value = HiveConfigXML.Windows.HIVEAppID;
					break;
				default:
					break;
			}

			
			if (string.IsNullOrEmpty(value)) {
				EditorGUILayout.TextField (title, warningMessage);
			} else {
				EditorGUILayout.TextField (title, value);
			}
		}

		private void drawCertificationKey(ref string value) {
			var title = "Hive Certification Key: ";
			value = EditorGUILayout.TextField(title, value);
		}

        protected override void CreateButton()
        {
            if(GUILayout.Button("Create")){
				// SaveLoginData();
				LoginSimulatorNetwork.Instance.requestSignIn(appId, hiveCertificationKey, (signInResponse) => {
					AuthV4LoginData.playerId = signInResponse.playerId;
					AuthV4LoginData.playerToken = signInResponse.authorization;
					AuthV4LoginData.did = signInResponse.did.ToString();
				});
			}
        }
    }
}