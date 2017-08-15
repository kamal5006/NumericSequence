import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { NumericSequenceComponent } from "./components/numericsequence/numeric-sequence.component";

export const sharedConfig: NgModule = {
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        NumericSequenceComponent
    ],
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'numeric', pathMatch: 'full' },
            { path: 'numeric', component: NumericSequenceComponent },
            { path: '**', redirectTo: 'numeric' }
        ])
    ]
};
