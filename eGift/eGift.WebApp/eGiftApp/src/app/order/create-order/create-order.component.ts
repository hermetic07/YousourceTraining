import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {OrderApiService} from "../../services/api.order.service";
import { OrdersResponse } from 'src/app/models/Orders/api.orders.response';
import { OrdersRequest } from 'src/app/models/Orders/api.orders.request';
import {Order} from "src/app/models/Orders/order.model";
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-create-order',
  templateUrl: './create-order.component.html',
  styleUrls: ['./create-order.component.css']
})
export class CreateOrderComponent implements OnInit {

  orderTotal = 0;
  orderCheckout = new Order();
  orderRequest: OrdersRequest;
  orderResponse = new OrdersResponse();
  loading = false;

  constructor(private route: ActivatedRoute, private router: Router, private apiService: OrderApiService, private toastr: ToastrService) { 

  }

  ngOnInit(): void {
    this.orderCheckout.productId = this.route.snapshot.paramMap.get('id');
    this.orderCheckout.productName = this.route.snapshot.paramMap.get('productName');
    this.orderCheckout.productPrice = parseInt(this.route.snapshot.paramMap.get('productPrice'));
  }

  onSubmit(orderCheckoutForm: NgForm){
    
    this.loading = true;
    this.orderRequest = new OrdersRequest();
    this.orderRequest.data = this.orderCheckout;

    this.apiService.postOrders(this.orderRequest).subscribe( data => {
      this.loading = false;
      orderCheckoutForm.reset();
      this.toastr.success('Order created', 'Success!');
    },
    error => {
      this.toastr.error(error,"Error");
    });
  }

  calculateTotal(){
    this.orderTotal = this.orderCheckout.productPrice * this.orderCheckout.orderQuantity;
  }
}
