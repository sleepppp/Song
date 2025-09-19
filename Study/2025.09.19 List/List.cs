//데이터 추가를 뒤에서만 하고, 데이터 제거를 앞에서만 한다

//데이터 추가를 뒤에 할 때
//연결 리스트 : 노드새로 생성해서 tail.next = newNode;
//리스트 : 기본적으로 빠른데, 배열 크기가 부족해서 재할당할때는 느리다.

//데이터 제거를 앞에서 할 때
//연결 리스트 : rootNode = rootNode.next
//리스트 : 뒤에있는 데이터 전부 앞으로 한칸씩 땡겨야 해서 느리다

//그럼 큐를 구현할 때 유리한건? : 양방향 연결 리스트 방식

//데이터 추가를 뒤에서만하고, 데이터 제거도 뒤에서만 한다

//데이터 추가를 뒤에 할 때
//연결 리스트 : 노드새로 생성해서 tail.next = newNode;
//리스트 : 기본적으로 빠른데, 배열 크기가 부족해서 재할당할때는 느리다.

//데이터 제거 뒤에 할 때
//연결 리스트 : tail = tail.front 끝
//리시트 : _count--; 끝

public class MyList
{
    private int[] _arr = null;
    private int _count = 0;

    public void Add(int value)
    {
        if (_arr == null)
        {
            _arr = new int[1];
        }
        else if (_arr.Length == _count)
        {
            int[] newArr = new int[_arr.Length * 2];
            for (int i = 0; i < _arr.Length; ++i)
            {
                newArr[i] = _arr[i];
            }
            _arr = newArr;
        }

        _arr[_count] = value;
        _count++;
    }

    public void Pop()
    {
        _count--;
    }

    public int GetData(int index)
    {
        if (index < 0 || index >= _count)
        {
            throw new Exception("invalid index exeption");
        }

        return _arr[index];
    }

    public void RemoveAt(int index)
    {
        //todo
    }

    public void Insert(int index, int value)
    {
        //todo
    }

    public void Print()
    {
        //todo
    }
    public void Clear()
    {
        _count = 0;
    }
}