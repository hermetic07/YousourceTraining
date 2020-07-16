export class OrderCheckout {

    constructor(
      public productId: string,
      public senderName: string,
      public senderEmail: string,
      public recipientName: string,
      public recipientEmail: string,
      public orderQuantity: number,
      public orderTotal: number
    )
    {}
  }