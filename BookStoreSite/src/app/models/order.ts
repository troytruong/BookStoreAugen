import { Item } from './item';
import { DeliveryMethod } from './deliveryMethod';

export class Order {
    id:number;
    orderNumber:string;
    item: Item;
    deliveryMethod: DeliveryMethod;
}