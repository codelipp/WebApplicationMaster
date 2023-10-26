import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Tshirt } from '../models/tshirt.model';

@Injectable({
    providedIn: 'root'
})

export class TshirtImageService {
    baseUrl = `${environment.apiUrl}/tshirt-images`;

    constructor(private http: HttpClient) { }

    public upload(file: any, tshirtId: any, colorId: any, fabricId: any): Observable<any> {
        const formData = new FormData();
        formData.append("file", file, file.name);

        const url = `${this.baseUrl}/${tshirtId}/${colorId}/${fabricId}`;

        return this.http.put<any>(url, formData, {
            reportProgress: true,
            observe: 'events'
        });
    }

    public delete(id: any): Observable<Tshirt> {
        return this.http.delete<Tshirt>(`${this.baseUrl}/${id}`);
    }
}
