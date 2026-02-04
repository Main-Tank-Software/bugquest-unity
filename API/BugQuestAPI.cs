using BQ.Runtime.Shared;
using UnityEngine;

public class BugQuestAPI : MonoBehaviour
{
    public static bool StartVideoClip()
    {
        return BugQuest.Instance.Video.StartManualClip();
    }
    public static bool StopVideoClip()
    {
        return BugQuest.Instance.Video.StopManualClip();
    }

    public static bool IsVideoClipRecording()
    {
        return BugQuest.Instance.Video.IsManualClipRecording();
    }
    public static void Disable()
    {
        BugQuest.Disable();
    }
}
