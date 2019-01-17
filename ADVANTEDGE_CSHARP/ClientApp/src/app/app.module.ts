import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { FetchJsonComponent } from './fetch-json/fetch-json.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,            
    FetchJsonComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: FetchJsonComponent, pathMatch: 'full' },            
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
