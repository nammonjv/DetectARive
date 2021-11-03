using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButton : MonoBehaviour
{
    
    public Text textplayer;
    static public int playerMode;
    [SerializeField]
        GameObject m_playerButton;
        public GameObject playerbutton
        {
            get => m_playerButton;
            set => m_playerButton = value;
        }
    // Start is called before the first frame update
    void Start()
    {
        playerMode=1;
    }

    // Update is called once per frame
    void Update()
    {
        if (LockButton.locker == 0)
        {
            //playerbutton.SetActive(false);
        }
        else if(LockButton.locker >0)
        {
            //playerbutton.SetActive(true);
            //gameObject.SetActive(gameObject.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            {
                PlayerButtonPressed();
            }
    }
    public void PlayerButtonPressed()
    {
        if (textplayer != null)
            {
                if(playerMode==1)
                {
                    playerMode=2;
                }
                else if(playerMode==2)
                {
                    playerMode=1;
                }
                textplayer.text = "Mode:\nPlayer " + playerMode;
            }
    }
}
