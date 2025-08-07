using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    static Vector3? posicaoVolta = null;
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            if (posicaoVolta != null)
            {
                player.transform.position = (Vector3)posicaoVolta;
                posicaoVolta = null;
            }


        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TrocarDeCena(string cena)
    {
        if (player != null)
        {
            posicaoVolta = player.transform.position;
        }
        SceneManager.LoadScene(cena);
    }

}