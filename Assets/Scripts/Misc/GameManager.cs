using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int Health;
    public TextMeshProUGUI HealthText;
    internal bool isGameActive;

    void Start()
    {
        Health = 100;
        HealthText.text = ""+Health;
    }

    public void UpdateHealth(int Health)
    {
        HealthText.text = ""+Health;
    }
}
