using UnityEngine;

public class AlternarVisibilidade : MonoBehaviour
{
    [SerializeField] private GameObject grupoAlvo;

    public void Alternar()
    {
        if (grupoAlvo != null)
        {
            grupoAlvo.SetActive(!grupoAlvo.activeSelf);
        }
    }
}
