public class Node
{
    public int Value;
    public Node NextNode;
}

public class LinkedList
{
    public Node Root = null;

    public void Add(int inValue)
    {
        if (Root == null)
        {
            Root = new Node();
            Root.Value = inValue;
        }
        else
        {
            Node temp = Root;
            while (temp.NextNode != null)
            {
                temp = temp.NextNode;
            }
            //여기까지 왔다면 temp가 끝 노드. 찾았다!
            temp.NextNode = new Node();
            temp.NextNode.Value = inValue;
        }
    }

    public bool IsContain(int inValue)
    {
        Node temp = Root;
        while(temp != null)
        {
            if (temp.Value == inValue)
            {
                return true;
            }
            temp = temp.NextNode;
        }
        //여기 까지 왔다면, 끝까지 돌았는데 못 찾았다
        return false;
    }

    public void Print()
    {
        //전체 순회하면서 출력하세요~
    }
    public void Remove(int inValue)
    {
        //해당 노드 삭제
    }
    public void RemoveAt(int inIndex)
    {
        //inIndex 번째 녀석 삭제 0 이면 처음 녀석, 1이면 두번째 녀석
    }
    public void Clear()
    {
        //전체 제거
    }

    public int GetCount()
    {
        //데이터 수 반환 (노드의 수 반환)
    }
}

