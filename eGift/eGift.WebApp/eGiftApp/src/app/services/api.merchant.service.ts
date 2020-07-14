import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {Observable} from "rxjs/index";
import {MerchantsResponse} from "../models/api.merchants.response";

@Injectable()
export class MerchantApiService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:44335/api/Merchants/';

  getMerchants() : Observable<MerchantsResponse> {
    return this.http.get<MerchantsResponse>(this.baseUrl+"GetMerchants");
  }

}