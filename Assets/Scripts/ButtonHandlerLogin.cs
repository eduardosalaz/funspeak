using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonHandlerLogin : MonoBehaviour
{

    public Button buttonInicio;
    public Button buttonRegistro;
    public GameObject inputField_texto;
    public GameObject inputField_contraseña;

    // Start is called before the first frame update
    void Start()
    {
        buttonInicio.onClick.AddListener(InicioGetInputOnClickHandler);
        buttonRegistro.onClick.AddListener(RegistroGetInputOnClickHandler);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InicioGetInputOnClickHandler()
    {
        Debug.Log("logging");
        string text = inputField_texto.GetComponent<TMP_InputField>().text;
        Debug.Log(text);

    }
    public void RegistroGetInputOnClickHandler()
    {
        Debug.Log("al registro");
        LoadGameLevel("Registro");


    }
    public void LoadGameLevel(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
