using BQ.Runtime.Shared;
using UnityEngine;

public class BugQuestAPI : MonoBehaviour
{
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
    public static void Disable()
    {
        BugQuest.Disable();
    }
}
