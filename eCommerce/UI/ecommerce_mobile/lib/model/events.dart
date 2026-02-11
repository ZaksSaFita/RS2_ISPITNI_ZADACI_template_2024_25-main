import 'package:ecommerce_mobile/model/cart.dart';
import 'package:json_annotation/json_annotation.dart';

part 'events.g.dart';

@JsonSerializable()
class Events {
  final int id;
  final String userFullName;
  final int cartId;
  final int cartItemId;
  final String eventType;
  final DateTime? createdAt;
  final String productName;
  final double productPrice;
  final int oldQuantity;
  final int newQuantity;

  Events({
    this.id = 0,
    this.userFullName = "",
    this.cartId = 0,
    this.cartItemId = 0,
    this.eventType = '',
    this.createdAt,
    this.productName = "",
    this.productPrice = 0,
    this.oldQuantity = 0,
    this.newQuantity = 0,
  });

  factory Events.fromJson(Map<String, dynamic> json) => _$EventsFromJson(json);

  Map<String, dynamic> toJson() => _$EventsToJson(this);
}
