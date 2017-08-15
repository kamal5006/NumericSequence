import { Directive, Input, OnChanges, SimpleChanges } from '@angular/core';
import { AbstractControl, NG_VALIDATORS, Validator, ValidatorFn, Validators } from '@angular/forms';
import {isNumeric } from "rxjs/util/isNumeric";

export function invalidNumberValidator(): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } => {
        let isValid: Boolean = !isNumeric(control.value) || Number(control.value) < 0;
        return isValid ? { 'InvalidNumber': { value: control.value } } : null;
    };
}

@Directive({
  selector: '[invalidNumber]',
  providers: [{ provide: NG_VALIDATORS, useExisting: MinValueValidatorDirective, multi: true}]
})
export class MinValueValidatorDirective implements Validator {

  validate(control: AbstractControl): { [key: string]: any } {
      return invalidNumberValidator()(control);
  }
}

