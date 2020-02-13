using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Enemy[] _enemies;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var enemy in _enemies)
        {
            if(enemy != null)
            {
                return;
            }
        }

        _nextLevelIndex++;
        Debug.Log("You Killed all enemies !");
        SceneManager.LoadScene($"Level{_nextLevelIndex}");
    }
}
