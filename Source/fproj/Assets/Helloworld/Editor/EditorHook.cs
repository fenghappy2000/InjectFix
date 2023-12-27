


#if UNITY_EDITOR

using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;


using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.Build.Player;

using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace XPatch
{
	// 用来控制在build阶段只注入一次，每一个场景处理完之后
    public class XFixEditorPostScriptBuild : IPostBuildPlayerScriptDLLs
    {
		public int callbackOrder { get { return 1000; } }

		public void OnPostBuildPlayerScriptDLLs(BuildReport report)
		{
			Debug.LogFormat("XFixEditorPostScriptBuild: platform[{0}], outpath[{1}]", report.summary.platform, report.summary.outputPath);
		}
    }
}



#endif // UNITY_EDITOR


