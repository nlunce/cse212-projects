public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

   public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data || 
            Left is not null && Left.Contains(value) || 
            Right is not null && Right.Contains(value)
        ) {
            return true;
        }
        return false;
    }

  public int GetHeight() {
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;      
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;  

      
        return 1 + Math.Max(leftHeight, rightHeight);  
    }
}