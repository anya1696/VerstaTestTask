using System;

namespace SampleMVCApps
{
    public class Order
    {
        public int OrderId { get; set; }
        public string SenderCity { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientAddress { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
        public Order(string senderCity, string senderAddress, string recipientCity,
        string recipientAddress, float weight, DateTime date)
        {
            SenderCity = senderCity;
            SenderAddress = senderAddress;
            RecipientCity = recipientCity;
            RecipientAddress = recipientAddress;
            Weight = weight;
            Date = date;
        }
    }
}