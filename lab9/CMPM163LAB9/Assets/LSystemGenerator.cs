using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LSystemGenerator : MonoBehaviour
{
	private string axiom = "F";
	private string currentString;
	private Dictionary<char,string> rules = new Dictionary<char,string>(); 
	private Stack<TransformInfo> transformStack = new Stack<TransformInfo>();
    // Start is called before the first frame update

    private float length = 10f;
    private float angle = 15f;
    private bool isGenerating = false;
    private float maxGenerate = 1;
    public GameObject sun;
    int count = 0;
    private Vector3 distance;
    public float strength = 1f;

    void Start()
    {
    	rules.Add('F',"FF+[+F-F-F]-[F-F]-[-F+F+F]");
        currentString = axiom;
    }

    // Update is called once per frame
    void Update()
    {     
    	distance = this.transform.position - sun.transform.position;
    	if(distance.magnitude < 1){
    		distance = new Vector3(0,0,0);
    	}else{
    		distance.Normalize();
    	}
    	//Debug.Log(distance);
    		if(count < maxGenerate){
    			if(!isGenerating){
    				isGenerating = true;
    				StartCoroutine(Generate());
    				count++;
    			}
    		}
    }

    public void OnFire(){
    	maxGenerate++;
    	Debug.Log("generate");
    }
    IEnumerator Generate(){
    	length = length;
    	string newString = "";
    	char[] stringCharacters = currentString.ToCharArray();
    	for(int i = 0 ; i< stringCharacters.Length; i++){
    		char currentCharacter = stringCharacters[i];
    		if(rules.ContainsKey(currentCharacter)){
    			newString += rules[currentCharacter];
    		} else {
    			newString += currentCharacter;
    		}
    	}
    	currentString = newString;
    	Debug.Log(currentString);

    	stringCharacters = currentString.ToCharArray();

    	for(int i = 0; i < stringCharacters.Length; i++){
    		char currentCharacter = stringCharacters[i];
    		if(currentCharacter == 'F'){
    			Vector3 initialPosition = transform.position;
    			transform.Translate(Vector3.forward * length);
    			Debug.DrawLine(initialPosition,transform.position,Color.white,10000f,false);
    			yield return null;
    		} else if ( currentCharacter == '+') {
    			transform.Rotate((angle * Vector3.up) + (distance * strength));
    		} else if ( currentCharacter == '-') {
    			transform.Rotate((-angle * Vector3.up) + (distance * strength));
    		} else if (currentCharacter == '['){
    			TransformInfo ti = new TransformInfo();
    			ti.position = transform.position;
    			ti.rotation = transform.rotation;
    			transformStack.Push(ti);
    		} else if (currentCharacter == ']'){
    			TransformInfo ti = transformStack.Pop();
    			transform.position = ti.position;
    			transform.rotation = ti.rotation;
    		}

    	}
    	isGenerating = false;
    }
}
