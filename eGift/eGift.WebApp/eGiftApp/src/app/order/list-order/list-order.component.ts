import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";
import {OrderApiService} from "../../services/api.order.service";
import {OrdersResponse} from "../../models/Orders/api.orders.response";

@Component({
  selector: 'app-list-order',
  templateUrl: './list-order.component.html',
  styleUrls: ['./list-order.component.css']
})
export class ListOrderComponent implements OnInit {

  orders = new OrdersResponse();

  constructor(private router: Router, private apiService: OrderApiService) { }

  ngOnInit(): void {

    this.apiService.getOrders().subscribe( data => {
      this.orders = data;
    });

  }

}
