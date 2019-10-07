import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { Item } from '../models/item';
import { Volume } from '../models/volume';
import { DeliveryMethod } from '../models/deliveryMethod';
import { Order } from '../models/order';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getVolume(keyword: string = "search"): Observable<Volume> {
    return this.http.get<Volume>("http://localhost:5000/api/volume/" + keyword).pipe(
      tap(_ => this.log('fetched Volume')),
      catchError(this.handleError<Volume>('getVolume'))
    );
  }

  getDeliveryMethods(): Observable<DeliveryMethod[]> {
    return this.http.get<DeliveryMethod[]>("http://localhost:5000/api/DeliveryMethod").pipe(
      tap(_ => this.log('fetched DeliveryMethod')),
      catchError(this.handleError<DeliveryMethod[]>('getDeliveryMethods', []))
    );
  }

  orderItem(order: Order): Observable<Order> {
    return this.http.post<Order>("http://localhost:5000/api/Order", order, this.httpOptions).pipe(
      tap((newOrder: Order) => this.log(`added order w/ id=${newOrder.id}`)),
      catchError(this.handleError<Order>('addOrder'))
    );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  private log(message: string) {
    console.log(message);
  }
}