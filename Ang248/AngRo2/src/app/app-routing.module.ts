import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrderComponent } from './order/order.component';
import { CustNameComponent } from './cust-name/cust-name.component';

const routes: Routes = [
  { path:"order/:id", component : OrderComponent },
  { path:"custName/:id", component : CustNameComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
