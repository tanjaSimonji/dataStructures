class Queue
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
    };

    private Node head;
    private Node tail;

    public Queue()
    {
        head = null;
        tail = null;
    }

    public void Insert(int newData)
    {
        Node newNode = new Node(newData);
            
        if(head == null) 
        {
            head = newNode;
            tail = newNode;
        } 
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
    }
    public void Delete()
    {
        if(head == tail)
        {
            Console.WriteLine("queue is empty");
            return;
        }
          else
        {
            head = head.next;
        }
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
};
