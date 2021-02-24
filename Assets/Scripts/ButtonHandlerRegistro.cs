using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandlerRegistro : MonoBehaviour
{

    public Button buttonRegistro;
    public GameObject inputField_texto;
    public GameObject inputField_contraseña;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonRegistro.onClick.AddListener(RegistrarseGetInputOnClickHandler);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RegistrarseGetInputOnClickHandler()
    {
        Debug.Log("logging");
        string email = inputField_texto.GetComponent<TMP_InputField>().text;
        string password = inputField_contraseña.GetComponent<TMP_InputField>().text;
        Firebase.Auth.FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            // Firebase user has been created.
            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
        });




    }
}
