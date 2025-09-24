public class Player
{
    private int _hp;
    public int _mp { get; private set; }
    public int hp 
    { 
        get { return _hp; } 
        set 
        {
            _hp = value;
        }
    }
    public int mp => _mp; //get구현이랑 같음 {get { return _mp; }
}