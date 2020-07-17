import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from "rxjs/index";
import {OrdersResponse} from "../models/Orders/api.orders.response";
import {OrdersRequest} from "../models/Orders/api.orders.request";

@Injectable()
export class OrderApiService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:44335/api/Orders/';

  postOrders(product: OrdersRequest){
    return this.http.post(this.baseUrl+"CreateOrder", product);
  }

  getOrders() : Observable<OrdersResponse> {
    return this.http.get<OrdersResponse>(this.baseUrl+"GetOrders");
  }
}