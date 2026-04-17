using System.ComponentModel.DataAnnotations;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1 - only allow unique values to be added to the tree
        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2 - search for a value in the tree
        if (value == Data)
            return true;
        
        if (value < Data)
        {
            if (Left is null)
                return false;
            else 
                return Left.Contains(value);
        }
        else
        {   
            if (Right is null)
                return false;
            else 
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // return 0; // Replace this line with the correct return statement(s)
        // int Max;
        if (Left == null && Right == null)
            return 1;
            
        // int leftHeight;
        // if (Left == null)   leftHeight = 0;
        // else    leftHeight = Left.GetHeight();
        int leftHeight = (Left == null) ? 0 : Left.GetHeight();

        // int rightHeight;
        // if (Right == null)  rightHeight = 0;
        // else    rightHeight = Right.GetHeight();
        int rightHeight = (Right == null) ? 0 : Right.GetHeight();

        // if (leftHeight > rightHeight)  Max = leftHeight;
        // else Max = rightHeight;
        // int Max = (leftHeight > rightHeight) ? leftHeight : rightHeight;

        // return 1 + Max;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}