using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneName; // Поле для хранения имени перезапускаемой сцены

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EditorSceneManager.LoadScene(sceneName); // Перезапускаем сцену
        }
    }
}