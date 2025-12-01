using UnityEngine;
using UnityEngine.SceneManagement;
public class QuitController : MonoBehaviour
{
    public KeyCode Quit;
    public KeyCode Return;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        if (Input.GetKey(Quit))
        {
            Application.Quit();
        }
        
        if (Input.GetKey(Return))
        {
            SceneManager.LoadScene(0);
        }
    }
}
