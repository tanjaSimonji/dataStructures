class MainProgram
{
    public static void Main(string[] args)
    {
        LinkedList listInsertFront = new LinkedList();
        listInsertFront.InsertFront(4);
        listInsertFront.InsertFront(5);
        listInsertFront.InsertFront(6);
        listInsertFront.Print();

        LinkedList listInsertBack = new LinkedList();
        listInsertBack.InsertBack(5);
        listInsertBack.InsertBack(6);
        listInsertBack.InsertBack(7);
        listInsertBack.Print();

        LinkedList listInsertAfter = new LinkedList();
        listInsertAfter.InsertBack(6);
        listInsertAfter.InsertBack(8);
        listInsertAfter.InsertAfter(6, 7);
        listInsertAfter.Print();

        LinkedList listDelete = new LinkedList();
        listDelete.InsertFront(40);
        listDelete.InsertFront(50);
        listDelete.InsertFront(60);
        listDelete.InsertFront(70);
        listDelete.Print();
        listDelete.DeleteElement(50);
        listDelete.Print();

        Queue newQueue = new Queue();
        newQueue.Insert(99);
        newQueue.Insert(100);
        newQueue.Insert(101);
        newQueue.Print();
        newQueue.Delete();
        newQueue.Print();
    }
}
