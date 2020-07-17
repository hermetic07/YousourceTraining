import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import {ProductApiService} from "../../services/api.product.service";
import { Product } from 'src/app/models/Products/product.model';
import { ProductsRequest } from 'src/app/models/Products/api.products.request';
import { ProductsResponse } from 'src/app/models/Products/api.products.response';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {

  product = new Product();
  products = new ProductsResponse();
  productWebRequest = new  ProductsRequest();
  merchantId: string;
  
  constructor(private route: ActivatedRoute, private router: Router, private apiService: ProductApiService) { 

  }

  ngOnInit(): void {
    this.product.merchantId = this.route.snapshot.paramMap.get('id');
    this.product.merchantName = this.route.snapshot.paramMap.get('merchant');
    this.productWebRequest.data = this.product;

    this.apiService.getProducts(this.productWebRequest).subscribe( data => {
      this.products = data;
    });
  }

}
