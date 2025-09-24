//템플릿 싱글톤

//where : 제네릭에 제한을 두고 싶을때, 조건을 걸 때 사용하는 문법
public class Singleton<T> where T : class, new()
{
    private static T _instance = null;

    public static T GetInstance()
    {
        if (_instance == null)
        {
            _instance = new T();
        }
        return _instance;
    }

    public static void ReleaseInstance()
    {
        _instance = null;
    }
}