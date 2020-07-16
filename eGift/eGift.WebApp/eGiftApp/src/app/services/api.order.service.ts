import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from "rxjs/index";
import {OrdersResponse} from "../models/api.orders.response";
import {OrdersRequest} from "../models/api.orders.request";

@Injectable()
export class OrderApiService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:44335/api/Orders/';

  postOrders(product: OrdersRequest){
    return this.http.post(this.baseUrl+"CreateOrder", product);
  }

}