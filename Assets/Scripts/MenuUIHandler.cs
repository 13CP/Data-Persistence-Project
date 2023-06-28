using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public string PlayerNameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void SetPlayerName(string s)
    {

        PlayerDataHandle.Instance.PlayerName = s;
        PlayerNameInput = s;
    }



}
