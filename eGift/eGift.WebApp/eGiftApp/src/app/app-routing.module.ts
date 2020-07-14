import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ListMerchantComponent} from "./merchant/list-merchant/list-merchant.component";
import {ViewMerchantComponent} from "./merchant/view-merchant/view-merchant.component";
import {ListProductComponent} from "./product/list-product/list-product.component";
import {ViewProductComponent} from "./product/view-product/view-product.component";

const routes: Routes = [
  { path: 'list-merchant', component: ListMerchantComponent },
  { path: 'view-merchant', component: ViewMerchantComponent },
  { path: 'list-product', component: ListProductComponent },
  { path: 'view-product', component: ViewProductComponent },
  { path : '', component : ListMerchantComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
