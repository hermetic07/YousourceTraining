import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListMerchantComponent } from './merchant/list-merchant/list-merchant.component';
import { ListProductComponent } from './product/list-product/list-product.component';
import { ListOrderComponent } from './order/list-order/list-order.component';
import { CreateOrderComponent } from './order/create-order/create-order.component';
import { HttpClientModule} from "@angular/common/http";
import { MerchantApiService} from "./services/api.merchant.service";
import { ProductApiService} from "./services/api.product.service";
import { OrderApiService} from "./services/api.order.service";
import { MinValidatorDirective} from "./directives/min-validator.directive";

@NgModule({
  declarations: [
    AppComponent,
    ListMerchantComponent,
    ListProductComponent,
    ListOrderComponent,
    CreateOrderComponent,
    MinValidatorDirective,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot() 
  ],
  providers: [
    MerchantApiService,
    ProductApiService,
    OrderApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
