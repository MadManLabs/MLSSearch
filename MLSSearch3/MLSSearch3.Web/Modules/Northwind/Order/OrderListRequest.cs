using Serenity.Services;

namespace MLSSearch3.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}