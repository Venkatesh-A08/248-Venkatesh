import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { ProductComponent } from './product/product.component';
import { NotFoundComponent } from './not-found/not-found.component';

const routes: Routes = [
  { path : "home", component: HomeComponent },
  { path : "", pathMatch:"full", redirectTo:'home' },
  { path : "product", component: ProductComponent },
  { path : "contact", component: ContactComponent },
  { path : "**", component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
