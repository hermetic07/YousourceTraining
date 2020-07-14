namespace Egift.Services.Order.Data.Factories
{
    using System.Data;
    using System.Data.SqlClient;
    using Egift.Services.Order.Data.Entities;

    /// <summary>
    /// Sql Command Factories remove responsibility from the Data Gateways by creating SqlCommands to be executed.
    /// This includes but not limited to: Setting the Command Name, Parameters, and Etc.
    /// </summary>
    public class OrderSqlCommandFactory : IOrderSqlCommandFactory
    {
        public SqlCommand CreateInsertOrderCommand(OrderEntity order)
        {
            var result = new SqlCommand("sp_InsertOrder")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            result.Parameters.AddWithValue("@productId", order.ProductId);
            result.Parameters.AddWithValue("@senderName", order.SenderName);
            result.Parameters.AddWithValue("@senderEmail", order.SenderEmail);
            result.Parameters.AddWithValue("@recipientName", order.RecipientName);
            result.Parameters.AddWithValue("@recipientEmail", order.RecipientEmail);

            return result;
        }

        public SqlCommand CreateGetOrdersCommand()
        {
            var result = new SqlCommand("sp_GetOrders")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            return result;
        }

        public SqlCommand CreateGetOrderCommand(OrderEntity order)
        {
            var result = new SqlCommand("sp_GetOrder")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            result.Parameters.AddWithValue("@id", order.OrderId);

            return result;
        }
    }
}