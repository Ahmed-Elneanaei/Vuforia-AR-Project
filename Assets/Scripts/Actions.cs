using UnityEngine;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour
{
    public void GotoSeventh()                 //if player presses View button
    {
        SceneManager.LoadScene("7thScene");   //go to 7th scene
    }
    public void GotoTwelfthFirst()            //if player presses Equip button
    {
        SceneManager.LoadScene("12thScene_1");//go to 12th_1 scene
    }
    public void GotoTwelfthSecond()           //if player presses Meet button
    {
        SceneManager.LoadScene("12thScene_2");//go to 12th_@ scene
    }
    public void GotoAbout()                   //if player presses About button
    {
        SceneManager.LoadScene("AboutScene"); //go to About scene
    }
    public void ExitGame()                    //if player presses Exit button
    {
        Application.Quit();                   //quit application
    }
    public void ReturntoMenu()                //if player presses Menu Button
    {
        SceneManager.LoadScene("MainMenu");   //go to Main Menu Scene
    }
}
