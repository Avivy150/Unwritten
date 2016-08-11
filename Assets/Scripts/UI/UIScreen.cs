using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class UIScreen : MonoBehaviour
{
    public Toggle toggle;   
    public Dropdown dropdown;   
    public delegate void OnOpenCallback();
    public delegate void OpenedCallback();
    public delegate void OnCloseCallback();
    public delegate void ClosedCallback();

    public string openedStateName = "Opened";
    public string closedStateName = "Closed";
    public string parameterName = "Open";
    public bool closedOnStart = true;

    public event OnOpenCallback OnOpen;
    public event OpenedCallback Opened;
    public event OnCloseCallback OnClose;
    public event ClosedCallback Closed;

    bool m_opened, m_openning, m_closing;
    int m_parameterHash;
    Animator m_Animator;

    void Awake()
    {
        m_Animator = GetComponent<Animator>();
        m_parameterHash = Animator.StringToHash(parameterName);
    }

    void Start()
    {
        transform.localPosition = Vector3.zero;
        if (closedOnStart)
            Close();
        else
            Open();
    }

    void Update()
    {

    }

    public void Open()
    {
        if (m_openning) return;
        gameObject.SetActive(true);
        m_openning = true;
        if (OnOpen != null)
            OnOpen();
        m_Animator.SetBool(m_parameterHash, true);
        StartCoroutine(OpenCoroutine());
        if (SceneManager.GetActiveScene().name == "MainMenu") //If active scene is Main Menu
            PlayerPrefs.SetString("ActiveScene", "MainMenu");
        if (SceneManager.GetActiveScene().name != "MainMenu") //If active scene is Main Menu
            PlayerPrefs.SetString("ActiveScene", "Game");
    }

    public void Close()
    {
        if (m_closing) return;
        m_closing = true;
        if (OnClose != null)
            OnClose();
        m_Animator.SetBool(m_parameterHash, false);
        StartCoroutine(CloseCoroutine());
        PlayerPrefs.DeleteKey("Opened");
    }

    public bool IsOpened()
    {
        return m_opened;
    }

    IEnumerator OpenCoroutine()
    {
        bool wantToOpen = true;
        while (!StateReached(openedStateName) && wantToOpen)
        {
            wantToOpen = m_Animator.GetBool(m_parameterHash);
            yield return new WaitForEndOfFrame();
        }

        if (wantToOpen)
        {
            m_opened = true;
            if (Opened != null)
                Opened();
            m_openning = false;
        }
    }

    IEnumerator CloseCoroutine()
    {
        bool wantToClose = true;
        while (!StateReached(closedStateName) && wantToClose)
        {
            wantToClose = !m_Animator.GetBool(m_parameterHash);
            yield return new WaitForEndOfFrame();
        }

        if (wantToClose)
        {
            m_opened = false;
            if (Closed != null)
            {
                Closed();
            }
            m_closing = false;
            gameObject.SetActive(false);
        }
    }

    bool StateReached(string stateName)
    {
        if (!m_Animator.IsInTransition(0))
            return m_Animator.GetCurrentAnimatorStateInfo(0).IsName(stateName);
        return false;
    }

    #region Options Menu

    #region Full Screen
    public void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    #region Screen Resolution
    public void ChangeResolution()
    {
        if (dropdown.value == 0)
            Screen.SetResolution(1024, 576, Screen.fullScreen);
        if (dropdown.value == 1)
            Screen.SetResolution(1280, 720, Screen.fullScreen);
        if (dropdown.value == 2)
            Screen.SetResolution(1600, 900, Screen.fullScreen);
        if (dropdown.value == 3)
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
    }
    #endregion
    #endregion
    #endregion
}