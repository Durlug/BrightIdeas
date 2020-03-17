import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CreateIdeaComponent } from './create-idea/create-idea.component';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { ProjectComponent } from './project/project.component';
import { CreateProfileComponent } from './user-profile/create-profile.component';
import { LoginComponent } from './user-profile/login.component';
import { UserPasswordComponent } from './user-profile/user-password.component';
import { AdminHomeComponent } from './admin-home/admin-home.component';
import { AdminNavComponent } from './admin-nav/admin-nav.component';

//import bootstrap from "bootstrap";
import { PendingIdeasComponent } from './pending-ideas/pending-ideas.component';
import { ReportsComponent } from './reports/reports.component';
import { PendingIdeasDetailsComponent } from './pending-ideas-details/pending-ideas-details.component';
import { ReportsDetailsComponent } from './reports-details/reports-details.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CreateIdeaComponent,
    UserProfileComponent,
    CreateProfileComponent,
    LoginComponent,
    UserPasswordComponent,
    ProjectComponent,
    AdminHomeComponent,
    AdminNavComponent,
    PendingIdeasComponent,
    ReportsComponent,
    PendingIdeasDetailsComponent,
    ReportsDetailsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'create-idea', component: CreateIdeaComponent },
      { path: 'user-profile', component: UserProfileComponent },
      { path: 'create-profile', component: CreateProfileComponent },
      { path: 'login', component: LoginComponent },
      { path: 'password', component: UserPasswordComponent },
      { path: 'project', component: ProjectComponent },
      { path: 'admin-home', component: AdminHomeComponent},
      { path: 'pending-ideas', component: PendingIdeasComponent},
      { path: 'reports', component: ReportsComponent},
      { path: 'pending-ideas-details', component: PendingIdeasDetailsComponent},
      { path: 'reports-details', component: ReportsDetailsComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
