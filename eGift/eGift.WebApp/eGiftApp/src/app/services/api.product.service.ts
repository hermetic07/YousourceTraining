import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from "rxjs/index";
import {ProductsResponse} from "../models/Products/api.products.response";
import {ProductsRequest} from "../models/Products/api.products.request";

@Injectable()
export class ProductApiService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:44335/api/Products/';

  getProducts(product: ProductsRequest) : Observable<ProductsResponse> {
    return this.http.post<ProductsResponse>(this.baseUrl+"GetProducts", product);
  }

}