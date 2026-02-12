using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class MediaScript : MonoBehaviour
{
    public GameObject VideoCube, ImageCube;
    public Button Nextbtn, Prevbtn, Playbtn, Pausebtn;
    public Texture[] Images;
    private VideoPlayer Video;
    private Renderer cubeRenderer;
    private int currentImageIndex = 0;

    void Start()
    {
        Video = VideoCube.GetComponent<VideoPlayer>();
        cubeRenderer = ImageCube.GetComponent<Renderer>();
        if (Images.Length > 0)
        {
            cubeRenderer.material.mainTexture = Images[currentImageIndex];
        }
    }

    private void Update()
    {
        if (VideoCube.activeSelf)
        {
            Nextbtn.gameObject.SetActive(false);
            Prevbtn.gameObject.SetActive(false);
            Playbtn.gameObject.SetActive(true);
            Pausebtn.gameObject.SetActive(true);
        }
        else if (ImageCube.activeSelf)
        {   
            Playbtn.gameObject.SetActive(false);
            Pausebtn.gameObject.SetActive(false);
            Nextbtn.gameObject.SetActive(true);
            Prevbtn.gameObject.SetActive(true);
        }
    }
    public void Next()
    {
            if (Images.Length > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % Images.Length;
                cubeRenderer.material.mainTexture = Images[currentImageIndex];
            }
    }

    public void Prev()
    {
            if (Images.Length > 0)
            {
                currentImageIndex = (currentImageIndex - 1) % Images.Length;
                cubeRenderer.material.mainTexture = Images[currentImageIndex];
            }
    }

    public void PlayVideo()
    {
        Video.Play();
    }
    public void PauseVideo()
    {
        Video.Pause();
    }
}
