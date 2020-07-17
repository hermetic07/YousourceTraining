import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ListMerchantComponent} from "./merchant/list-merchant/list-merchant.component";
import {ListProductComponent} from "./product/list-product/list-product.component";
import {CreateOrderComponent} from "./order/create-order/create-order.component";
import {ListOrderComponent} from "./order/list-order/list-order.component";

const routes: Routes = [
  { path: 'list-merchant', component: ListMerchantComponent },
  { path: 'list-order', component: ListOrderComponent },
  { path: 'list-product/:merchant/:id', component: ListProductComponent },
  { path: 'order-checkout/:productName/:productPrice/:id', component: CreateOrderComponent },
  { path : '', component : ListMerchantComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
