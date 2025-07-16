using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TrocarDeCena(string cena)
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(cena);
        
    }

}
