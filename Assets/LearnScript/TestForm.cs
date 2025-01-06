using StarForce;
using UnityEngine;
using UnityEngine.UI;

namespace LearnScript
{
    public class TestForm: UGuiForm
    {
        [SerializeField] private Button btnStart;
        [SerializeField] private Button btnSettings;
        [SerializeField] private Button btnAbout;
        [SerializeField] private Button btnQuit;

        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            
            btnStart.onClick.AddListener(() =>
            {
                Debug.Log("Start");
            });
            
            btnSettings.onClick.AddListener(() =>
            {
                Debug.Log("Settings");
            });
            
            btnAbout.onClick.AddListener(() =>
            {
                Debug.Log("About");
            });
            
            btnQuit.onClick.AddListener(() =>
            {
                Debug.Log("Quit");
            });
        }
    }
}