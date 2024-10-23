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
        // TODO Start Problem 1
        if (value == Data) // avoid duplicates by checking if value matches current node's data and skipping it
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
        // TODO Start Problem 2
        if (value == Data)
            return true;

        if (value < Data)
            return Left != null && Left.Contains(value);
        else
            return Right != null && Right.Contains(value);
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // initialize heights to 0
        int leftHeight = 0;
        int rightHeight = 0;
        
        // check and get left subtree height
        if (Left != null) {
            leftHeight = Left.GetHeight();
        }
        
        // check and get right subtree height
        if (Right != null) {
            rightHeight = Right.GetHeight();
        }

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}