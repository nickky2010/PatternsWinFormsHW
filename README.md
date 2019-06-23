# Patterns HW 1 - Abstract Factory+Adapter+Decorator+Bridge
***
## Task 1 `Abstract Factory Pattern`

Разработать систему классов, реализующую паттерн ***Абстрактная фабрика***


Классы-автомобильные заводы (фабрики ***«Автоваз»*** и ***«Фольксваген»***) должны создавать объекты двух видов:   
автомобили и мотоциклы (могут быть бензиновыми  и дизельными).

![Alt text](/Task/Image/1.PNG?raw=true "UML паттерн AbstractFactory")

В классе-клиенте пользователю предоставляется возможность выбрать фабрику и заказать транспортное средство. После чего ему выдается описание его заказа.

Вид приложения после запуска:

![Alt text](/Task/Image/2.PNG?raw=true "Вид приложения после запуска")

***
## Task 2 `Adapter Pattern`

Путешественник обычно путешествует на машине. Но в какой-то момент ему приходится передвигаться по пескам пустыни, или перемещаться по горной местности, или перелетать через океан (тогда он не может ехать на машине). Зато он может использовать для передвижения верблюда, лошадь или слона.

 
Разработать систему классов, реализующую паттерн ***Адаптер***


Класс ***Автомобиль*** представляет объекты, которые используются клиентом (`Target`).


Класс ***Верблюд*** представляет адаптируемый класс (`Adaptee`).

![Alt text](/Task/Image/3.PNG?raw=true "UML паттерн Adapter")

В классе-клиенте пользователю предоставляется возможность выбрать средство передвижения.

Вид приложения после запуска:

![Alt text](/Task/Image/4.PNG?raw=true "Вид приложения после запуска")

***
## Task 3 `Decorator Pattern`

Разработать систему классов для приложения службы заказа такси, реализующую паттерн Декоратор (`Decorator`)

![Alt text](/Task/Image/5.PNG?raw=true "UML паттерн Decorator")

Вид приложения после запуска:

![Alt text](/Task/Image/6.PNG?raw=true "Вид приложения после запуска")

![Alt text](/Task/Image/7.PNG?raw=true "Вид приложения после запуска")

![Alt text](/Task/Image/8.PNG?raw=true "Вид приложения после запуска")

![Alt text](/Task/Image/9.PNG?raw=true "Вид приложения после запуска")

***
## Task 4 `Bridge Pattern`

Разработать калькулятор для расчета цены заказа.


Для описания товара в корзине покупателя создать класс `ProductInCart`. 
```C#
class ProductInCart
    {
        public uint Id { get; set; }
        public uint Quantity { get; set; }
        public decimal Price { get; set; }
    }
```

При построении системы классов использовать паттерн ***Мост***. 

Интерфейс абстракции должен удовлетворять потребности клиента: добавлять позиции товаров и получать стоимость всего заказа.
 

В реализацию включить основные функции калькулятора: запросы цены единицы товара и стоимости доставки.

![Alt text](/Task/Image/10.PNG?raw=true "UML паттерн Bridge")

Вид приложения после запуска:

![Alt text](/Task/Image/11.PNG?raw=true "Вид приложения после запуска")


Пример реализации метода `AddProduct`:
```C#
public override void AddProduct(uint itemId, uint itemQuantity)
        {
            decimal price=priceCalcImpl.GetProductPrice(itemId);
            products.Add(new ProductInCart { Id = itemId, Price = price, Quantity = itemQuantity });
        }
```

Пример реализации метода `GetTotalPrice`:
```C#
public override decimal GetTotalPrice(string shippingTo)
        {
            return (products.Sum(p=>p.Price)+priceCalcImpl.GetShippingPrice(shippingTo));
        }
```
