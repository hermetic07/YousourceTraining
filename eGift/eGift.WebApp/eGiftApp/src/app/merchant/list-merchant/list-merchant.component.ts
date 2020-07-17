import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";
import {MerchantApiService} from "../../services/api.merchant.service";
import {MerchantsResponse} from "../../models/Merchants/api.merchants.response";

@Component({
  selector: 'app-list-merchant',
  templateUrl: './list-merchant.component.html',
  styleUrls: ['./list-merchant.component.css']
})
export class ListMerchantComponent implements OnInit {

  merchants = new MerchantsResponse();

  constructor(private router: Router, private apiService: MerchantApiService) { }

  ngOnInit(): void {
    
    this.apiService.getMerchants().subscribe( data => {
      this.merchants = data;
    });

  }

}
