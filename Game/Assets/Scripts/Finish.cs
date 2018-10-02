using UnityEngine;

public class Finish : MonoBehaviour {

    public GameObject sphere;
    public GameObject text;
    public string level;
    public bool finish = false;

	// Use this for initialization
	void Start () {
        text.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (finish)
        {
            if ((Input.GetKey(KeyCode.F)) && (level != "end"))
            {
                Application.LoadLevel(level);
            }
        }
	}

    void OnTriggerEnter()
    {
        finish = true;
        text.SetActive(true);
    }
}
