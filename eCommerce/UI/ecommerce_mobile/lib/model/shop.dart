import 'package:ecommerce_mobile/model/asset.dart';
import 'package:ecommerce_mobile/model/product.dart';
import 'package:json_annotation/json_annotation.dart';

part 'shop.g.dart';

@JsonSerializable()
class ShopCart {
  final int id;
  final int userId;
  final List<ShopItem>? cartItems;

  ShopCart({this.id = 0, this.userId = 0, this.cartItems = const []});

  factory ShopCart.fromJson(Map<String, dynamic> json) =>
      _$ShopCartFromJson(json);

  Map<String, dynamic> toJson() => _$ShopCartToJson(this);
}

@JsonSerializable()
class ShopItem {
  final int id;
  final int cartId;

  final int productId;
  final int quantity;
  final Product? product;
  final List<Asset> assets;
  ShopItem({
    this.id = 0,
    this.cartId = 0,
    this.quantity = 0,
    this.productId = 0,
    this.product,
    this.assets = const [],
  });

  factory ShopItem.fromJson(Map<String, dynamic> json) =>
      _$ShopItemFromJson(json);

  Map<String, dynamic> toJson() => _$ShopItemToJson(this);
}
