import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'cart.g.dart';

@JsonSerializable()
class User {
  final int id;
  final String firstName;
  final String lastName;

  User({
    this.id = 0,
    this.firstName = "",
    this.lastName = "",
  });

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);
}

@JsonSerializable()
class Cart {
  final int id;
  final User? user;
  final List<CartItem> cartItems;

  Cart({this.id = 0, this.user, this.cartItems = const []});

  factory Cart.fromJson(Map<String, dynamic> json) => _$CartFromJson(json);

  Map<String, dynamic> toJson() => _$CartToJson(this);
}

@JsonSerializable()
class CartItem {
  final int id;
  final int quantity;
  final int productId;
  final Product? product;

  CartItem({
    this.id = 0,
    this.quantity = 0,
    this.productId = 0,
    this.product,
  });

  factory CartItem.fromJson(Map<String, dynamic> json) =>
      _$CartItemFromJson(json);

  Map<String, dynamic> toJson() => _$CartItemToJson(this);
}
