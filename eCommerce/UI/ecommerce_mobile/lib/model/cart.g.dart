// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'cart.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Cart _$CartFromJson(Map<String, dynamic> json) => Cart(
      id: (json['id'] as num?)?.toInt() ?? 0,
      userId: (json['userId'] as num?)?.toInt() ?? 0,
      cartItems: (json['cartItems'] as List<dynamic>?)
              ?.map((e) => CartItem.fromJson(e as Map<String, dynamic>))
              .toList() ??
          const [],
    );

Map<String, dynamic> _$CartToJson(Cart instance) => <String, dynamic>{
      'id': instance.id,
      'userId': instance.userId,
      'cartItems': instance.cartItems,
    };

CartItem _$CartItemFromJson(Map<String, dynamic> json) => CartItem(
      id: (json['id'] as num?)?.toInt() ?? 0,
      productId: (json['productId'] as num?)?.toInt() ?? 0,
      cartId: (json['cartId'] as num?)?.toInt() ?? 0,
      quantity: (json['quantity'] as num?)?.toInt() ?? 0,
      product: json['product'] == null
          ? null
          : Product.fromJson(json['product'] as Map<String, dynamic>),
    );

Map<String, dynamic> _$CartItemToJson(CartItem instance) => <String, dynamic>{
      'id': instance.id,
      'cartId': instance.cartId,
      'productId': instance.productId,
      'quantity': instance.quantity,
      'product': instance.product,
    };
