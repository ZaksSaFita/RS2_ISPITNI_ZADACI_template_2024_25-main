// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'shop.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

ShopCart _$ShopCartFromJson(Map<String, dynamic> json) => ShopCart(
      id: (json['id'] as num?)?.toInt() ?? 0,
      userId: (json['userId'] as num?)?.toInt() ?? 0,
      cartItems: (json['cartItems'] as List<dynamic>?)
              ?.map((e) => ShopItem.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
    );

Map<String, dynamic> _$ShopCartToJson(ShopCart instance) => <String, dynamic>{
      'id': instance.id,
      'userId': instance.userId,
      'cartItems': instance.cartItems,
    };

ShopItem _$ShopItemFromJson(Map<String, dynamic> json) => ShopItem(
      id: (json['id'] as num?)?.toInt() ?? 0,
      cartId: (json['cartId'] as num?)?.toInt() ?? 0,
      quantity: (json['quantity'] as num?)?.toInt() ?? 0,
      productId: (json['productId'] as num?)?.toInt() ?? 0,
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
      assets: (json['assets'] as List<dynamic>?)
              ?.map((e) => Asset.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
    );

Map<String, dynamic> _$ShopItemToJson(ShopItem instance) => <String, dynamic>{
      'id': instance.id,
      'cartId': instance.cartId,
      'productId': instance.productId,
      'quantity': instance.quantity,
      'product': instance.product,
      'assets': instance.assets,
    };
