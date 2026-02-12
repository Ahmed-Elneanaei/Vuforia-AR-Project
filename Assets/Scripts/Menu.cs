using UnityEngine;
using Vuforia;

public class Menu : MonoBehaviour
{
    public GameObject[] TW_Content, CP_Content;
    private string currentTargetName = "";

    void Start()
    {
        var observerBehaviours = FindObjectsByType<ObserverBehaviour>(FindObjectsSortMode.None);

        foreach (var observer in observerBehaviours)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
            if (observer.TargetStatus.Status == Status.TRACKED || observer.TargetStatus.Status == Status.EXTENDED_TRACKED)
            {
                currentTargetName = observer.TargetName;
            }
        }

    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            currentTargetName = behaviour.TargetName;
        }
        else if (targetStatus.Status == Status.NO_POSE)
        {
            if (currentTargetName == behaviour.TargetName)
            {
                currentTargetName = "";
            }
        }
    }

    public void ShowModel()
    {
        if (currentTargetName == "thewitcher3")
        {
            HideAllContentTW();
            TW_Content[0].SetActive(true);
        }
        else if (currentTargetName == "cyberpunk2077")
        {
            HideAllContentCP();
            CP_Content[0].SetActive(true);
        }
    }

    public void ShowVideoCube()
    {
        if (currentTargetName == "thewitcher3")
        {
            HideAllContentTW();
            TW_Content[1].SetActive(true);
        }
        else if (currentTargetName == "cyberpunk2077")
        {
            HideAllContentCP();
            CP_Content[1].SetActive(true);
        }

    }

    public void ShowSlideshowCube()
    {
        if (currentTargetName == "thewitcher3")
        {
            HideAllContentTW();
            TW_Content[2].SetActive(true);
        }
        else if (currentTargetName == "cyberpunk2077")
        {
            HideAllContentCP();
            CP_Content[2].SetActive(true);
        }
    }

    private void HideAllContentTW()
    {
        TW_Content[0].SetActive(false);
        TW_Content[1].SetActive(false);
        TW_Content[2].SetActive(false);
    }
    private void HideAllContentCP()
    {
        CP_Content[0].SetActive(false);
        CP_Content[1].SetActive(false);
        CP_Content[2].SetActive(false);
    }

    private void OnDestroy()
    {
        var observerBehaviours = FindObjectsByType<ObserverBehaviour>(FindObjectsSortMode.None);
        foreach (var observer in observerBehaviours)
        {
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }
}
