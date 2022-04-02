using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class valida_contraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    public Text IngresoUsr;
    string contraseñaUsr;
    public GameObject cartelitoMsj;
    public Text txtMensaje;
    // Start is called before the first frame update
    void Start()
    {
        contraseñaCorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void validarContraseña() {
        contraseñaUsr = IngresoUsr.text;
        if (contraseñaUsr == contraseñaCorrecta)
        {
            cartelitoMsj.SetActive(true);
            txtMensaje.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            txtMensaje.text = "Contraseña Incorrecta";
            Debug.Log("Contraseña Incorrecta");
        }
    }
}
