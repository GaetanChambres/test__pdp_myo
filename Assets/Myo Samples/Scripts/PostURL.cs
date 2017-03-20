using UnityEngine;
using System.Collections;

public class PostURL : MonoBehaviour
{

    private static string url = "http://axel.dubroca.emi.u-bordeaux.fr/update.php";

    static public PostURL instance;

    void Awake()
    {
        instance = this;
    }

    public void Send(string name, int nb_accords)
    {
        url = url + "?name=" + name + "&number=" + nb_accords;

        WWW download = new WWW(url);

        instance.StartCoroutine(PostURL.WaitForRequest(download));
    }

    static IEnumerator WaitForRequest(WWW download)
    {
        yield return download;

        if (download.error == null)
        {
            Debug.Log("download ok : " + download.text);
        }
        else
        {
            Debug.Log("download error : " + download.error);
        }
    }
}