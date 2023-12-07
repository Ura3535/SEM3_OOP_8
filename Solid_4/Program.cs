/*
 * Тут порушено принцип розділення інтерфейсу
 * Можна переписати інтерфейс, розділивши його на кілька менших інтерфейсів.
 */

using System;

interface IDiscountable
{
    void ApplyDiscount(string discount);
}

interface IPromocodeApplicable
{
    void ApplyPromocode(string promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizeable
{
    void SetSize(byte size);
}

interface IPriced
{
    void SetPrice(double price);
}

class Book : IDiscountable, IPriced
{
    public void ApplyDiscount(string discount) {/*...*/}
    public void SetPrice(double price) {/*...*/}
}

class Clothing : IDiscountable, IPromocodeApplicable, IColorable, ISizeable, IPriced
{
    public void ApplyDiscount(string discount) {/*...*/}
    public void ApplyPromocode(string promocode) {/*...*/}
    public void SetColor(byte color) {/*...*/}
    public void SetSize(byte size) {/*...*/}
    public void SetPrice(double price) {/*...*/}
}

class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
    }
}
