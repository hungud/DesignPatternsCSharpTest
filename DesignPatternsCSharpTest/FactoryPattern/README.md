## Mẫu Factory

- Factory là một mẫu thiết kế (pattern) mà nó cho phép tạo các đối tượng mà không cần chỉ định loại đối tượng sẽ được tạo trong mã. 
Một lớp Factory chứa một phương thức sẽ cho phép xác định kiểu được tạo tại thời điểm chạy

- Factory là một mẫu thiết kế (pattern) mà nó xác nhận một giao diện để tạo một đối tượng, nhưng để các lớp con quyết định lớp nào được khởi tạo. 
Như vậy nó cho phép trì hoãn việc khởi tạo cho các lớp con

- Factory là mẫu thiết kế thường xuyên dùng, đánh giá mức độ 5/5

![UML Factory Pattern](images/FactoryMethod.png?raw=true "UML Factory Pattern")

# Trong sơ đồ này có 4 lớp:

- FactoryBase: Đây là lớp cơ sở trừu tượng (abstract) cho các lớp khác, các lớp mà sẽ sinh ra đối tượng mới. Lớp này có thể là một interface đơn giản chứa đặc tả cho lớp. Tuy vậy, một lớp trừu tượng sẽ được sử dụng để các chức năng tiêu chuẩn khác có thể được các lớp con bao gồm và kế thừa.
- ConcreteFactory: 
- ProductBase: 
- ConcreteProduct: 
 

```
public abstract class FactoryBase
{
    public abstract ProductBase FactoryMethod(int type);
}
 
 
public class ConcreteFactory : FactoryBase
{
    public override ProductBase FactoryMethod(int type)
    {
        switch (type)
        {
            case 1: return new ConcreteProduct1();
            case 2: return new ConcreteProduct2();
            default: throw new ArgumentException("Invalid type.", "type");
        }
    }
}
 
 
public abstract class ProductBase { }
 
public class ConcreteProduct1 : ProductBase { }
 
public class ConcreteProduct2 : ProductBase { }
```


Tham khảo các nguồn:
- http://www.blackwasp.co.uk/FactoryMethod.aspx
- https://www.dofactory.com/net/factory-method-design-pattern
- https://refactoring.guru/design-patterns/factory-method
- https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/

