using BQ.Runtime.Shared;
using UnityEngine;

public class BugQuestAPI : MonoBehaviour
{
    public static void EnableErrorClips()
    {
        BugQuest.Instance.Video.EnableErrorClips();
    }
    public static void DisableErrorClips()
    {
        BugQuest.Instance.Video.DisableErrorClips();
    }
    public static bool StartReplay(string replayLabel, bool discardReplayOnMaxDurationTimeout = false, int maxReplayDurationMinutes = int.MaxValue)
    {
        return BugQuest.Instance.Video.StartReplay(replayLabel, discardReplayOnMaxDurationTimeout, maxReplayDurationMinutes);
    }
    public static bool StopReplay(bool discardReplay = false, string replaceLabel = null, int onlyKeepLastMinutes = int.MaxValue)
    {
        return BugQuest.Instance.Video.StopReplay(discardReplay, replaceLabel, onlyKeepLastMinutes);
    }

    public static bool IsReplayRecording()
    {
        return BugQuest.Instance.Video.IsReplayRecording();
    }
    public static void DisableAllVideoFeatures()
    {
        BugQuest.Instance.Video.DisableAllVideoFeatures();
    }
    public static void Disable()
    {
        BugQuest.Disable();
    }

    // Sends a user-submitted report (player feedback / bug report). The text is stored in the
    // report message field; optional attachment files (e.g. a screenshot) are uploaded with it.
    // The game is responsible for the UI that collects the text.
    public static void SendUserReport(string text, string[] attachmentPaths = null)
    {
        BugQuest.SendUserReport(text, attachmentPaths);
    }
}
