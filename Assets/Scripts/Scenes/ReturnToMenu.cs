using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class ReturnToMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
          SceneManager.LoadScene(0);
        }
    }
}
