public class MyHashTable
{
    public class Node
    {
        public int Value;
        public string Key;
        public Node NextNode;
    }
    public class Data
    {
        public string Key;
        public int Value;
        public Node NextNode;
    }

    private Data[] _arr = new Data[10];
    private int _count = 0;

    public void Add(string key, int value)
    {
        Data data = new Data();
        data.Key = key;
        data.Value = value;

        int index = GetIndexFromKey(key);

        if (_arr[index].Key != null)
        {
            //해싱 충돌!!! 여기부턴 연결 리스트로!
        }
        else
        {
            _arr[index] = data;
        }
        _count++;
    }

    private int GetIndexFromKey(string key)
    {
        return Math.Abs(key.GetHashCode()) % _arr.Length;
    }
}
