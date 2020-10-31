## Mẫu Adapter

Liên hệ thực tế mẫu Adapter giống như thẻ sim (nano sim, micro sim, sim), thẻ nhớ sd (micro sd, sd)... 
Những thẻ này về gốc sẽ có thẻ cơ bản thường là mẫu nhỏ nhất như nano sim, micro sd và để nhén được vào các kích thước khác như micro sim, sim hoặc sd ta cần một cái adapter để tăng kích thước nó lên cho phù hợp

![Memory Adapter](images/memoryAdapter.jpg?raw=true "Memory Adapter")

Giải thích rõ hơn: Về cơ bản tên phương thức để lấy dữ liệu vẫn thế, hệ thống vẫn phải qua tên phương thức cũ, nhưng khi dùng với adapter trong nội dung phương cũ đã bị ghi đè bởi phương thức mới của lớp adaptee

Chúng ta xem mô hình UML sau sẽ rõ:

![UML Adapter](images/umlAdapter.gif?raw=true "UML Adapter")

Các lớp và đối tượng tham gia vào mẫu này:

- Target: định nghĩa như là một interface mà Client đang sử dụng
- Adapter: định nghĩa như lớp làm cho giao diện của Adaptee thích hợp với giao diện Target
- Adaptee: định nghĩa như một interface đã tồn tại cần làm cho thích hợp
- Client: Sử dụng phương thức của Target

```
public class Client
{
    private ITarget _target;
 
    public Client(ITarget target)
    {
        _target = target;
    }
 
    public void MakeRequest()
    {
        _target.MethodA();
    }
}
 
 
public interface ITarget
{
    void MethodA();
}
 
 
public class Adaptee
{
    public void MethodB()
    {
        Console.WriteLine("MethodB called");
    }
}
 
 
public class Adapter : ITarget
{
    Adaptee _adaptee = new Adaptee();
 
    public void MethodA()
    {
        _adaptee.MethodB();
    }
}
```

Tham khảo các nguồn:
- http://www.blackwasp.co.uk/Adapter.aspx
- https://www.dotnettricks.com/learn/designpatterns/adapter-design-pattern-dotnet
- https://www.dofactory.com/net/adapter-design-pattern

