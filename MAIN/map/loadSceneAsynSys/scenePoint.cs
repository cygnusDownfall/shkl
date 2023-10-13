using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(BoxCollider))]
public class scenePoint : MonoBehaviour
{
    public Scene[] sceneAdded;
    public Scene[] sceneRemoved;
    byte playerFilter = 0;

    void loadScene(Scene[] scene)
    {
        foreach (Scene sc in scene)
        {
            SceneManager.LoadSceneAsync(sc.name, LoadSceneMode.Additive);
        }
    }
    void removeScene(Scene[] scene)
    {
        foreach (Scene sc in scene)
        {

            SceneManager.UnloadSceneAsync(sc, UnloadSceneOptions.None);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (!collider.TryGetComponent(out playerInfo player)) { return; }
        playerFilter++;
        loadScene(sceneAdded);
        
    }
    void OnTriggerExit(Collider collider)
    {
        if (!collider.TryGetComponent(out playerInfo player)) { return; }
        playerFilter--;
        if (playerFilter >0) return;
        removeScene(sceneRemoved);
    }
}
