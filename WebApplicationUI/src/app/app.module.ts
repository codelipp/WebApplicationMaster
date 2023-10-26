import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { TshirtsListComponent } from './tshirts-list/tshirts-list.component';
import { TshirtsDetailsComponent } from './tshirts-details/tshirts-details.component';
import { ImagesComponent } from './tshirts-details/components/images/images.component';

const routes: Routes = [
  { path: '', component: TshirtsListComponent },
  { path: 'details', component: TshirtsDetailsComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    TshirtsDetailsComponent,
    TshirtsListComponent,
    ImagesComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    MatIconModule,
    MatButtonModule
  ],
  providers: [],
  exports: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
