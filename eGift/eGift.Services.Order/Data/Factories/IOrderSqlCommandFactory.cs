namespace eGift.Services.Order.Data.Factories
{
    using System.Data.SqlClient;
    using eGift.Services.Order.Data.Entities;

    public interface IOrderSqlCommandFactory
    {
        SqlCommand CreateInsertOrderCommand(OrderEntity product);

        SqlCommand CreateGetOrdersCommand();

        SqlCommand CreateGetOrderCommand(OrderEntity product);
    }
}

