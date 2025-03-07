using Rive.Components;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class AppController : MonoBehaviour
    {
        [SerializeField] private Button faceTrackerButton;
        [SerializeField] private Button gameMenuButton;
        [SerializeField] private RivePanel gameMenu;
        [SerializeField] private RivePanel faceTrackerPanel;
        
        private void Awake()
        {
            SetButtonInteractivity();
        }

        private void Update()
        {
        }

        public void OnLoad3dScene()
        {
            SceneManager.LoadScene("Scenes/3D");
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