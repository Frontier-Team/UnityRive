using Rive.Components;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class AppController : MonoBehaviour
    {
        public static AppController Instance { get; private set; }

        [SerializeField] private Button faceTrackerButton;
        [SerializeField] private Button gameMenuButton;
        [SerializeField] private RivePanel gameMenu;
        [SerializeField] private RivePanel faceTrackerPanel;
        
        private void Awake()
        {
            SetupSingleton();
            SetButtonInteractivity();
        }

        private void SetupSingleton()
        {
            if (Instance)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            
        }

        public void OnFaceTrackButtonPressed()
        {
            gameMenu.gameObject.SetActive(false);
            faceTrackerPanel.gameObject.SetActive(true);
            SetButtonInteractivity();
        }

        public void OnGameMenuButtonPressed()
        {
            faceTrackerPanel.gameObject.SetActive(false);
            gameMenu.gameObject.SetActive(true);
            SetButtonInteractivity();
        }

        private void SetButtonInteractivity()
        {
            faceTrackerButton.interactable = !faceTrackerPanel.gameObject.activeSelf;
            gameMenuButton.interactable = !gameMenu.gameObject.activeSelf;
        }
    }
}