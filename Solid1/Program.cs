/*
 * Тут прушено принцип єдиного обов’язку
 * Order є "Божественим об'єктом", який бере на себе багато обов'язків.
 * Потрібно розбити цей великий клас на декілька класів поменше.
 */


using System.Collections.Generic;

class Item
{
    // Інформація про товар
}

class Order
{
    private List<Item> itemList;

    internal List<Item> ItemList
    {
        get { return itemList; }
        set { itemList = value; }
    }

    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}

class OrderPrinter
{
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}

class OrderManager
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}

class Program
{
    static void Main()
    {

    }
}
