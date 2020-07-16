import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {OrderApiService} from "../../services/api.order.service";
import { OrdersResponse } from 'src/app/models/api.orders.response';
import { OrdersRequest } from 'src/app/models/api.orders.request';
import {OrderCheckout} from "src/app/models/orderCheckout.model";
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-create-order',
  templateUrl: './create-order.component.html',
  styleUrls: ['./create-order.component.css']
})
export class CreateOrderComponent implements OnInit {

  productPrice: number;
  productName: string;
  orderCheckout = new OrderCheckout(this.route.snapshot.paramMap.get('id'),'','','','',0,0);
  orderRequest: OrdersRequest;
  orderResponse = new OrdersResponse();
  loading = false;

  constructor(private route: ActivatedRoute, private router: Router, private apiService: OrderApiService) { 

  }

  ngOnInit(): void {
    this.productName = this.route.snapshot.paramMap.get('productName');
    this.productPrice = parseInt(this.route.snapshot.paramMap.get('productPrice'));
  }

  onSubmit(orderCheckoutForm: NgForm){
    
    this.loading = true;
    this.orderRequest = new OrdersRequest();
    this.orderRequest.data = this.orderCheckout;

    this.apiService.postOrders(this.orderRequest).subscribe( data => {
      this.loading = false;
      orderCheckoutForm.reset();
    },
    error => {
      console.log(error);
    });
  }

  calculateTotal(){
    this.orderCheckout.orderTotal = this.productPrice * this.orderCheckout.orderQuantity;
  }
}
