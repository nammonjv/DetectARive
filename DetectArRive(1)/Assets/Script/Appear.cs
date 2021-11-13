using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

    /// <summary>
    /// Moves the ARSessionOrigin in such a way that it makes the given content appear to be
    /// at a given location acquired via a raycast.
    /// </summary>
    [RequireComponent(typeof(ARSessionOrigin))]
    [RequireComponent(typeof(ARRaycastManager))]
    public class Appear : MonoBehaviour
    {
        public Text text;
        static int VaseSearch = 0;
        static int PicSearch = 0;

        public GameObject flower;
        public GameObject partRed;
        public GameObject partBlue;
        public GameObject partWhite;
        public GameObject partYellow;
        public GameObject Hint1;
        public GameObject Hint2;
        public GameObject Button1;
        public GameObject Button2;
        public GameObject Button3;
        public GameObject Button4;
        public GameObject Button5;
        public GameObject Button6;
        public GameObject Button7;
        public GameObject Button8;
        public GameObject Button9;
        public GameObject Button0;
        string btnName;
        public GameObject XButton;
        
        [SerializeField]
        [Tooltip("A transform which should be made to appear to be at the touch point.")]
        Transform m_Content; 
        

        /// <summary>
        /// A transform which should be made to appear to be at the touch point.
        /// </summary>
        public Transform content
        {
            get { return m_Content; }
            set { m_Content = value; }
        }

        [SerializeField]
        [Tooltip("The rotation the content should appear to have.")]
        Quaternion m_Rotation;

        /// <summary>
        /// The rotation the content should appear to have.
        /// </summary>

        void Awake()
        {
            m_SessionOrigin = GetComponent<ARSessionOrigin>();
            m_RaycastManager = GetComponent<ARRaycastManager>();
        }

        void Update()
        {
            
            if (LockButton.locker == 0)
            {
                if (Input.touchCount == 0 || m_Content == null)
                    return;

                var touch = Input.GetTouch(0);

                if (m_RaycastManager.Raycast(touch.position, s_Hits, TrackableType.PlaneWithinPolygon))
                {
                    // Raycast hits are sorted by distance, so the first one
                    // will be the closest hit.
                    var hitPose = s_Hits[0].pose;

                    // This does not move the content; instead, it moves and orients the ARSessionOrigin
                    // such that the content appears to be at the raycast hit position.
                    m_SessionOrigin.MakeContentAppearAt(content, hitPose.position, m_Rotation);
                }
            }
            else if (LockButton.locker >0)
            {
                Destroy(XButton);
                if(Input.touchCount >0 && Input.touches[0].phase == TouchPhase.Began)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                    RaycastHit Hit;
                        if (Physics.Raycast(ray, out Hit))
                        {
                            btnName = Hit.transform.name;
                            switch (btnName)
                            {
                                case "MBJ_PlantPack01_Pot04_LOD2_v001": //Jaegun
                                    if(PlayerButton.playerMode ==1)
                                    {
                                        if(VaseSearch==0)
                                        {
                                            Destroy(flower);
                                            text.text = "นี่คือ?";
                                            VaseSearch+=1;
                                        }
                                        else if(VaseSearch==1)
                                        {
                                            Destroy(partRed);
                                            text.text = "คุณได้รับชิ้นส่วนสีแดง!";
                                            VaseSearch+=1;
                                        }
                                        else
                                        {
                                            text.text = "หาไปแล้ว...";

                                        }
                                    }
                                    else
                                    {
                                        if(VaseSearch==0)
                                        {
                                            text.text = "น่าสงสัย";
                                        }
                                        else
                                        {
                                            text.text = "หาไปแล้ว...";

                                        }
                                        
                                    }
                                    break;
                                case "picture": //roob
                                    if(PlayerButton.playerMode ==1)
                                    {
                                        if(PicSearch==0)
                                        {
                                            text.text = "คุณได้รับภาพ Drawing ด้านบน!";
                                            PicSearch+=1;
                                        }
                                        else
                                        {
                                            text.text = "หาไปแล้ว...";
                                        }
                                    }
                                    else
                                    {
                                        if(PicSearch==0)
                                        {
                                            text.text = "น่าสงสัย";
                                        }
                                        else
                                        {
                                            text.text = "หาไปแล้ว...";
                                        }
                                        
                                    }
                                    break;
                                case "tinker-b": //chin blue
                                    text.text = "ได้รับชิ้นส่วนสีน้ำเงิน";
                                    Destroy(partBlue);
                                    break;
                                case "tinker-w": //chin white
                                    text.text = "ได้รับชิ้นส่วนสีขาว";
                                    Destroy(partWhite);
                                    break;
                                case "tinker-y":
                                    text.text = "คุณได้รับภาพ Drawing ด้านข้าง\nและชิ้นส่วนสีเหลือง!";
                                    break;
                                case "hint2_ (3)":
                                    text.text = "ได้รับภาพ Drawing ด้านหน้า";
                                    Destroy(Hint1);
                                    break;
                                case "Button1":
                                    text.text = btnName;
                                    break;
                                case "Button2":
                                    text.text = btnName;
                                    break;
                                case "Button3":
                                    text.text = btnName;
                                    break;
                                case "Button4":
                                    text.text = btnName;
                                    break;
                                case "Button5":
                                    text.text = btnName;
                                    break;
                                case "Button6":
                                    text.text = btnName;
                                    break;
                                case "Button7":
                                    text.text = btnName;
                                    break;
                                case "Button8":
                                    text.text = btnName;
                                    break;
                                case "Button9":
                                    text.text = btnName;
                                    break;
                                case "Button0":
                                    text.text = btnName;
                                    break;
                                default:
                                    break;
                            }
                        }
                }
               // var hitPose = s_Hits[0].pose;
               // m_SessionOrigin.MakeContentAppearAt(content, hitPose.position, m_Rotation);
            }
            

        }

        static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

        ARSessionOrigin m_SessionOrigin;

        ARRaycastManager m_RaycastManager;
    }
