using UnityEngine;

public class Menu_2 : MonoBehaviour
{
    public GameObject[] gameObjects;
    private int counter = 0;

    public void Next()
    {
        counter++;
        if (counter == gameObjects.Length)
        {
            counter = 0;
        }
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
        gameObjects[counter].SetActive(true);
    }

    public void Prev()
    {
        counter--;
        if (counter == -1)
        {
            counter = gameObjects.Length-1;
        }
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
        gameObjects[counter].SetActive(true);
    }
}
