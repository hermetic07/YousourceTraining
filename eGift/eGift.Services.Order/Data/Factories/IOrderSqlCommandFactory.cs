namespace Egift.Services.Order.Data.Factories
{
    using System.Data.SqlClient;
    using Egift.Services.Order.Data.Entities;

    public interface IOrderSqlCommandFactory
    {
        SqlCommand CreateInsertOrderCommand(OrderEntity product);

        SqlCommand CreateGetOrdersCommand();

        SqlCommand CreateGetOrderCommand(OrderEntity product);
    }
}
