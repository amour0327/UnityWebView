using UnityEngine;
using System.Collections;

public class WebController : MonoBehaviour {

	private string url = "http://terraform.sakura.ne.jp/blog/";
	WebViewObject webViewObject;
	void Start() {
		webViewObject = GetComponent<WebViewObject>();
		webViewObject.Init();
		webViewObject.LoadURL(url);
		webViewObject.SetVisibility(true);
	}
}
