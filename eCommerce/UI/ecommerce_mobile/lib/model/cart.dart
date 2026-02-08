import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cart.g.dart';

@JsonSerializable()
class Cart {
  final int id;
  final int userId;
  final List<CartItem> cartItems;

  Cart({
    this.id = 0,
    this.userId = 0,
    this.cartItems = const [],
  });
  factory Cart.fromJson(Map<String, dynamic> json) => _$CartFromJson(json);

  Map<String, dynamic> toJson() => _$CartToJson(this);
}

@JsonSerializable()
class CartItem {
  final int id;
  final int cartId;
  final int productId;
  final int quantity;
  final Product? product;

  CartItem(
      {this.id = 0,
      this.productId = 0,
      this.cartId = 0,
      this.quantity = 0,
      this.product});
  factory CartItem.fromJson(Map<String, dynamic> json) =>
      _$CartItemFromJson(json);

  Map<String, dynamic> toJson() => _$CartItemToJson(this);
}
