using System;

class SmsMessage
{
    private string messageText;
    private double price;

    public string MessageText
    {
        get { return messageText; }
        set
        {
            if (value.Length > 150)
            {
                messageText = value.Substring(0, 150);
            }
            else
            {
                messageText = value;
            }
            CalculatePrice();
        }
    }

    public double Price
    {
        get { return price; }
    }

    public SmsMessage(string text)
    {
        MessageText = text;
    }

    private void CalculatePrice()
    {
        int length = messageText.Length;
        if (length <= 55)
        {
            price = 1.5;
        }
        else
        {
            int extraCharacters = length - 55;
            price = 1.5 + (extraCharacters * 0.5);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сообщение:");
        string text = Console.ReadLine();

        SmsMessage sms = new SmsMessage(text);

        Console.WriteLine($"Стоимость сообщения: {sms.Price} р.");
    }
}