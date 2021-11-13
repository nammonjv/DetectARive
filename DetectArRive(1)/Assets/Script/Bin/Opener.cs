using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Opener : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject OpenPanel = null;
    //private bool _isInsideTrigger = false;
    //public Animator _animator;
    public GameObject ThisOb;
    //public string OpenText = "Touch to interact";
    //public string CloseText = "Next";
    //private bool _isOpen = false;
    void onTriggerEnter(Collider other)
    {
        //if(other.tag == "MainCamera")
        //{
            if(Input.touchCount >0)
            {
                Destroy(ThisOb);
            }
            //_isInsideTrigger = false;
            //OpenPanel.SetActive(false);
        //}
    }
    private bool IsOpenPanelActive;
    //{
    //    get
    //    {
    //        return true;
            //return OpenPanel.activeInHierarchy;
    //    }
    //}
    

    // Update is called once per frame
    void Update()
    {
        /*if(IsOpenPanelActive && _isInsideTrigger)
        {
            if(Input.touchCount >0)
            {
                _isOpen = !_isOpen;
                _animator.SetBool("open",_isOpen);
                Destroy(ThisOb);
            }
        }*/
        
    }
}
