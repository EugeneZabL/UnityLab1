using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public void RestartScene()
    {
        // Отримуємо індекс поточної сцени
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Завантажуємо поточну сцену за її індексом
        SceneManager.LoadScene(currentSceneIndex);
    }
}
