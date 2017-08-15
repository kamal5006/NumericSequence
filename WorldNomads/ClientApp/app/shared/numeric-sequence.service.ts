import { Injectable,Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

@Injectable()
export class NumericSequenceService {
    
    constructor(private http: Http, @Inject('ORIGIN_URL') private originUrl: string) {
    }

    async getNumericSequence(num: number) {
        const apiUrl = this.originUrl + '/api/NumericSequence/GetNumericSequence?number=' + num; 
        let httpResponse: any = await this.http.get(apiUrl).toPromise();
        let apiResponse: any = httpResponse.json();
       
        if (apiResponse.isSuccess) {
            return apiResponse.data;
        } else {
            alert(apiResponse.errorMessage);
        }
    }

}