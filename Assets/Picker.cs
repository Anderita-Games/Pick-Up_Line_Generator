using System.IO;
using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Picker : MonoBehaviour
{
    /*  -----------------------
	Made by Andrew Friedman
	6/3/17 1:10 AM
	Sh!t is fye ;)
	-----------------------  */
     //For Reading TXT
    public GameObject StartText;
    public int RandoNumbo;
    public StreamReader sr;
    public TextAsset List;
    public UnityEngine.UI.Text TheLine;
    public virtual void Start()//List = Resources.Load("Lines", typeof(TextAsset));
    {
    }

    public virtual void Generate()
    {
        this.StartText.SetActive(false);
        this.RandoNumbo = Random.Range(1, 401);
        this.sr = new StreamReader(new MemoryStream(this.List.bytes));
        while (this.RandoNumbo > 0)
        {
            this.TheLine.text = this.sr.ReadLine();
            this.RandoNumbo--;
        }
        this.sr.Close();
    }

}