using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private int i = 0;
    public int x = 0;
    [SerializeField] private int y = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.LogWarning("Hello World2!");
        Debug.LogError("Hello World!");
    }   

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(i + " текущий счет");
        x--;
        Debug.Log(x + " текущий счет");
    }
}
