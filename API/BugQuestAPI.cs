using BQ.Runtime.Shared;
using UnityEngine;

public class BugQuestAPI : MonoBehaviour
{
    public static bool StartReplay(string replayLabel, int maxReplayDurationMinutes = int.MaxValue)
    {
        return BugQuest.Instance.Video.StartReplay(replayLabel, maxReplayDurationMinutes);
    }
    public static bool StopReplay(bool discardReplay = false)
    {
        return BugQuest.Instance.Video.StopReplay(discardReplay);
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
