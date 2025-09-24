//싱글톤 패턴
//전역으로 편하게 접근 가능한 인스턴스를 만드는 패턴
//하나의 인스턴스 만이 존재해야함


public class Game
{
    private static Game _instance = null;

    public static Game GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Game();
        }
        return _instance;
    }

    public static void ReleaseInstance()
    {
        _instance = null;
    }


    //변수들...
    public void SomeFunc()
    {
        //코드 . . .
    }
}