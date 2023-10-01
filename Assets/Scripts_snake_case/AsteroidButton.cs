using UnityEngine;

namespace Snake_Case
{
public class AsteroidButton : MonoBehaviour
{
    [SerializeField] private GameObject button;
    private void OnMouseDown()
    {
        button.SetActive(true);
    }

}
}
