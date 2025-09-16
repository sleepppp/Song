//LinkedList 구현 후 여기와서
LinkedList myLinkedList = new LinkedList();

for (int i = 0; i < 10; ++i)
{
    myLinkedList.Add(i);
}

myLinkedList.Remove(5);

myLinkedList.Print();
//0, 1, 2, 3, 4, 6, 7, 8, 9 나와야 한다