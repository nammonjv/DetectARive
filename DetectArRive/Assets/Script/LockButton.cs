using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockButton : MonoBehaviour
{
    public static int locker;
    public Text text;
    [SerializeField]
        GameObject m_LockButton;
        
        public GameObject lockButton
        
        {
            get => m_LockButton;
            set => m_LockButton = value;
        }

        void Start()
        {
            locker = 0;
            //if (Application.CanStreamedLevelBeLoaded("Menu"))
            //{
                m_LockButton.SetActive(true);
                
            //}
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                LockButtonPressed();
            }
            
        }

        public void LockButtonPressed()
        {
            locker += 1;
            Destroy(text);
        }
}
