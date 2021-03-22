using UnityEngine;
using UnityEngine.SceneManagement;

namespace Snake.MainMenu
{
  public class StartButton : MonoBehaviour
  {
    public void OnClick()
    {
      SceneManager.LoadScene("Game");
    }
  }
}
