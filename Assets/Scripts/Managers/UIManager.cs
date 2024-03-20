using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text m_appleCountTxt;

    [SerializeField] GameManager m_gameManager;

    
    void Start()
    {
        if (!m_appleCountTxt)
        {
            Debug.LogError("Pas de text",this);
        }
        if (!m_gameManager)
        {
            FindObjectOfType<GameManager>();
        }
        GameManager.AppleCountChanged += UpdateDisplay;
    }

  
   void UpdateDisplay()
    {
        m_appleCountTxt.text = "Pomme :"+m_gameManager.GetAppleCount();
    }
}
