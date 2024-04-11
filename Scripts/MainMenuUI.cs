using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button GlossaryButton;
    [SerializeField] private Button SettingsButton;

    private void Awake() {
        // PlayButton.onClick.AddListener(() => {
        //     SceneManager.LoadScene(int indexofScene);
        // });
    }
}
