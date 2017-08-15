import { Component } from '@angular/core';
import { NumericSequenceService } from "../../shared/numeric-sequence.service";
import { isNumeric } from "rxjs/util/isNumeric";

@Component({
    selector: 'numeric',
    templateUrl: './numeric-sequence.component.html'
})
export class NumericSequenceComponent{

  
    num: number;
    numbericSequence:any;
    constructor(private numericSequenceService: NumericSequenceService) {
       
    }

    async getNumericSequence() {
        this.numbericSequence = await this.numericSequenceService.getNumericSequence(this.num);

    }

    get isInvalid(): boolean {
        let invalid: boolean = !isNumeric(this.num) || Number(this.num) < 0;
        return invalid;
    }
}

