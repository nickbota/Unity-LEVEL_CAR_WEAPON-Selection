using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapUIDisplay : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private Text mapName;
    [SerializeField] private Text mapDescription;
    [SerializeField] private Image mapImage;
    [SerializeField] private Button playButton;
    [SerializeField] private GameObject lockedIcon;
    private int currentLevelIndex;

    public void UpdateMap(Map _newMap)
    {
        mapName.text = _newMap.mapName;
        mapName.color = _newMap.nameColor;
        mapDescription.text = _newMap.mapDescription;
        mapImage.sprite = _newMap.mapImage;

        bool mapUnlocked = PlayerPrefs.GetInt("currentScene", 0) >= _newMap.levelIndex;

        if (mapUnlocked)
            mapImage.color = Color.white;
        else
            mapImage.color = Color.gray;

        playButton.interactable = mapUnlocked;
        lockedIcon.SetActive(!mapUnlocked);
        currentLevelIndex = _newMap.levelIndex + 1;
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(currentLevelIndex);
    }
}