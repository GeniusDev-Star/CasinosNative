﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using System;
using System.Collections.Generic;
using System.Reflection;


namespace XLua.CSObjectWrap
{
    public class XLua_Gen_Initer_Register__
	{
	    static XLua_Gen_Initer_Register__()
        {
		    XLua.LuaEnv.AddIniter((luaenv, translator) => {
			    
				translator.DelayWrapLoader(typeof(UnityEngine.ApplicationInstallMode), UnityEngineApplicationInstallModeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ApplicationSandboxType), UnityEngineApplicationSandboxTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CameraType), UnityEngineCameraTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.CameraClearFlags), UnityEngineCameraClearFlagsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.NetworkReachability), UnityEngineNetworkReachabilityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.RuntimePlatform), UnityEngineRuntimePlatformWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SystemLanguage), UnityEngineSystemLanguageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ThreadPriority), UnityEngineThreadPriorityWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Application), UnityEngineApplicationWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngineAssetBundleWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioClip), UnityEngineAudioClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.AudioSource), UnityEngineAudioSourceWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Camera), UnityEngineCameraWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color), UnityEngineColorWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Color32), UnityEngineColor32Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Coroutine), UnityEngineCoroutineWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Font), UnityEngineFontWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.GameObject), UnityEngineGameObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Hash128), UnityEngineHash128Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Material), UnityEngineMaterialWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mathf), UnityEngineMathfWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Matrix4x4), UnityEngineMatrix4x4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Mesh), UnityEngineMeshWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ParticleSystem), UnityEngineParticleSystemWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Ping), UnityEnginePingWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.PlayerPrefs), UnityEnginePlayerPrefsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Quaternion), UnityEngineQuaternionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Random), UnityEngineRandomWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Rect), UnityEngineRectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Renderer), UnityEngineRendererWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Resources), UnityEngineResourcesWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Screen), UnityEngineScreenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.ScreenCapture), UnityEngineScreenCaptureWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngineSystemInfoWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Texture3D), UnityEngineTexture3DWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Time), UnityEngineTimeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Networking.UnityWebRequest), UnityEngineNetworkingUnityWebRequestWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector3), UnityEngineVector3Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector2), UnityEngineVector2Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.Vector4), UnityEngineVector4Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWW), UnityEngineWWWWrap.__Register);
				
				translator.DelayWrapLoader(typeof(UnityEngine.WWWForm), UnityEngineWWWFormWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.BitConverter), SystemBitConverterWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Array), SystemArrayWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Hashtable), SystemCollectionsHashtableWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<string>), SystemCollectionsGenericList_1_SystemString_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Collections.Generic.List<UnityEngine.AssetBundle>), SystemCollectionsGenericList_1_UnityEngineAssetBundle_Wrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Text.RegularExpressions.Regex), SystemTextRegularExpressionsRegexWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Text.RegularExpressions.Match), SystemTextRegularExpressionsMatchWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.Text.RegularExpressions.MatchCollection), SystemTextRegularExpressionsMatchCollectionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.IO.Directory), SystemIODirectoryWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.IO.File), SystemIOFileWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.IO.FileStream), SystemIOFileStreamWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.IO.MemoryStream), SystemIOMemoryStreamWrap.__Register);
				
				translator.DelayWrapLoader(typeof(System.IO.Path), SystemIOPathWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EaseType), FairyGUIEaseTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.RelationType), FairyGUIRelationTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.TweenPropType), FairyGUITweenPropTypeWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Container), FairyGUIContainerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Controller), FairyGUIControllerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.DisplayObject), FairyGUIDisplayObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EventContext), FairyGUIEventContextWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EventDispatcher), FairyGUIEventDispatcherWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.EventListener), FairyGUIEventListenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.InputEvent), FairyGUIInputEventWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GObject), FairyGUIGObjectWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GGraph), FairyGUIGGraphWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GGroup), FairyGUIGGroupWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GImage), FairyGUIGImageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLoader), FairyGUIGLoaderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GMovieClip), FairyGUIGMovieClipWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GTextField), FairyGUIGTextFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GRichTextField), FairyGUIGRichTextFieldWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GTextInput), FairyGUIGTextInputWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GComponent), FairyGUIGComponentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GList), FairyGUIGListWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GRoot), FairyGUIGRootWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GLabel), FairyGUIGLabelWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GButton), FairyGUIGButtonWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GComboBox), FairyGUIGComboBoxWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GObjectPool), FairyGUIGObjectPoolWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GProgressBar), FairyGUIGProgressBarWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GSlider), FairyGUIGSliderWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GTween), FairyGUIGTweenWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.GTweener), FairyGUIGTweenerWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Stage), FairyGUIStageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.PopupMenu), FairyGUIPopupMenuWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Relations), FairyGUIRelationsWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.ScrollPane), FairyGUIScrollPaneWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.TextFormat), FairyGUITextFormatWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Transition), FairyGUITransitionWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.TweenValue), FairyGUITweenValueWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.UIPackage), FairyGUIUIPackageWrap.__Register);
				
				translator.DelayWrapLoader(typeof(FairyGUI.Window), FairyGUIWindowWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Casinos.MbHelper), CasinosMbHelperWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Casinos.UiMain), CasinosUiMainWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Casinos.UiMgr), CasinosUiMgrWrap.__Register);
				
				translator.DelayWrapLoader(typeof(BuglyAgent), BuglyAgentWrap.__Register);
				
				translator.DelayWrapLoader(typeof(Casinos.LuaMgr), CasinosLuaMgrWrap.__Register);
				
				
				
			});
		}
		
		
	}
	
}
namespace XLua
{
	public partial class ObjectTranslator
	{
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ s_gen_reg_dumb_obj = new XLua.CSObjectWrap.XLua_Gen_Initer_Register__();
		static XLua.CSObjectWrap.XLua_Gen_Initer_Register__ gen_reg_dumb_obj {get{return s_gen_reg_dumb_obj;}}
	}
	
	internal partial class InternalGlobals
    {
	    
	    static InternalGlobals()
		{
		    extensionMethodMap = new Dictionary<Type, IEnumerable<MethodInfo>>()
			{
			    
			};
			
			genTryArrayGetPtr = StaticLuaCallbacks.__tryArrayGet;
            genTryArraySetPtr = StaticLuaCallbacks.__tryArraySet;
		}
	}
}
