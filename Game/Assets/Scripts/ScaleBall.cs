using UnityEngine;

public class ScaleBall : MonoBehaviour {

    public string scale;
    public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    void OnTriggerEnter()
    {
        if (scale == "small")
            ball.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
