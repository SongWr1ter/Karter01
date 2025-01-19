using System.Collections;
using System.Collections.Generic;
using NodeCanvas.DialogueTrees;
using Sirenix.OdinInspector;
using Unity.Mathematics;
using UnityEngine;

public class testTrigger : SerializedMonoBehaviour
{
    [SerializeField]private DialogueTreeController dialogueTree;

    public int Power = 50;

    public float2 input;

    public float2 output;

    public float2x2 weight = new float2x2(1.0f,1.0f,1.0f,1.0f);

    [ShowInInspector]
    [TableMatrix(HorizontalTitle = "对每个属性影响的系数", VerticalTitle = "五种口味", SquareCells = true)]
    //SquareCells 为True，则其他的cell的宽高将于第一个cell的宽度相等
    public float[,] SquareCelledMatrix = new float[4, 5];
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            forward();
        }
    }

    public void say()
    {
        dialogueTree.StartDialogue();
    }

    public void forward()
    {
        output = mul2x2(weight,input);
        print(output);
    }

    static float2 mul2x2(float2x2 a, float2 b)
    {
        float x = a[0][0] * b.x + a[0][1] * b.y;                //      口味1   口味2
        float y = a[1][0] * b.x + a[1][1] * b.y;                //属性1   x       x
                                                                //属性2   x       x
        return new float2(x,y);
    }
}
