import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListMerchantComponent } from './merchant/list-merchant/list-merchant.component';
import { ViewMerchantComponent } from './merchant/view-merchant/view-merchant.component';
import { ListProductComponent } from './product/list-product/list-product.component';
import { ViewProductComponent } from './product/view-product/view-product.component';
import { ListOrderComponent } from './order/list-order/list-order.component';
import { CreateOrderComponent } from './order/create-order/create-order.component';
import { ViewOrderComponent } from './order/view-order/view-order.component';
import {HttpClientModule} from "@angular/common/http";
import {MerchantApiService} from "./services/api.merchant.service";
import {ProductApiService} from "./services/api.product.service";

@NgModule({
  declarations: [
    AppComponent,
    ListMerchantComponent,
    ViewMerchantComponent,
    ListProductComponent,
    ViewProductComponent,
    ListOrderComponent,
    CreateOrderComponent,
    ViewOrderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [MerchantApiService,ProductApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
