using Rive;
using Rive.Components;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class Controller3D : MonoBehaviour
    {
        [SerializeField] private RiveWidget riveWidget;
        private SMINumber rating;
        
        private void Start()
        {
            rating = riveWidget.StateMachine.GetNumber("rating");
        }

        public void OnGiveOneStar()
        {
            rating.Value += 1f;
        }

        public void OnGiveTwoStar()
        {
            rating.Value += 2f;
        }

        public void OnGiveThreeStar()
        {
            rating.Value += 3f;
        }

        public void Load2dSceneTest()
        {
            SceneManager.LoadScene("Scenes/SampleScene");
        }
    }
}