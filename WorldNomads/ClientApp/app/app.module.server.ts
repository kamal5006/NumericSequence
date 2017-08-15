import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { sharedConfig } from './app.module.shared';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import Numericsequenceservice = require("./shared/numeric-sequence.service");
import NumericSequenceService = Numericsequenceservice.NumericSequenceService;

@NgModule({
    bootstrap: sharedConfig.bootstrap,
    declarations: sharedConfig.declarations,
    imports: [
        ServerModule,
        FormsModule,
        ReactiveFormsModule,
        ...sharedConfig.imports
    ],
    providers: [NumericSequenceService]
})
export class AppModule {
}
