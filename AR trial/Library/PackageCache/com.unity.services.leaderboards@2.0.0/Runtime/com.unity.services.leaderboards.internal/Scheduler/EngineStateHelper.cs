using System.Threading;
using UnityEditor;
using UnityEngine;

namespace Unity.Services.Leaderboards.Internal.Scheduler
{
    internal static class EngineStateHelper
    {
        public static bool IsPlaying;

        // On initialization, store all variables that are accessable only from the main thread.
#if UNITY_EDITOR
        [InitializeOnLoadMethod]
#endif
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Init()
        {
            IsPlaying = Application.isPlaying;
#if UNITY_EDITOR
            EditorApplication.playModeStateChanged += ModeChanged;
#endif
        }

#if UNITY_EDITOR
        static void ModeChanged(PlayModeStateChange playModeState)
        {
            if (playModeState == PlayModeStateChange.EnteredEditMode)
            {
                IsPlaying = false;
            }
            else if (playModeState == PlayModeStateChange.EnteredPlayMode)
            {
                IsPlaying = true;
            }
        }
#endif
    }
}
