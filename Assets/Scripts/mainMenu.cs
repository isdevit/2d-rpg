
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
  private GameObject player;
  
  
  public void startGame()
  {
    SceneManager.LoadScene("Town");
  }

  
  public void exitGame()
  {
    Application.Quit();
  }

  
  public void Test()
  {
    SceneManager.LoadScene("TestScene");
  }
}
