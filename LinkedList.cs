class LinkedList
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int newData)
        {
            data = newData;
            next = null;
        }
    }

    private Node head;
    public LinkedList()
    {
        head = null;
    }

    public void InsertFront(int newData)
    {
        Node newNode = new Node(newData);
        newNode.next = head;
        head = newNode;
    }

    public void InsertBack(int newData)
    {
        Node backNode = new Node(newData);

        if (head == null)
        {
            head = backNode;
            return; 
        }

        Node lastNode = GetLastNode();
        lastNode.next = backNode;
    }

    public void InsertAfter(int afterEl, int newData)
    {
        if(head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        Node newNode = new Node(newData);
        Node tmpNode = head;
        while (tmpNode != null && tmpNode.data != afterEl)
        {
            tmpNode = tmpNode.next;
        }
        if (tmpNode == null)
        {
            Console.WriteLine("Given data afterEl not exist");
            return;
        }
        newNode.next = tmpNode.next;
        tmpNode.next = newNode;
    }

    public void Print()
    {
        Node tmpNode = head;
        while (tmpNode != null)
        {
            Console.WriteLine(tmpNode.data);
            tmpNode = tmpNode.next;
        }
    }

    private Node GetLastNode()
    {
        if (head == null)
        {
            Console.WriteLine("list is empty");
            return null;
        }

        Node last = head;

        while (last.next != null)
        {
            last = last.next;
        }
        return last;
    }

    public void DeleteElement(int elValue)
    {
        Node previousNode = head;
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }
       
        while(previousNode.next != null && previousNode.next.data != elValue)
        {
            previousNode = previousNode.next;
        }
        if (previousNode.next != null)
        {
            previousNode.next = previousNode.next.next;
        } else
        {
            Console.WriteLine("Node with given data doesn't exist");
        }
    }
}