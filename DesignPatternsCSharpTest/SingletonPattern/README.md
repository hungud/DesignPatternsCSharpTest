## Mẫu Singleton

Singleton là một mẫu thiết kế (pattern) mà nó đảm bảo rằng chỉ có một Object/Instance được tồn tại trong một vòng đời của ứng dụng.

![UML Singleton Pattern](images/singleton.png?raw=true "UML Singleton Pattern")


```
public sealed class Singleton
{
    private static Singleton _instance;
    private static object _lockThis = new object();
 
    private Singleton() { }
 
    public static Singleton GetSingleton()
    {
        if (_instance == null)
        {
            lock (_lockThis)
            {
                if (_instance == null) _instance = new Singleton();
            }
        }
 
        return _instance;
    }
}
```

Trong lập trình đa luồng ý tưởng của double checked locking đơn giản chỉ là ta sẽ check hai lần _instance==null, lần check đầu tiên sẽ nằm ngoài lock do đó sẽ đảm bảo được rằng nếu _instance đã được khởi tạo do đó các thread khác sẽ không bị chặn bởi lock 
và sẽ trả về Object ngay lập tức. 
Nó sẽ đảm bảo rằng _instance luôn luôn chỉ có một bản thể và performance của hệ thống sẽ được cải thiện. 


Tham khảo các nguồn:
- http://www.blackwasp.co.uk/Singleton.aspx
- https://www.dofactory.com/net/singleton-design-pattern
- https://medium.com/@batnamv/design-pattern-li%E1%BB%87u-b%E1%BA%A1n-c%C3%B3-th%E1%BB%B1c-s%E1%BB%B1-hi%E1%BB%83u-v%E1%BB%81-singleton-pattern-a88aede760f6

