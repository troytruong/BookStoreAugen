import { Component, OnInit } from '@angular/core';

import { BookService } from './services/book.service'
import { Item } from './models/item';
import { Volume } from './models/volume';
import { DeliveryMethod } from './models/deliveryMethod';
import { Order } from './models/order';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'BookStoreSite';
  items: Item[];

  keyword:string;

  deliveryMethods: DeliveryMethod[];

  selectedItem:Item;

  selectedDeliveryMethod: DeliveryMethod;

  order:Order;

  constructor(
    private bookService: BookService
  ) { }

  ngOnInit() {
    this.getItems();
    this.getDeliveryMethods();
  }

  getItems() : void {
    this.bookService.getVolume().subscribe(volume => this.items = volume.items);
  }

  getDeliveryMethods() : void {
    this.bookService.getDeliveryMethods().subscribe(methods => this.deliveryMethods = methods);
  }

  searchItems(){
    this.bookService.getVolume(this.keyword).subscribe(volume => this.items = volume.items);
  }

  addBook() {
    var order = new Order();
    order.item = this.selectedItem;
    order.deliveryMethod = this.selectedDeliveryMethod;
    this.bookService.orderItem(order).subscribe(order => this.order = order);
  }
}
