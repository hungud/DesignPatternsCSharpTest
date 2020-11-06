## Mẫu Factory

- Factory là một mẫu thiết kế (pattern) mà nó cho phép tạo các đối tượng mà không cần chỉ định loại đối tượng sẽ được tạo trong mã. 
Một lớp Factory chứa một phương thức sẽ cho phép xác định kiểu được tạo tại thời điểm chạy

- Factory là một mẫu thiết kế (pattern) mà nó xác nhận một giao diện để tạo một đối tượng, nhưng để các lớp con quyết định lớp nào được khởi tạo. 
Như vậy nó cho phép trì hoãn việc khởi tạo cho các lớp con

- Factory là mẫu thiết kế thường xuyên dùng, đánh giá mức độ 5/5

![UML Factory Pattern](images/FactoryMethod.png?raw=true "UML Factory Pattern")

# Trong sơ đồ này có 4 lớp:

- FactoryBase: Đây là lớp cơ sở trừu tượng (abstract) cho các lớp nhà máy con, các lớp nhà máy con chịu tránh nhiệm sản xuất ra đối tượng cụ thể, và các đối tượng này có các phương thức, thuộc tính kế thừa từ lớp cha 
Lớp cơ sở này có thể là một interface đơn giản chứa đặc tả các phương thức, thuộc tính cho các lớp con. 

- ConcreteFactory: Đây là lớp nhà máy cụ thể, lớp này là lớp con kế thừa lớp FactoryBase, có các phương thức, thuộc tính kế thừa, và nó sẽ chịu tránh nhiệm sản xuất ra các đối tượng cụ thể

- ProductBase: Đây là lớp sản phẩm cơ sở cho các lớp sản phẩm con cụ thể. Các sản phẩm con cụ thể có các phương thức, thuộc tính kế thừa từ lớp cha

- ConcreteProduct: Đây là lớp sản phẩm cụ thể, có đầy đủ phương thức, thuộc tính kế thừa từ lớp cha ProductBase
 

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

