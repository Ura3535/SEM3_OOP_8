/*
 * У коді порушено принцип єдиного обов'язку.
 * При зміні логування нам прийдеться змінювати EmailSender.
 * Можна винести логування в окремий клас і використовувати інтерфейс.
 */

using System;
class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}
interface ILogger
{
    void Log(string message);
}
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
class EmailSender
{
    private readonly ILogger logger;
    public EmailSender(ILogger logger)
    {
        this.logger = logger;
    }
    public void Send(Email email)
    {
        // ... sending... 
        logger.Log($"Email from '{email.From}' to '{email.To}' with theme '{email.Theme}' was sent");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };
        EmailSender es = new EmailSender(new ConsoleLogger());
        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);
        Console.ReadKey();
    }
}