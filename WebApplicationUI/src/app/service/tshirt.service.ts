import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Tshirt } from '../models/tshirt.model';

@Injectable({
    providedIn: 'root',
})
export class TshirtService {
    private url = `${environment.apiUrl}/tshirts`;

    constructor(private http: HttpClient) { }

    public get(): Observable<Array<Tshirt>> {
        return this.http.get<Array<Tshirt>>(this.url);
    }
}