using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GraphFunctionSelection : MonoBehaviour {

    Graph3DCustom graphscript;

    void Start()
    {
        graphscript = GetComponent<Graph3DCustom>();
    }

    public void Sine()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.Sine;
    }

    public void Sine2D()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.Sine2D;
    }

    public void MultiSine()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.MultiSine;
    }

    public void MultiSine2D()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.MultiSine2D;
    }

    public void Ripple()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.Ripple;
    }

    public void Cylinder()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.Cylinder;
    }

    public void Sphere()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.Sphere;
    }

    public void Torus()
    {
        graphscript.function = Graph3DCustom.GraphFunctionName.Torus;
    }


    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
